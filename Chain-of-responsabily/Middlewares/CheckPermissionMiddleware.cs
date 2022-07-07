using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsabily.Middlewares
{
    class CheckPermissionMiddleware : IMiddleware
    {
        public override bool Check(string email, string password)
        {
            if (email.Equals("arthur@gmail.com"))
            {
                Console.WriteLine("Bem-vindo ADMINISTRADOR!");
                return true;
            }

            Console.WriteLine("Bem-vindo suário qualquer");
            return CheckNext(email, password);
        }
    }
}
