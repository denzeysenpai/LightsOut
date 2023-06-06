using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightsOut.Classes
{
    internal class A_Guest : Accounts
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public A_Guest() 
        {
            Username = "Guest";
            Name = "Player 1";
        }
        //internal override void RegisterAccount(string username, string password, string nameOfUser)
        //{
        //    base.RegisterAccount(username, password, nameOfUser);
        //}
    }
}
