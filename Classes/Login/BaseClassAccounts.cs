namespace LightsOut.Classes
{
    internal class BaseClassAccounts
    {
        private string username;
        private string password;
        private string name;
        public string joinedDate, firstName, lastName, age, gender, selectedTheme;

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                if (username is null)
                    username = "admin";
                else
                    username = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                //var specialChar = @"!@#$~%^&*()_+{}[]:'\<>?,./'=+-";
                //try
                //{
                //    foreach (char item in specialChar)
                //        if (password.Contains(item))
                //            password = value;
                //}
                //catch (Exception) {/**/}

                password = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        //internal FileStream f;



        /// <summary>
        /// Method for registering new accounts (implementation in progress)
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="nameOfUser"></param>
        internal virtual void RegisterAccount(string username, string password, string nameOfUser)
        {
            this.Username = username;
            this.Password = password;
            this.Name = nameOfUser;


            //f = new FileStream(@"C:\Users\ACT-STUDENT\Desktop\FinalProject\" + "Accounts.txt", FileMode.OpenOrCreate); // Create file          
            //StreamWriter eh = new StreamWriter(f); // Create value in file
            //eh.WriteLine(Username); // input value in file^^^


            ////
            //eh.Close();
            //f.Close();
        }
    }
}
