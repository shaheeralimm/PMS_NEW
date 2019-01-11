using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Userdetail
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Mobile { get; set; }
        public DateTime DOB { get; set; }
        public int Location { get; set; }
        public string Images { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public Guid UserId { get; set; }
        public ApplicationUser applicationUser { get; set; }
       
        public Userdetail()
        {
            DateCreated = DateTime.Now;
        }
    }
}
