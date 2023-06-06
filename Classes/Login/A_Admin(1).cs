using System;
using System.Collections.Generic;
using System.IO;

namespace LightsOut.Classes
{
    internal class A_Admin : Accounts
    {
        // Initialize list (experimental)
        List<A_Admin> listOfAccounts = new List<A_Admin>();
        /// <summary>
        /// Default Constructor
        /// </summary>
        public A_Admin()
        {
            Name = "Mark Lloyd Reid Pascual Padilla";
            Username = "admin";
            Password = "@dmin123";
        }
        /// <summary>
        /// Method for checking accounts
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool CheckInAccountsList(string input)
        {
            foreach (A_Admin ob in listOfAccounts)
            {
                if (ob.Username == input)
                    return true;
                else
                    return false;
            }
            return false;
        }
        //internal override void registeraccount(string username, string password, string nameofuser)
        //{
        //    base.registeraccount(username, password, nameofuser); // temporary
        //}
        /// <summary>
        /// Log in to account method
        /// </summary>
        /// <param name="userNameinput"></param>
        /// <param name="passWordInput"></param>
        /// <returns></returns>
        internal bool LogInToAccount(string userNameinput, string passWordInput)
        {
            if (CheckUserName(userNameinput) && CheckPassword(passWordInput))
                return true;
            else
                return false;
        }
        /// <summary>
        /// Method for Checking username in records (?)
        /// </summary>
        /// <param name="userNameinput"></param>
        /// <returns></returns>
        internal bool CheckUserName(string userNameinput)
        {
            try
            {
                if (userNameinput == null || userNameinput == string.Empty) // -input value is null or empty
                    return false;
                else if (userNameinput == "admin") //-------------------------- input matches with record
                    return true;
                else //-------------------------------------------------------- input does not match
                    return false;
            }
            catch (Exception) { return false; } //----------------------------- if exception
        }
        /// <summary>
        /// Method for matching and checking the password of an account
        /// </summary>
        /// <param name="passWordInput"></param>
        /// <returns></returns>
        internal bool CheckPassword(string passWordInput)
        {
            try
            {
                if (passWordInput == null || passWordInput == string.Empty) // -password input is null or empty
                    return false;
                else if (passWordInput == Password) //------------------------- password matches with record
                    return true;
                else //-------------------------------------------------------- password does not match
                    return false;
            }
            catch (Exception) { return false; }//------------------------------ if exception
        } 
    }
}
