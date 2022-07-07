using Chain_of_responsabily.Middlewares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsabily.Services
{
     class UserService
    {
        private List<UserService> users = new List<UserService>();

        private IMiddleware middleware;

        public UserService(IMiddleware middleware)
        {
            this.middleware = middleware;
        }

        public Boolean Logic(string email, string password)
        {
            return true;
        } 

        public Boolean RegisterUser(string email, string password)
        {
            return true;
        }



    }
}
