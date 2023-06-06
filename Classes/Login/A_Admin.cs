using System;
using System.Collections.Generic;

namespace LightsOut.Classes
{
    internal class A_Admin : BaseClassAccounts
    {
        public int score;
#pragma warning disable CS0649 // Field 'A_Admin.keyscollected' is never assigned to, and will always have its default value 0
        public int keyscollected;
#pragma warning restore CS0649 // Field 'A_Admin.keyscollected' is never assigned to, and will always have its default value 0
        public DateTime datePlayed;
        public string GameStatus;

        // Initialize list (experimental)
        List<A_Admin> listOfAccounts = new List<A_Admin>();
        /// <summary>
        /// Default Constructor
        /// </summary>
        public A_Admin()
        {
            firstName = "Mark Lloyd Reid Pascual";
            Name = firstName + " " + lastName;
            joinedDate = "April 18, 2023";
            Password = "@dmin123";
            lastName = "Padilla";
            Username = "admin";
            gender = "Male";
            age = "20";
            selectedTheme = "yellow";
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
                return (ob.Username == input);
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
                bool InputForUsernameIsNull = userNameinput == null || userNameinput == string.Empty;
                bool UsernameMatches = userNameinput == "admin";

                if (InputForUsernameIsNull) // -input value is null or empty
                    return false;
                else//-------------------------- input matches with record
                    return UsernameMatches;
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
                bool PasswordCorrectInput = (passWordInput == null || passWordInput == string.Empty);
                bool PasswordMatches = passWordInput == Password;

                if (PasswordCorrectInput) // -password input is null or empty
                    return false;
                else //------------------------- password matches with record
                    return PasswordMatches;
            }
            catch (Exception) { return false; }//------------------------------ if exception
        }
    }
}
