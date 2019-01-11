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
    public interface IUserService
    {
        IEnumerable<Userdetail> GetUsers(string name = null);
        Userdetail GetUser(int id);
        Userdetail GetUser(Guid userid);
        void CreateUser(Userdetail user);
        void SaveUser();
    }

    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IUnitOfWork unitOfWork;

        public UserService(UserRepository userRepository, IUnitOfWork unitOfWork)
        {
            this.userRepository = userRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IUserService Members

        public IEnumerable<Userdetail> GetUsers(string name = null)
        {
            if (string.IsNullOrEmpty(name))
                return userRepository.GetAll();
            else
                return userRepository.GetAll().Where(c => c.FullName == name);
        }

        public Userdetail GetUser(int id)
        {
            var user = userRepository.GetById(id);
            return user;
        }

        public Userdetail GetUser(Guid UserId)
        {
            var user = userRepository.GetUserById(UserId);
            return user;
        }

        public void CreateUser(Userdetail user)
        {
            userRepository.Add(user);
        }

        public void SaveUser()
        {
            unitOfWork.Commit();
        }

        #endregion
    }
}
