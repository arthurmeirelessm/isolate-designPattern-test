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
            if(middleware.Check(email, password))
            {
                Console.WriteLine("Usario logado com sucesso");
                Console.WriteLine("Seja bem vindo!");
                return true;
            }

            return false;
        }

        public void RegisterUser(string email, string password)
        {
            users[email] = password;
        }


        public Boolean HasEmail(string email)
        {
            return users.ContainsKey(email);
        }


        public Boolean IsValidPassword(string email, string password)
        {
            string value = "";

            users.TryGetValue(email, out value);

            return password == value;
        }

    }
}
