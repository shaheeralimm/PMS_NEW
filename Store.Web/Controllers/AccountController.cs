using AutoMapper;
using Store.Model;
using Store.Service;
using Store.Web.Helper;
using Store.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Store.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IApplicationUserService loginService;
        public AccountController(IApplicationUserService loginService)
        {
            this.loginService = loginService;
        }

        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel login)
        {
            if (login != null && login.Email != null)
            {
                string OldHASHValue = string.Empty;
                byte[] SALT = new byte[Security.saltLengthLimit];
                try
                {
                    var userInfo = loginService.GetUser(login.Email);
                    if (userInfo != null)
                    {
                        OldHASHValue = userInfo.HASH;
                        SALT = userInfo.SALT;
                    }
                    bool isLogin = Security.CompareHashValue(login.Password, login.Email, OldHASHValue, SALT);
                    if (isLogin)
                    {
                        //Login Success  
                        SignInRemember(login.Email, login.isRemember);
                        Session["UserID"] = userInfo.UserID;
                        return RedirectToLocal("");
                    }
                    else
                    {
                        TempData["ErrorMSG"] = "Access Denied! Wrong Credential";
                        return View(login);
                    }
                }
                catch
                {
                    throw;
                }
               
            }
            return View(login);
        }

        public ActionResult Logout()
        {
            try
            {
                FormsAuthentication.SignOut();
                // Second we clear the principal to ensure the user does not retain any authentication  
                //required NameSpace: using System.Security.Principal;  
                HttpContext.User = new GenericPrincipal(new GenericIdentity(string.Empty), null);
                Session.Clear();
                System.Web.HttpContext.Current.Session.RemoveAll();
                return RedirectToAction("Login");
            }
            catch
            {
                throw;
            }
        }

        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterFormViewModel newUser)
        {
            if (ModelState.IsValid && newUser.Email != null)
            {
                newUser.UserID = Guid.NewGuid();
                newUser.SALT = Security.Get_SALT();
                newUser.HASH = Security.Get_HASH_SHA512(newUser.Password, newUser.Email, newUser.SALT);
                var user = Mapper.Map<RegisterFormViewModel, ApplicationUser>(newUser);
                loginService.CreateUser(user);
                loginService.SaveUser();
            }
            else
            {
                return View(newUser);
            }
            return RedirectToAction("Login");
        }

        private ActionResult RedirectToLocal(string returnURL = "")
        {
            try
            {
                //if (!string.IsNullOrWhiteSpace(returnURL) && Url.IsLocalUrl(returnURL))
                //    return Redirect(returnURL);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                throw;
            }
        }

        private void SignInRemember(string userName, bool isPersistent = false)
        {
            // Clear any lingering authencation data  
            FormsAuthentication.SignOut();

            // Write the authentication cookie  
            FormsAuthentication.SetAuthCookie(userName, isPersistent);
        }
    }
}