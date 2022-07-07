using Chain_of_responsabily.Middlewares;
using Chain_of_responsabily.Models;
using Chain_of_responsabily.Services.Interfaces;
using System;


namespace Chain_of_responsabily.Services
{
    class UserService : IUserService
    {

        private UserModel _user;
        private IMiddleware middleware;

        public UserService()
        {
        }

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
            return (middleware.Check(email, password)) ? true: false;
        }
        public void RegisterUser(string email, string password)
        {
            UserModel userModel = new UserModel();
            userModel.email = email;
            userModel.password = password;
        }

        public bool HasEmail(string email)
        {
            var hasEmail = _user.email.Equals(email);
            return hasEmail;
        }

        public bool HasPassword(string password)
        {
            var hasPassword = _user.password == password;
            return hasPassword;
        }
    }
}
