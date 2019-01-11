using AutoMapper;
using Store.Model;
using Store.Service;
using Store.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.Web.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Profile()
        {
            return View();
        }
    }
}