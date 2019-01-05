using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class ApplicationUser
    {
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string HASH { get; set; }
        public byte[] SALT { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public ApplicationUser()
        {
            DateCreated = DateTime.Now;
        }
    }
}
