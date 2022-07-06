using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsabily.Middlewares
{
    class CheckPermissionMiddleware : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (email.Equals("arthur@gmail.com") && (password.Equals("3333")))
            {
                Console.WriteLine("Login permitido!");
                return true;
            }

            return CheckNext(email, password);
        }
    }
}
