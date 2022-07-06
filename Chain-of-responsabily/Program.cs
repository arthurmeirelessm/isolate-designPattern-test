using Chain_of_responsabily.Middlewares;
using Chain_of_responsabily.Servers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsabily
{
    class Program
    {
        private static Service service;

        static void init()
        {
            service = new Service();

            service.RegisterUser("arthur@gmail.com", "3333");

            Middleware middleware = new CheckUserMiddeware(service);

            middleware.LinkWith(new CheckPermissionMiddleware());

            service.SetMiddleware(middleware);
        }

        static void Main(string[] args)
        {
            init();

            Boolean done = false;


            do
            {
                Console.WriteLine("Digite o seu email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Digite o seu passwoprd");
                string password = Console.ReadLine();


                done = service.Login(email, password);

            } while (!done);
        }
    }
}
