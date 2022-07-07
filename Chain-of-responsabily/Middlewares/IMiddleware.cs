using System;

namespace Chain_of_responsabily.Middlewares
{
    abstract class IMiddleware
    {
        private IMiddleware next;

        /// <summary>
        /// Calculates the rate of an advance order
        /// </summary>
        /// <param name="token"></param>
        /// <param name="order"></param>
        /// <param name="orderNum"><
        public IMiddleware LinkWith(IMiddleware next)
        {
            this.next = next;

            return next;
        }


        /// <summary>
        /// Calculates the rate of an advance order
        /// </summary>
        /// <param name="token"></param>
        /// <param name="order"></param>
        /// <param name="orderNum"><
        public abstract Boolean Check(string email, string password);


        /// <summary>
        /// Calculates the rate of an advance order
        /// </summary>
        /// <param name="token"></param>
        /// <param name="order"></param>
        /// <param name="orderNum"><
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
