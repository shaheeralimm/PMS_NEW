using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Store.Web.ViewModels
{
    public class RegisterFormViewModel
    {
        public Guid UserID { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        [Compare("Password")]
        public string ComparePassword { get; set; }
        public string HASH { get; set; }
        public byte[] SALT { get; set; }
    }
}