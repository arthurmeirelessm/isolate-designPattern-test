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
            service.RegisterUser("master@gmail.com", "123");
            service.RegisterUser("master@gmail.com", "12345");

            Middleware middleware = new CheckUserMiddeware(service);
        }

        static void Main(string[] args)
        {
            init();
        }
    }
}
