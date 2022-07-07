using Chain_of_responsabily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsabily.Services.Interfaces
{
    public interface IUserService
    {
        /// <summary>
        /// Calculates the rate of an advance order
        /// </summary>
        /// <param name="token"></param>
        /// <param name="order"></param>
        /// <param name="orderNum"></param>
        /// <returns></returns>
        Boolean Login(string email, string password);

        /// <summary>
        /// Calculates the rate of an advance order
        /// </summary>
        /// <param name="token"></param>
        /// <param name="order"></param>
        /// <param name="orderNum"></param>
        /// <returns></returns>
        void RegisterUser(string email, string password);

        /// <summary>
        /// Calculates the rate of an advance order
        /// </summary>
        /// <param name="token"></param>
        /// <param name="order"></param>
        /// <param name="orderNum"></param>
        /// <returns></returns>

        Boolean HasEmail(string email, string password);

        /// <summary>
        /// Calculates the rate of an advance order
        /// </summary>
        /// <param name="token"></param>
        /// <param name="order"></param>
        /// <param name="orderNum"></param>
        /// <returns></returns>
        Boolean HasPassword(string email, string password);
    }
}
