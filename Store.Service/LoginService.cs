using Store.Data.Infrastructure;
using Store.Data.Repositories;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service
{
    // operations you want to expose
    public interface IApplicationUserService
    {
        IEnumerable<ApplicationUser> GetUsers(string name = null);
        ApplicationUser GetUser(int id);
        ApplicationUser GetUser(string name);
        void CreateUser(ApplicationUser applicationuser);
        void SaveUser();
    }

    public class LoginService : IApplicationUserService
    {
        private readonly IApplicationUserRepository applicationuserRepository;
        private readonly IUnitOfWork unitOfWork;

        public LoginService(IApplicationUserRepository applicationuserRepository, IUnitOfWork unitOfWork)
        {
            this.applicationuserRepository = applicationuserRepository;
            this.unitOfWork = unitOfWork;
        }

        #region ICategoryService Members

        public IEnumerable<ApplicationUser> GetUsers(string email = null)
        {
            if (string.IsNullOrEmpty(email))
                return applicationuserRepository.GetAll();
            else
                return applicationuserRepository.GetAll().Where(c => c.Email == email);
        }

        public ApplicationUser GetUser(int id)
        {
            var category = applicationuserRepository.GetById(id);
            return category;
        }

        public ApplicationUser GetUser(string email)
        {
            var category = applicationuserRepository.GetUserByEmail(email);
            return category;
        }

        public void CreateUser(ApplicationUser category)
        {
            applicationuserRepository.Add(category);
        }

        public void SaveUser()
        {
            unitOfWork.Commit();
        }

        #endregion
    }
}
