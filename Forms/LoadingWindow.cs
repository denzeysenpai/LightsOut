using LightsOut.Classes;
using LightsOut.Properties;
using System;
using System.Windows.Forms;

namespace LightsOut
{
    internal partial class frmLoadingWindow : Form
    {
        internal frmHomePage AdminHomepage = new frmHomePage("admin");
        internal frmHomePage GuestHomePage = new frmHomePage("guest");
        private string gameStatus;
        private string identifier;
        bool pageLoad = false;



        /// <summary>
        /// Default Constructor
        /// </summary>
        public frmLoadingWindow()
        {
            InitializeComponent();

        }



        /// <summary>
        /// Parameterized Contrsuctor for forms, to pass data between forms
        /// </summary>
        /// <param name="identifier"></param>
        public frmLoadingWindow(string identifier)
        {
            InitializeComponent();
            this.identifier = identifier;
        }



        /// <summary>
        /// Constructor for Passing the object name to other forms : Admin
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="admin"></param>
        public frmLoadingWindow(string identifier, A_Admin admin)
        {
            InitializeComponent();
            gameStatus = admin.GameStatus;
            AdminHomepage = new frmHomePage("admin", admin);
            this.identifier = identifier;
        }



        /// <summary>
        /// Constructor for Passing the object name to other forms : Admin
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="admin"></param>
        public frmLoadingWindow(string identifier, A_Admin admin, bool pass)
        {
            InitializeComponent();
            gameStatus = admin.GameStatus;
            AdminHomepage = new frmHomePage("admin", admin, pass);
            this.identifier = identifier;
        }



        /// <summary>
        /// Set bool 'pageLoad' to true only when form is enabled or called
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLoadingWindow_Load(object sender, EventArgs e) => pageLoad = true;




        /// <summary>
        /// Timer hekhok
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TImerForLoading(object sender, EventArgs e)
        {
            // defining local methods
            void ProgressBarLoad() => progressBar_Loading.Value += 10;

            void CleanFormAndStopTimerThenExit()
            {
                Resources.ResourceManager.ReleaseAllResources();
                Dispose(true);
                tmrLoading.Stop();
                this.Hide();
            }

            void GoToAdminUIHomePage()
            {
                try { ProgressBarLoad(); }
                catch (Exception)
                {
                    CleanFormAndStopTimerThenExit();
                    AdminHomepage.Show();
                }
            }

            void GoToGuestUIHomePage()
            {
                try { ProgressBarLoad(); }
                catch (Exception)
                {
                    CleanFormAndStopTimerThenExit();
                    GuestHomePage.Show();
                }
            }

            // MAIN
            if (pageLoad == true)
            {
                switch (identifier)
                {
                    case "guest": GoToGuestUIHomePage(); break;
                    case "admin": GoToAdminUIHomePage(); break;
                }
            }
        }
    }
}
