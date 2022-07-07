using Chain_of_responsabily.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsabily.Middlewares
{
    class UserMiddleware : IMiddleware
    {

        private IUserService _userService;

        public override bool Check(string email, string password)
        {
            if (_userService.HasEmail(email, password))
            {
                return true;
            }
            return false;
        }
    }
}
