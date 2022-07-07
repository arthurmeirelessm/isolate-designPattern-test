using Chain_of_responsabily.Middlewares;
using Chain_of_responsabily.Models;
using Chain_of_responsabily.Services;
using Chain_of_responsabily.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsabily
{
    class Program
    {

        private static UserService userService;

        static void init()
        {
            userService = new UserService();

            userService.RegisterUser("arthur@gmail.com", "123");

            IMiddleware middleware = new CheckUserMiddleware(userService);

            middleware.LinkWith(new CheckPermissionMiddleware());

            userService.SetMiddleware(middleware);

        }
        static void Main(string[] args)
        {
            init();


            Boolean done;

            do
            {

                Console.WriteLine("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Password: ");
                string password = Console.ReadLine();

                done = userService.Login(email, password);

            }while (!done);
        }
    }
}
