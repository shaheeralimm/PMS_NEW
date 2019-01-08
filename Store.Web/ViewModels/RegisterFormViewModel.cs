﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Web.ViewModels
{
    public class RegisterFormViewModel
    {
        public Guid UserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string HASH { get; set; }
        public byte[] SALT { get; set; }
    }
}