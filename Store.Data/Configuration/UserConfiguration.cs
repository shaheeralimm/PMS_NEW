using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    public class UserConfiguration : EntityTypeConfiguration<Userdetail>
    {
        public UserConfiguration()
        {
            ToTable("Userdetails");
            Property(g => g.FullName).IsRequired();
            Property(g => g.Mobile).IsRequired();
            Property(g => g.DOB).IsRequired();
            Property(g => g.Id).IsRequired();
            Property(g => g.Location).IsRequired();
        }
    }
}
