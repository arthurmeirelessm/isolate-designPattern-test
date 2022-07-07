using Chain_of_responsabily.Middlewares;
using Chain_of_responsabily.Models;
using Chain_of_responsabily.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsabily.Services
{
    class UserService : IUserService
    {

        private UserModel _user;
        private IMiddleware middleware;

        public UserService(UserModel user)
        {
            _user = user;
        }

        public void SetMiddleware(IMiddleware middleware)
        {
            this.middleware = middleware;
        }

        public bool Login(string email, string password)
        {
            if (middleware.Check(email, password))
            {
                Console.WriteLine("Bem-vindo!");
                return true;
            }
            return false;
        }
        public void RegisterUser(string email, string password)
        {
            UserModel userModel = new UserModel();
            userModel.email = email;
            userModel.password = password;
        }

        public bool HasEmail(string email, string password)
        {
            var hasEmail = _user.email == email;

            if (hasEmail)
            {
                return true;
            }

            return false;
        }

        public bool HasPassword(string email, string password)
        {
            var hasPassword = _user.password == password;

            if (hasPassword)
            {
                return true;
            }

            return false;
        }
    }
}
