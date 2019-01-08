using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class ApplicationUser
    {
        [Key]
        public Guid UserID { get; set; }
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
