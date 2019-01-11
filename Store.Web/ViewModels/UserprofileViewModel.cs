using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Web.ViewModels
{
    public class UserprofileViewModel
    {
        public HttpPostedFileBase File { get; set; }
        public string UserName { get; set; }
        public string UserMobile { get; set; }
        public string UserDOB { get; set; }
        public int UserLocation { get; set; }
        public Guid UserId { get; set; }
    }
}