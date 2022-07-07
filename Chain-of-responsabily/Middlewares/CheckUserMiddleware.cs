using Chain_of_responsabily.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsabily.Middlewares
{
    class CheckUserMiddleware : IMiddleware
    {

        private IUserService _userService;

        public CheckUserMiddleware(IUserService userService)
        {
            _userService = userService;
        }

        public override bool Check(string email, string password)
        {
            if (_userService.HasEmail(email) && (_userService.HasPassword(password)))
            {
                return true;
            }
            return false;
        }
    }
}
