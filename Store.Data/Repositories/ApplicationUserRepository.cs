using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    public class ApplicationUserRepository : RepositoryBase<ApplicationUser>, IApplicationUserRepository
    {
        public ApplicationUserRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public ApplicationUser GetUserByEmail(string email)
        {
            var applicationUser = this.DbContext.ApplicationUsers.Where(c => c.Email == email).FirstOrDefault();

            return applicationUser;
        }

        public override void Update(ApplicationUser entity)
        {
            entity.DateUpdated = DateTime.Now;
            base.Update(entity);
        }
    }

    public interface IApplicationUserRepository : IRepository<ApplicationUser>
    {
        ApplicationUser GetUserByEmail(string Email);
    }
}
