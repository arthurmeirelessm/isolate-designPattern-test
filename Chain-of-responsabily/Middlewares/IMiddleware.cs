using System;

namespace Chain_of_responsabily.Middlewares
{
    abstract class IMiddleware
    {
        private IMiddleware next;

        public IMiddleware LinkWith(IMiddleware next)
        {
            this.next = next;

            return next;
        }

        public abstract Boolean Check(string email, string password);

        protected Boolean CheckNext(string email, string password)
        {
            if (next == null)
            {
                return true;
            }

            return Check(email, password);
        }
    }
}
