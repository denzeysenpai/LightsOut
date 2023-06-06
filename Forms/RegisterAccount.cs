using System;
using System.Design.Assist;
using System.Drawing;
using System.Windows.Forms;

namespace LightsOut.Forms
{
    public partial class frmRegisterAccount : Form
    {
        // this form is not complete therefore, don't call this form
        // this form can only be exited by stoping the execution of the form


        // unifinished :(
        Mark Design = new Mark();
#pragma warning disable CS0414 // The field 'frmRegisterAccount.page3' is assigned but its value is never used
        bool page1, page2, page3;
#pragma warning restore CS0414 // The field 'frmRegisterAccount.page3' is assigned but its value is never used
        string name;
        public frmRegisterAccount()
        {
            InitializeComponent();


            // -5, 27 // location of pages
            // Round cornners of the controls dor design
            Design.RoundCorner(this, 30);
            Design.RoundCorner(txtName, 40);
            Design.RoundCorner(pnlName, 40);
            Design.RoundCorner(txtUsernameInput, 40);
            // Solante >> System.cs (View Code)
        }


        private void frmRegisterAccount_Load(object sender, EventArgs e)
        {
            // Set the location of the pages
            pnlPage1.Location = new Point(-5, 27);
            pnlPage2.Location = new Point(-5, 27);
            pnlPage3.Location = new Point(-5, 27);


            // Arrange the pages in order
            pnlPage2.BringToFront();
            pnlPage1.BringToFront();


            // Set values by default
            page1 = false;
            page2 = false;
            page3 = false;
            name = "";

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            page2 = true;

            // Greeting on page 3
            lblGreeting.Text =
                $"Hello {name}! " +
                $"\nLet's Get Started!";
        }

        private void btnNextAfterUsernameInput_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateAnAccount_Click(object sender, EventArgs e)
            => page1 = true;

        private void movePages(object sender, EventArgs e)
        {
            // Sliding Animations for pages
            if (page1 && pnlPage1.Left > 0 - pnlPage1.Width) // page 1
                pnlPage1.Left -= 25;
            if (page2 && pnlPage2.Left > 0 - pnlPage2.Width) // page 2
                pnlPage2.Left -= 25;
        }
    }
}
