using LightsOut.Classes;
using LightsOut.Forms;
using System;
using System.Design.Assist;
using System.Drawing;
using System.Windows.Forms;


namespace LightsOut
{
    // Main
    public partial class frmLogInForm : Form
    {
        // Declarations of objects to be used in the form
        private Mark Design = new Mark();
        private A_Admin admin = new A_Admin();
        private frmLoadingWindow LoadingWindow = new frmLoadingWindow("guest");
        private frmLoadingWindow LoadingWindow2 = new frmLoadingWindow("admin");
        // redundant access modifier

        #region Colors
        //Sizes for the windows; 1519, 818 - Loading/Main Size

        // COLORS
        // 255, 186, 59 - bright yellow
        // 209, 138, 38
        // 179, 119, 36
        // 156, 94, 33
        #endregion


        /// <summary>
        /// Method used to call a Loading screen.
        /// </summary>
        internal void DisplayLoadingWindow(string identifier)
        {
            foreach (Control c in this.Controls)
            {
                c.Dispose();
            }
            if (identifier == "guest")
            {
                LoadingWindow.Enabled = true;
                LoadingWindow.Show();
            }
            else if (identifier == "admin")
            {
                LoadingWindow2 = new frmLoadingWindow("admin", admin) { Enabled = true };
                LoadingWindow2.Show();
            }
        }




        /// <summary>
        /// Adding style to controls during Initialization
        /// </summary>
        internal frmLogInForm(string identifier, A_Admin admin)
        {
            InitializeComponent();

            Design.RoundCorner(this, 30);
            Design.RoundCorner(pnlLogIn);
            Design.RoundCorner(btnExit, 10);
            Design.RoundCorner(pnlPass, 10);
            Design.RoundCorner(pnlUsNam, 10);
            Design.RoundCorner(btnLogIn, 10);
            Design.RoundCorner(btnRegister, 10);
            Design.RoundCorner(btnPlayAsGuest, 10);

            this.admin = admin ?? new A_Admin();
        }

        /// <summary>
        /// Adding style to controls during Initialization
        /// </summary>
        internal frmLogInForm()
        {
            InitializeComponent();

            Design.RoundCorner(this, 30);
            Design.RoundCorner(pnlLogIn, 30);
            Design.RoundCorner(btnExit, 10);
            Design.RoundCorner(pnlPass, 10);
            Design.RoundCorner(pnlUsNam, 10);
            Design.RoundCorner(btnLogIn, 10);
            Design.RoundCorner(btnRegister, 10);
            Design.RoundCorner(btnPlayAsGuest, 10);
        }




        /// <summary>
        /// Setting values durign first load up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogInForm_Load(object sender, EventArgs e)
        {
            LoadingWindow.Enabled = false;
            lblincorrectPass.Hide();
            lblincorrectUser.Hide();
            pnlShowPassword.Show();
            LoadingWindow.tmrLoading.Stop();
            txtPassword.Text = string.Empty;
            txtUserName.Text = string.Empty;

            #region Tooltips
            ToolTip toolTip1 = new ToolTip();

            toolTip1.Active = true;

            toolTip1.SetToolTip(btnLogIn,
                "Login to your account");
            toolTip1.SetToolTip(txtUserName,
                "Input username");
            toolTip1.SetToolTip(txtPassword,
                "Input your password");
            toolTip1.SetToolTip(btnRegister,
                "Don't have an account? Register now!");
            toolTip1.SetToolTip(btnPlayAsGuest,
                "Don't want to create an account? \nPlay as Guest!");
            toolTip1.SetToolTip(btnExit,
                ":(\nDon't leave me");
            toolTip1.SetToolTip(pnlPicture,
                "You can't hide");
            toolTip1.SetToolTip(lblWaterMark,
                "By Mark Josh G. Solante");
            #endregion
        }



        /// <summary>
        /// Exit button Mouse hover behaviour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_MouseHover(object sender, EventArgs e) => btnExit.ForeColor = Color.Red;



        /// <summary>
        /// Mouse leave change color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_MouseLeave(object sender, EventArgs e) => btnExit.ForeColor = Color.Cornsilk;




        // Buttons




        /// <summary>
        /// Exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e) => Environment.Exit(0);




        /// <summary>
        /// Play as guest, loads a different UI than the admin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayAsGuest_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                c.Dispose();
            }
            LoadingWindow.tmrLoading.Start();
            this.Hide();
            DisplayLoadingWindow("guest");
        }




        /// <summary>
        /// Registers account in a local storage (?)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            //implementation discontinued


            frmRegisterAccount register = new frmRegisterAccount();
            this.Hide();
            this.Enabled = false;
            register.Show();
            register.Enabled = true;
        }




        /// <summary>
        /// Log in button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            bool success = false;




            //---------------------------------------------------------- if input username is null or empty
            if ((txtUserName.Text == null || txtUserName.Text == string.Empty) &&
                (txtPassword.Text != null || txtPassword.Text != string.Empty))
                MessageBox.Show(
                    "Input username, username cannot be null",
                    "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);





            //---------------------------------------------------------- if input password is null or empty
            else if ((txtPassword.Text == null || txtPassword.Text == string.Empty) &&
                (txtUserName.Text != null || txtUserName.Text != string.Empty))
                MessageBox.Show(
                    "Input password, password cannot be null",
                    "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);





            //---------------------------------------------------------- if all fields are empty
            else if ((txtUserName.Text == null || txtUserName.Text == string.Empty) &&
                (txtPassword.Text == null || txtPassword.Text == string.Empty))
                MessageBox.Show(
                    "Input password and username, password and username cannot be null",
                    "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);




            else //----------------------------------------------------- all fields have correct input
                if (!admin.CheckUserName(txtUserName.Text)) //---------- if username input does not match with any account
            {
                lblincorrectUser.ForeColor = Color.Red;
                lblincorrectUser.Text = "NOT FOUND";
                lblincorrectUser.Show();
            }




            else //----------------------------------------------------- valid input of username
                if (!admin.CheckPassword(txtPassword.Text))
                lblincorrectPass.Show();




            else
            {
                lblincorrectPass.Hide();
                success = admin.LogInToAccount(txtUserName.Text, txtPassword.Text);
            }




            if (success == true) //------------------------------------- will only run after successful log in
            {
                this.Hide();
                this.Enabled = false;
                LoadingWindow2.tmrLoading.Start();
                DisplayLoadingWindow("admin");
            }
        }



        // Behaviors




        /// <summary>
        /// Hide password to password char
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hide(object sender, EventArgs e) //---------------- password hide
        {
            txtPassword.UseSystemPasswordChar = true;
            pnlShowPassword.Enabled = true;
            pnlShowPassword.Show();
            pnlHidePassword.Hide();
        }




        /// <summary>
        /// Show password to alphanumeric characters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Show(object sender, EventArgs e) //---------------- password show
        {
            txtPassword.UseSystemPasswordChar = false;
            pnlHidePassword.Enabled = true;
            pnlHidePassword.Show();
            pnlShowPassword.Hide();
        }




        /// <summary>
        /// Behavior for textbox and label, triggered when the username
        /// input is found
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text == "admin")
            {
                lblincorrectUser.Show();
                lblincorrectUser.Text = "FOUND";
                lblincorrectUser.ForeColor = Color.Green;
                txtUserName.BackColor = Color.Green;
            }
            else
            {
                txtUserName.BackColor = Color.FromArgb(150, 150, 150);
                lblincorrectUser.Hide();
            }
        }
    }
}


