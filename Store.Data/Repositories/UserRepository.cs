using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    public class UserRepository : RepositoryBase<Userdetail>, IUserRepository
    {
        public UserRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public Userdetail GetUserById(Guid userid)
        {
            var applicationUser = this.DbContext.Userdetails.Where(c => c.UserId == userid).FirstOrDefault();

            return applicationUser;
        }

        public override void Update(Userdetail entity)
        {
            entity.DateUpdated = DateTime.Now;
            base.Update(entity);
        }
    }

    public interface IUserRepository : IRepository<Userdetail>
    {
        Userdetail GetUserById(Guid UserId);
    }
}
