using Chain_of_responsabily.Models;
using System;


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

        Boolean HasEmail(string email);

        /// <summary>
        /// Calculates the rate of an advance order
        /// </summary>
        /// <param name="token"></param>
        /// <param name="order"></param>
        /// <param name="orderNum"></param>
        /// <returns></returns>
        Boolean HasPassword(string password);
    }
}
