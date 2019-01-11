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
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be {2} character.", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The confirm password do not match.")]
        public string ComparePassword { get; set; }
        public string HASH { get; set; }
        public byte[] SALT { get; set; }
    }
}