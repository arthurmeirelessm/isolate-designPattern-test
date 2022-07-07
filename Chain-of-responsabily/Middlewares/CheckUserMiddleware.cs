using Chain_of_responsabily.Models;
using Chain_of_responsabily.Services.Interfaces;
using System;


namespace Chain_of_responsabily.Middlewares
{
    class CheckUserMiddleware : IMiddleware
    {

        private UserModel user;
        private IUserService userService;

        public CheckUserMiddleware(UserModel user)
        {
            this.user = user;
        }

        public CheckUserMiddleware(IUserService userService)
        {
            this.userService = userService;
        }

        public override bool Check(string email, string password)
        {

            if (!userService.HasEmail(email))
            {
                Console.WriteLine("Email inválido");
                return false;
            }

            if (!userService.HasPassword(password))
            {
                Console.WriteLine("Password inváido");
                return false;
            }

            return CheckNext(email, password);
        }
    }
}
