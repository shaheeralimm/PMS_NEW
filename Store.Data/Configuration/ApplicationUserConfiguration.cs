using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    public class ApplicationUserConfiguration : EntityTypeConfiguration<ApplicationUser>
    {
        public ApplicationUserConfiguration()
        {
            ToTable("ApplicationUsers");
            Property(g => g.Email).IsRequired();
            Property(g => g.HASH).IsRequired();
            Property(g => g.SALT).IsRequired();
            Property(g => g.UserID).IsRequired();
        }
    }
}
