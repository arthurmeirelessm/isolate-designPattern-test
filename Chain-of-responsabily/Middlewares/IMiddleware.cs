using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsabily.Middlewares
{
    abstract class IMiddleware
    {
        private IMiddleware next;

        protected IMiddleware LinkWwith(IMiddleware next)
        {
            this.next = next;

            return this;
        }
    }
}
