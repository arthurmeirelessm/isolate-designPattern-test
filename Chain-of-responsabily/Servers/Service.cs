using Chain_of_responsabily.Middlewares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsabily.Servers
{
     class Service
    {

        private Middleware middleware;

        public void SetMiddleware(Middleware middleware)
        {
            this.middleware = middleware;
        }
     
        
        private Dictionary<string, string> users = new Dictionary<string, string>();


        public Boolean Login(string email, string password)
        {
            return true;
        }

        public void RegisterUser(string email, string password)
        {
        }


        public Boolean HasEmail(string email)
        {
            return true;
        }


        public Boolean IsValidPassword(string password)
        {
            return true;
        }

    }
}
