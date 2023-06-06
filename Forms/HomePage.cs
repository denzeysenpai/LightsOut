using LightsOut.Classes;
using LightsOut.Classes.Game.GamePlay;
using LightsOut.Classes.Homepage;
using LightsOut.Forms;
using System;
using System.Design.Assist;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace LightsOut
{
    internal partial class frmHomePage : Form
    {
        // Home page class members initialization
        private string nameofAdmin, dateJoined, age, username, gender;
        private string identifier;
        private string selectedTheme;
        private Point locationForDifficultyMenu;
        private string GameStatus;


        //color1 theme yellow
        Color yellow1 = Color.FromArgb(255, 186, 59);


        Mark Design = new Mark();
        A_Admin admin = new A_Admin();
        FadePanel fade = new FadePanel();
        Animate Animation = new Animate();
        BaseClassHomePage _homePage = new BaseClassHomePage();
        HardDifficulty hardGame = new HardDifficulty();
        EasyDifficulty easyGame = new EasyDifficulty();
        MediumDifficulty mediumGame = new MediumDifficulty();

        bool addHistory;
        string GameDifficulty;

        // Button behavior
        Color hover1 = Color.HotPink;
        Color hover2 = Color.Orange;
        Color leave = Color.FromArgb(255, 248, 220);




        /// <summary>
        /// Default Constructor
        /// </summary>
        public frmHomePage() { InitializeComponent(); }





        /// <summary>
        /// Custom contrsuctor for passing identifier
        /// </summary>
        /// <param name="identifier"></param>
        public frmHomePage(string identifier)
        {
            InitializeComponent();
            this.identifier = identifier;
        }




        /// <summary>
        /// Constructor for passing admin name
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="admin"></param>
        public frmHomePage(string identifier, A_Admin admin)
        {
            InitializeComponent();
            this.identifier = identifier;
            this.admin = admin;
            nameofAdmin = admin.Name;
            dateJoined = admin.joinedDate;
            age = admin.age;
            username = admin.Username;
            gender = admin.gender;
            selectedTheme = admin.selectedTheme;
            Design.RoundCorner(pnlGamesPlayed, 20);

        }



        /// <summary>
        /// Constructor for passing admin name
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="admin"></param>
        public frmHomePage(string identifier, A_Admin admin, bool pass)
        {
            InitializeComponent();
            this.identifier = identifier;
            this.admin = admin;
            nameofAdmin = admin.Name;
            dateJoined = admin.joinedDate;
            age = admin.age;
            username = admin.Username;
            gender = admin.gender;
            selectedTheme = admin.selectedTheme;
            
            Design.RoundCorner(pnlGamesPlayed, 20);
            GameStatus = admin.GameStatus;


            addHistory = pass;
        }



        /// <summary>
        /// Timer for animation during first load up of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void animationOnStart(object sender, EventArgs e)
        {
            Animation.RightToLeftAnimationFour(vm1, vm2, vm3, vm4, FindForm());
            Animation.LeftToRightAnimationFour(mv1, mv2, mv3, mv4);
            Animation.DropDownAnimation(pnlAnimate, FindForm());
            Animation.HeaderAnimation(pnlHeader, FindForm());
            Animation.UpDownLoopAnimation(lblguestMode);
        }


        /// <summary>
        /// Home page load up, sets values of variables and sets the panels
        /// to their respective positions in the form during load up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmHomePage_Load(object sender, EventArgs e)
        { 
            if (!addHistory) { /**/ }
            else
                scoreHistory.Text += $"Score: {admin.score} || Date and Time: {admin.datePlayed} || {GameStatus}\n";

            // Set values on load up
            pnlOptionsPage.Visible = false;
            pnlProfilePage.Visible = false;
            pnlAboutPage.Visible = false;
            pnlHowToPlay.Visible = false;

            // Panel locations preparation on load
            pnlGuestLogIn.Location = new Point(526, 379);
            pnlAdminLogin.Location = new Point(540, 322);
            lblguestMode.Location = new Point(625, 323);
            pnlAnimate.Location = new Point(532, 280);
            pnlHeader.Location = new Point(538, -300);
            pnlOptionsPage.Location = new Point(0, 0);
            pnlProfilePage.Location = new Point(0, 0);
            pnlAboutPage.Location = new Point(0, 0);



            // Left side panels
            mv1.Location = new Point(0 - mv1.Width, 0);
            mv2.Location = new Point(0 - mv2.Width, 0);
            mv3.Location = new Point(0 - mv3.Width, 0);
            mv4.Location = new Point(0 - mv4.Width, 0);




            // Right side panels
            vm1.Location = new Point(this.Width, 0);
            vm2.Location = new Point(this.Width, 0);
            vm3.Location = new Point(this.Width, 0);
            vm4.Location = new Point(this.Width, 0);




            // Arrange menus 
            foreach (Control c in this.Controls)
                if ((string)c.AccessibleDescription == "menus")
                    c.SendToBack();




            // Arrange buttons to SendToBack so that the buttons will be behind the panels
            foreach (Control button in this.Controls)
                if (button.AccessibleDescription == "buttonshehe")
                    button.SendToBack();




            // form size: 1519, 818


            // location for difficulty menu
            int xForm = (int)Math.Floor(Width / 2.0);
            int yForm = (int)Math.Floor(Height / 2.0);

            int xMenu = (int)Math.Floor(pnlDifficultyChoice.Width / 2.0);
            int yMenu = (int)Math.Floor(pnlDifficultyChoice.Height / 2.0);

            locationForDifficultyMenu = new Point(xForm - xMenu, yForm - yMenu);
            pnlDifficultyChoice.Location = locationForDifficultyMenu;
            pnlDifficultyChoice.BringToFront();
            pnlDifficultyChoice.Hide();

            pnlColor6.BackColor = Color.FromArgb(255, 160, 36);

            if (identifier == "guest")
            {
                // Guest UI display
                btnOptionsExit.BackColor = Color.FromArgb(84, 14, 55);
                lblTitle.ForeColor = Color.FromArgb(250, 155, 236);
                this.BackColor = Color.FromArgb(5, 20, 18);

                pnlop1.BackColor = Color.FromArgb(237, 31, 210);
                pnlop2.BackColor = Color.FromArgb(176, 37, 158);
                pnlop3.BackColor = Color.FromArgb(143, 36, 129);
                pnlop4.BackColor = Color.FromArgb(115, 30, 104);

                mv1.BackColor = Color.FromArgb(237, 31, 210);
                mv2.BackColor = Color.FromArgb(176, 37, 158);
                mv3.BackColor = Color.FromArgb(143, 36, 129);
                mv4.BackColor = Color.FromArgb(115, 30, 104);

                vm1.BackColor = Color.FromArgb(237, 31, 210);
                vm2.BackColor = Color.FromArgb(176, 37, 158);
                vm3.BackColor = Color.FromArgb(143, 36, 129);
                vm4.BackColor = Color.FromArgb(115, 30, 104);

                pnlAdminLogin.Visible = false;
                pnlAdminLogin.Enabled = false;
                pnlGuestLogIn.Visible = true;
                pnlGuestLogIn.Enabled = true;
                lblguestMode.Visible = true;

                lc1.Enabled = false;
                lc2.Enabled = false;
                lc3.Enabled = false;
                lc4.Enabled = false;
                lc5.Enabled = false;
                lc6.Enabled = false;
                lc7.Enabled = false;
                lc8.Enabled = false;

                pnlColor1.Enabled = false;
                pnlColor2.Enabled = false;
                pnlColor3.Enabled = false;
                pnlColor4.Enabled = false;
                pnlColor5.Enabled = false;
                pnlColor6.Enabled = false;
                pnlColor7.Enabled = false;
                pnlColor8.Enabled = false;
            }
            else if (identifier == "admin")
            {
                // Admin UI display
                pnlGuestLogIn.Enabled = false;
                pnlGuestLogIn.Visible = false;
                pnlAdminLogin.Visible = true;
                pnlAdminLogin.Enabled = true;
                lblguestMode.Visible = false;

                lblPleaseLoginn.Visible = false;

                lc1.Visible = true;
                lc2.Visible = false;
                lc3.Visible = false;
                lc4.Visible = false;
                lc5.Visible = false;
                lc6.Visible = false;
                lc7.Visible = false;
                lc8.Visible = false;

                pnlColor1.Visible = true;
                pnlColor2.Visible = true;
                pnlColor3.Visible = true;
                pnlColor4.Visible = true;
                pnlColor5.Visible = true;
                pnlColor6.Visible = true;
                pnlColor7.Visible = true;
                pnlColor8.Visible = true;

                lblColormodee.Visible = true;

                SetTheme();
            }


            // About page text on load
            lblAbouttxt.Text = _homePage.AboutPageTextDisplay();
        }



        private void ShowDifficultyOptions()
        {
            pnlDifficultyChoice.Show();
        }
        // Defining methods for some buttons




        /// <summary>
        /// Start Game method, takes 1 argument to identify if the player about to play is an admin or guest
        /// </summary>
        /// <param name="identifier"></param>
        private void StartGame(string identifier)
        {
            if (identifier == "guest")
            {
                GameForm game = new GameForm("guest");
                try
                {
                    this.Hide();
                    game.Show();
                }
                catch (System.ComponentModel.Win32Exception) { game.Dispose(); }
            }
            else if (identifier == "admin")
            {
                GameForm game1 = new GameForm("admin", admin, GameDifficulty);
                try
                {
                    this.Hide();
                    game1.Show();
                }
                catch (System.ComponentModel.Win32Exception) { game1.Dispose(); }
            }
        }




        private void btnStartHardOptionClickEvent(object sender, EventArgs e)
        {
            GameDifficulty = hardGame.ReturnGameType();
            StartGame("admin");
        }


        private void StartEasyGame(object sender, EventArgs e)
        {
            GameDifficulty = easyGame.ReturnGameType();
            StartGame("admin");
        }


        /// <summary>
        /// Method for getting the About the page
        /// </summary>
        private void GoToAboutPage()
        {
            pnlAboutPage.BringToFront();
            pnlAboutPage.Show();
        }





        /// <summary>
        /// Exit to Log in page, can be used in both guest account type and admin account type
        /// </summary>
        private void ExitTo()
        {
            frmLogInForm login = new frmLogInForm("admin", admin) { Enabled = true };
            this.Enabled = false;
            login.Show();
            this.Hide();
        }



        // Homepage buttons
        private void btnLogOut_Click(object sender, EventArgs e) => ExitTo();
        private void btnExitGuest_Click(object sender, EventArgs e) => ExitTo();
        private void btnPlayAsGuest_Click(object sender, EventArgs e) => StartGame("guest");
        private void btnOptions_Click(object sender, EventArgs e) => pnlOptionsPage.Show();
        private void btnExit_Click(object sender, EventArgs e) => pnlAboutPage.Hide();
        private void btnOptionsExit_Click(object sender, EventArgs e) => pnlOptionsPage.Hide();

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            pnlDifficultyChoice.Show();

            //StartGame("admin"); 
        }


        private void SetTheme()
        {
            switch (admin.selectedTheme)
            {
                case "yellow":
                    Color yellow1 = Color.FromArgb(255, 186, 59);
                    Color yellow2 = Color.FromArgb(209, 138, 38);
                    Color yellow3 = Color.FromArgb(179, 119, 36);
                    Color yellow4 = Color.FromArgb(156, 94, 33);
                    Color yellow5 = Color.FromArgb(20, 20, 20);
                    Color firebrick = Color.Firebrick;

                    btnOptionsExit.BackColor = Color.Firebrick;
                    btnExitToHomeFromProfile.BackColor = Color.Firebrick;
                    btnExitToHomeFromProfile.BackgroundImage = null;

                    pnlDifficultyChoice.BackColor = yellow1;
                    pfp1.BackColor = yellow1;
                    pnlop1.BackColor = yellow1;
                    vm1.BackColor = yellow1;
                    mv1.BackColor = yellow1;
                    ps0.BackColor = yellow1;
                    scoreHistory.BackColor = yellow1;

                    pnlDifficultyBorder1.BackColor = yellow2;
                    pfp5.BackColor = yellow2;
                    pfp2.BackColor = yellow2;
                    pnlop2.BackColor = yellow2;
                    vm2.BackColor = yellow2;
                    mv2.BackColor = yellow2;
                    ps1.BackColor = yellow2;

                    pnlDifficultyBorder2.BackColor = yellow3;
                    pfp6.BackColor = yellow3;
                    pfp3.BackColor = yellow3;
                    pnlop3.BackColor = yellow3;
                    vm3.BackColor = yellow3;
                    mv3.BackColor = yellow3;
                    ps3.BackColor = yellow3;

                    pnlProfilePage.BackColor = yellow4;
                    pnlop4.BackColor = yellow4;
                    vm4.BackColor = yellow4;
                    mv4.BackColor = yellow4;
                    pnlScoresPanelhehe.BackColor = yellow4;

                    pnlDifficultyBanner.BackColor = yellow5;
                    BackColor = yellow5;
                    pnlOptionsPage.BackColor = yellow5;
                    pnlHeader.BackColor = yellow5;
                    pnlAnimate.BackColor = yellow5;

                    btnEasy.BackColor = firebrick;
                    btnMedium.BackColor = firebrick;
                    btnClose.BackColor = btnHard.BackColor = firebrick;
                    dividerDesign.BackColor = btnCloseMenu.BackColor = firebrick;

                    hover2 = Color.Orange;

                    foreach (Control buttons in pnlAdminLogin.Controls)
                    {
                        if (buttons.AccessibleDescription == "buttonsForAdmin")
                        {
                            buttons.BackgroundImage = null;
                            buttons.BackColor = firebrick;
                        }
                    }
                    break;
                case "brown":

                    Color darkBrown = Color.FromArgb(138, 79, 21);
                    Color lightBrown = Color.FromArgb(139, 69, 19);
                    Color mediumBrown = Color.FromArgb(115, 59, 18);
                    Color deepBrown = Color.FromArgb(89, 46, 14);
                    Color darkestBrown = Color.FromArgb(64, 34, 11);
                    Color darkGray = Color.FromArgb(20, 20, 20);
                    Color darkRed = Color.DarkRed;

                    btnOptionsExit.BackColor = darkBrown;
                    btnExitToHomeFromProfile.BackColor = darkBrown;
                    btnExitToHomeFromProfile.BackgroundImage = null;

                    pnlDifficultyChoice.BackColor = lightBrown;
                    pfp1.BackColor = lightBrown;
                    pnlop1.BackColor = lightBrown;
                    vm1.BackColor = lightBrown;
                    mv1.BackColor = lightBrown;
                    ps0.BackColor = lightBrown;
                    scoreHistory.BackColor = lightBrown;

                    pnlDifficultyBorder1.BackColor = mediumBrown;
                    pfp5.BackColor = mediumBrown;
                    pfp2.BackColor = mediumBrown;
                    pnlop2.BackColor = mediumBrown;
                    vm2.BackColor = mediumBrown;
                    mv2.BackColor = mediumBrown;
                    ps1.BackColor = mediumBrown;

                    pnlDifficultyBorder2.BackColor = deepBrown;
                    pfp6.BackColor = deepBrown;
                    pfp3.BackColor = deepBrown;
                    pnlop3.BackColor = deepBrown;
                    vm3.BackColor = deepBrown;
                    mv3.BackColor = deepBrown;
                    ps2.BackColor = deepBrown;

                    pnlProfilePage.BackColor = darkestBrown;
                    pnlop4.BackColor = darkestBrown;
                    vm4.BackColor = darkestBrown;
                    mv4.BackColor = darkestBrown;
                    ps3.BackColor = darkestBrown;

                    pnlDifficultyBanner.BackColor = darkGray;
                    BackColor = darkGray;
                    pnlOptionsPage.BackColor = darkGray;
                    pnlHeader.BackColor = darkGray;
                    pnlAnimate.BackColor = darkGray;
                    pnlScoresPanelhehe.BackColor = darkGray;

                    btnEasy.BackColor = darkBrown;
                    btnMedium.BackColor = darkBrown;
                    btnClose.BackColor = btnHard.BackColor = darkBrown;
                    dividerDesign.BackColor = btnCloseMenu.BackColor = darkBrown;

                    hover2 = darkRed;

                    foreach (Control buttons in pnlAdminLogin.Controls)
                    {
                        if (buttons.AccessibleDescription == "buttonsForAdmin")
                        {
                            buttons.BackgroundImage = null;
                            buttons.BackColor = darkBrown;
                        }
                    }
                    break;
                case "aquamarine":

                    Color mainBlue = Color.FromArgb(54, 148, 153);
                    Color lightGreen = Color.FromArgb(127, 255, 212);
                    Color darkGreen = Color.FromArgb(97, 201, 166);
                    Color deepGreen = Color.FromArgb(79, 158, 131);
                    Color darkTeal = Color.FromArgb(57, 112, 93);
                    Color darkSlate = Color.FromArgb(0, 20, 20);
                    Color darkBlue = Color.DarkBlue;


                    btnOptionsExit.BackColor = mainBlue;
                    btnExitToHomeFromProfile.BackColor = mainBlue;
                    btnExitToHomeFromProfile.BackgroundImage = null;

                    pnlDifficultyChoice.BackColor = lightGreen;
                    pfp1.BackColor = lightGreen;
                    pnlop1.BackColor = lightGreen;
                    vm1.BackColor = lightGreen;
                    mv1.BackColor = lightGreen;
                    ps0.BackColor = lightGreen;
                    scoreHistory.BackColor = lightGreen;

                    pnlDifficultyBorder1.BackColor = darkGreen;
                    pfp5.BackColor = darkGreen;
                    pfp2.BackColor = darkGreen;
                    pnlop2.BackColor = darkGreen;
                    vm2.BackColor = darkGreen;
                    mv2.BackColor = darkGreen;
                    ps1.BackColor = darkGreen;

                    pnlDifficultyBorder2.BackColor = deepGreen;
                    pfp6.BackColor = deepGreen;
                    pfp3.BackColor = deepGreen;
                    pnlop3.BackColor = deepGreen;
                    vm3.BackColor = deepGreen;
                    mv3.BackColor = deepGreen;
                    ps2.BackColor = deepGreen;

                    pnlProfilePage.BackColor = darkTeal;
                    pnlop4.BackColor = darkTeal;
                    vm4.BackColor = darkTeal;
                    mv4.BackColor = darkTeal;
                    ps3.BackColor = darkTeal;

                    pnlDifficultyBanner.BackColor = darkSlate;
                    BackColor = darkSlate;
                    pnlOptionsPage.BackColor = darkSlate;
                    pnlHeader.BackColor = darkSlate;
                    pnlAnimate.BackColor = darkSlate;
                    pnlScoresPanelhehe.BackColor = darkSlate;

                    btnEasy.BackColor = mainBlue;
                    btnMedium.BackColor = mainBlue;
                    btnClose.BackColor = btnHard.BackColor = mainBlue;
                    dividerDesign.BackColor = btnCloseMenu.BackColor = mainBlue;

                    hover2 = darkBlue;

                    foreach (Control buttons in pnlAdminLogin.Controls)
                    {
                        if (buttons.AccessibleDescription == "buttonsForAdmin")
                        {
                            buttons.BackgroundImage = null;
                            buttons.BackColor = mainBlue;
                        }
                    }
                    break;
                case "darkred":
                    // Define color variables
                    Color darkBrown1 = Color.FromArgb(66, 14, 0);
                    Color darkRed1 = Color.FromArgb(189, 26, 26);
                    Color deepRed = Color.FromArgb(143, 21, 21);
                    Color darkestRed = Color.FromArgb(115, 18, 18);
                    Color maroon = Color.FromArgb(87, 16, 16);
                    Color darkSlate1 = Color.FromArgb(26, 8, 8);
                    Color darkGray1 = Color.FromArgb(20, 20, 20);

                    // Set control colors
                    btnOptionsExit.BackColor = darkBrown1;
                    btnExitToHomeFromProfile.BackColor = darkBrown1;
                    btnExitToHomeFromProfile.BackgroundImage = null;

                    pnlDifficultyChoice.BackColor = darkRed1;
                    pfp1.BackColor = darkRed1;
                    pnlop1.BackColor = darkRed1;
                    vm1.BackColor = darkRed1;
                    mv1.BackColor = darkRed1;
                    ps0.BackColor = darkRed1;
                    scoreHistory.BackColor = darkRed1;

                    pnlDifficultyBorder1.BackColor = deepRed;
                    pfp5.BackColor = deepRed;
                    pfp2.BackColor = deepRed;
                    pnlop2.BackColor = deepRed;
                    vm2.BackColor = deepRed;
                    mv2.BackColor = deepRed;
                    ps1.BackColor = deepRed;

                    pnlDifficultyBorder2.BackColor = darkestRed;
                    pfp6.BackColor = darkestRed;
                    pfp3.BackColor = darkestRed;
                    pnlop3.BackColor = darkestRed;
                    vm3.BackColor = darkestRed;
                    mv3.BackColor = darkestRed;
                    ps2.BackColor = darkestRed;

                    pnlProfilePage.BackColor = maroon;
                    pnlop4.BackColor = maroon;
                    vm4.BackColor = maroon;
                    mv4.BackColor = maroon;
                    ps3.BackColor = maroon;


                    pnlDifficultyBanner.BackColor = darkSlate1;
                    pnlOptionsPage.BackColor = darkSlate1;
                    BackColor = darkSlate1;
                    pnlHeader.BackColor = darkSlate1;
                    pnlAnimate.BackColor = darkSlate1;
                    pnlScoresPanelhehe.BackColor = darkSlate1;

                    btnEasy.BackColor = darkBrown1;
                    btnMedium.BackColor = darkBrown1;
                    btnClose.BackColor = btnHard.BackColor = darkBrown1;
                    dividerDesign.BackColor = btnCloseMenu.BackColor = darkBrown1;

                    hover2 = darkGray1;
                    foreach (Control buttons in pnlAdminLogin.Controls)
                    {
                        if (buttons.AccessibleDescription == "buttonsForAdmin")
                        {
                            buttons.BackgroundImage = null;
                            buttons.BackColor = darkBrown1;
                        }
                    }
                    break;
                case "darkgreen":
                    // Define color variables
                    Color darkGreen1 = Color.FromArgb(61, 125, 51);
                    Color darkGreen2 = Color.FromArgb(57, 138, 33);
                    Color darkGreen3 = Color.FromArgb(32, 107, 24);
                    Color darkGreen4 = Color.FromArgb(22, 79, 16);
                    Color darkGreen5 = Color.FromArgb(15, 61, 10);
                    Color darkGreen6 = Color.FromArgb(19, 26, 3);
                    Color hoverColor = Color.Black;

                    // Set control colors
                    btnOptionsExit.BackColor = darkGreen1;
                    btnExitToHomeFromProfile.BackColor = darkGreen1;
                    btnExitToHomeFromProfile.BackgroundImage = null;

                    pnlDifficultyChoice.BackColor = darkGreen2;
                    pfp1.BackColor = darkGreen2;
                    pnlop1.BackColor = darkGreen2;
                    vm1.BackColor = darkGreen2;
                    mv1.BackColor = darkGreen2;
                    ps0.BackColor = darkGreen2;
                    scoreHistory.BackColor = darkGreen2;

                    pnlDifficultyBorder1.BackColor = darkGreen3;
                    pfp5.BackColor = darkGreen3;
                    pfp2.BackColor = darkGreen3;
                    pnlop2.BackColor = darkGreen3;
                    vm2.BackColor = darkGreen3;
                    mv2.BackColor = darkGreen3;
                    ps1.BackColor = darkGreen3;

                    pnlDifficultyBorder2.BackColor = darkGreen4;
                    pfp6.BackColor = darkGreen4;
                    pfp3.BackColor = darkGreen4;
                    pnlop3.BackColor = darkGreen4;
                    vm3.BackColor = darkGreen4;
                    mv3.BackColor = darkGreen4;
                    ps2.BackColor = darkGreen4;

                    pnlProfilePage.BackColor = darkGreen5;
                    pnlop4.BackColor = darkGreen5;
                    vm4.BackColor = darkGreen5;
                    mv4.BackColor = darkGreen5;
                    ps3.BackColor = darkGreen5;

                    pnlDifficultyBanner.BackColor = darkGreen6;
                    pnlOptionsPage.BackColor = darkGreen6;
                    BackColor = darkGreen6;
                    pnlHeader.BackColor = darkGreen6;
                    pnlAnimate.BackColor = darkGreen6;
                    pnlScoresPanelhehe.BackColor = darkGreen6;

                    btnEasy.BackColor = darkGreen1;
                    btnMedium.BackColor = darkGreen1;
                    btnClose.BackColor = btnHard.BackColor = darkGreen1;
                    dividerDesign.BackColor = btnCloseMenu.BackColor = darkGreen1;

                    hover2 = hoverColor;

                    foreach (Control buttons in pnlAdminLogin.Controls)
                    {
                        if (buttons.AccessibleDescription == "buttonsForAdmin")
                        {
                            buttons.BackgroundImage = null;
                            buttons.BackColor = darkGreen1;
                        }
                    }
                    break;
                case "orange":
                    // Define color variables
                    Color darkOrange1 = Color.FromArgb(191, 124, 0);
                    Color darkOrange2 = Color.FromArgb(255, 160, 36);
                    Color darkOrange3 = Color.FromArgb(199, 113, 22);
                    Color darkOrange4 = Color.FromArgb(168, 95, 17);
                    Color darkOrange5 = Color.FromArgb(138, 74, 11);
                    Color darkOrange6 = Color.FromArgb(46, 21, 0);
                    Color hoverColor1 = Color.OrangeRed;

                    // Set control colors
                    btnOptionsExit.BackColor = darkOrange1;
                    btnExitToHomeFromProfile.BackColor = darkOrange1;
                    btnExitToHomeFromProfile.BackgroundImage = null;

                    pnlDifficultyChoice.BackColor = darkOrange2;
                    pfp1.BackColor = darkOrange2;
                    pnlop1.BackColor = darkOrange2;
                    vm1.BackColor = darkOrange2;
                    mv1.BackColor = darkOrange2;
                    ps0.BackColor = darkOrange2;
                    scoreHistory.BackColor = darkOrange2;

                    pnlDifficultyBorder1.BackColor = darkOrange3;
                    pfp5.BackColor = darkOrange3;
                    pfp2.BackColor = darkOrange3;
                    pnlop2.BackColor = darkOrange3;
                    vm2.BackColor = darkOrange3;
                    mv2.BackColor = darkOrange3;
                    ps1.BackColor = darkOrange3;

                    pnlDifficultyBorder2.BackColor = darkOrange4;
                    pfp6.BackColor = darkOrange4;
                    pfp3.BackColor = darkOrange4;
                    pnlop3.BackColor = darkOrange4;
                    vm3.BackColor = darkOrange4;
                    mv3.BackColor = darkOrange4;
                    ps2.BackColor = darkOrange4;

                    pnlProfilePage.BackColor = darkOrange5;
                    pnlop4.BackColor = darkOrange5;
                    vm4.BackColor = darkOrange5;
                    mv4.BackColor = darkOrange5;
                    ps3.BackColor = darkOrange5;

                    pnlDifficultyBanner.BackColor = darkOrange6;
                    pnlOptionsPage.BackColor = darkOrange6;
                    BackColor = darkOrange6;
                    pnlHeader.BackColor = darkOrange6;
                    pnlAnimate.BackColor = darkOrange6;
                    pnlScoresPanelhehe.BackColor = darkOrange6;

                    btnEasy.BackColor = darkOrange1;
                    btnMedium.BackColor = darkOrange1;
                    btnClose.BackColor = btnHard.BackColor = darkOrange1;
                    dividerDesign.BackColor = btnCloseMenu.BackColor = darkOrange1;

                    hover2 = hoverColor1;

                    foreach (Control buttons in pnlAdminLogin.Controls)
                    {
                        if (buttons.AccessibleDescription == "buttonsForAdmin")
                        {
                            buttons.BackgroundImage = null;
                            buttons.BackColor = darkOrange1;
                        }
                    }
                    break;
                case "cornflowerblue":
                    // Define color variables
                    Color cornflowerblue1 = Color.FromArgb(31, 145, 143);
                    Color cornflowerblue2 = Color.FromArgb(100, 149, 237);
                    Color cornflowerblue3 = Color.FromArgb(75, 119, 189);
                    Color cornflowerblue4 = Color.FromArgb(56, 92, 150);
                    Color cornflowerblue5 = Color.FromArgb(38, 67, 115);
                    Color cornflowerblue6 = Color.FromArgb(18, 53, 61);
                    Color hoverColor2 = Color.FromArgb(19, 54, 53);

                    // Set control colors
                    btnOptionsExit.BackColor = cornflowerblue1;
                    btnExitToHomeFromProfile.BackColor = cornflowerblue1;
                    btnExitToHomeFromProfile.BackgroundImage = null;

                    pnlDifficultyChoice.BackColor = cornflowerblue2;
                    pfp1.BackColor = cornflowerblue2;
                    pnlop1.BackColor = cornflowerblue2;
                    vm1.BackColor = cornflowerblue2;
                    mv1.BackColor = cornflowerblue2;
                    ps0.BackColor = cornflowerblue2;
                    scoreHistory.BackColor = cornflowerblue2;

                    pnlDifficultyBorder1.BackColor = cornflowerblue3;
                    pfp5.BackColor = cornflowerblue3;
                    pfp2.BackColor = cornflowerblue3;
                    pnlop2.BackColor = cornflowerblue3;
                    vm2.BackColor = cornflowerblue3;
                    mv2.BackColor = cornflowerblue3;
                    ps1.BackColor = cornflowerblue3;

                    pnlDifficultyBorder2.BackColor = cornflowerblue4;
                    pfp6.BackColor = cornflowerblue4;
                    pfp3.BackColor = cornflowerblue4;
                    pnlop3.BackColor = cornflowerblue4;
                    vm3.BackColor = cornflowerblue4;
                    mv3.BackColor = cornflowerblue4;
                    ps2.BackColor = cornflowerblue4;

                    pnlProfilePage.BackColor = cornflowerblue5;
                    pnlop4.BackColor = cornflowerblue5;
                    vm4.BackColor = cornflowerblue5;
                    mv4.BackColor = cornflowerblue5;
                    ps3.BackColor = cornflowerblue5;

                    pnlDifficultyBanner.BackColor = cornflowerblue6;
                    pnlOptionsPage.BackColor = cornflowerblue6;
                    BackColor = cornflowerblue6;
                    pnlHeader.BackColor = cornflowerblue6;
                    pnlAnimate.BackColor = cornflowerblue6;
                    pnlScoresPanelhehe.BackColor = cornflowerblue6;

                    btnEasy.BackColor = cornflowerblue1;
                    btnMedium.BackColor = cornflowerblue1;
                    btnClose.BackColor = btnHard.BackColor = cornflowerblue1;
                    dividerDesign.BackColor = btnCloseMenu.BackColor = cornflowerblue1;

                    hover2 = hoverColor2;
                    foreach (Control buttons in pnlAdminLogin.Controls)
                    {
                        if (buttons.AccessibleDescription == "buttonsForAdmin")
                        {
                            buttons.BackgroundImage = null;
                            buttons.BackColor = cornflowerblue1;
                        }
                    }
                    break;
                case "purple":
                    // Define color variables
                    Color purple1 = Color.FromArgb(147, 77, 161);
                    Color purple2 = Color.FromArgb(157, 34, 179);
                    Color purple3 = Color.FromArgb(132, 27, 150);
                    Color purple4 = Color.FromArgb(112, 19, 128);
                    Color purple5 = Color.FromArgb(93, 14, 107);
                    Color purple6 = Color.FromArgb(27, 7, 31);
                    Color hoverColor3 = Color.FromArgb(27, 7, 31);

                    // Set control colors
                    btnOptionsExit.BackColor = purple1;
                    btnExitToHomeFromProfile.BackColor = purple1;
                    btnExitToHomeFromProfile.BackgroundImage = null;

                    pnlDifficultyChoice.BackColor = purple2;
                    pfp1.BackColor = purple2;
                    pnlop1.BackColor = purple2;
                    vm1.BackColor = purple2;
                    mv1.BackColor = purple2;
                    ps0.BackColor = purple2;
                    scoreHistory.BackColor = purple2;

                    pnlDifficultyBorder1.BackColor = purple3;
                    pfp5.BackColor = purple3;
                    pfp2.BackColor = purple3;
                    pnlop2.BackColor = purple3;
                    vm2.BackColor = purple3;
                    mv2.BackColor = purple3;
                    ps1.BackColor = purple3;

                    pnlDifficultyBorder2.BackColor = purple4;
                    pfp6.BackColor = purple4;
                    pfp3.BackColor = purple4;
                    pnlop3.BackColor = purple4;
                    vm3.BackColor = purple4;
                    mv3.BackColor = purple4;
                    ps2.BackColor = purple4;

                    pnlProfilePage.BackColor = purple5;
                    pnlop4.BackColor = purple5;
                    vm4.BackColor = purple5;
                    mv4.BackColor = purple5;
                    ps3.BackColor = purple5;

                    pnlProfilePage.BackColor = purple6;
                    pnlOptionsPage.BackColor = purple6;
                    BackColor = purple6;
                    pnlHeader.BackColor = purple6;
                    pnlAnimate.BackColor = purple6;
                    pnlScoresPanelhehe.BackColor = purple6;

                    btnEasy.BackColor = purple1;
                    btnMedium.BackColor = purple1; 
                    btnHard.BackColor = purple1;
                    dividerDesign.BackColor = btnCloseMenu.BackColor = purple1;
                    btnClose.BackColor = purple1;

                    hover2 = hoverColor3;
                    foreach (Control buttons in pnlAdminLogin.Controls)
                    {
                        if (buttons.AccessibleDescription == "buttonsForAdmin")
                        {
                            buttons.BackgroundImage = null;
                            buttons.BackColor = purple1;
                        }
                    }
                    break;
                default:
                    // hehe programming much wow hehe
                    break;
            }
            
        }

        /// <summary>
        /// Button to show options page Guest
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOptionsGuest_Click(object sender, EventArgs e) => pnlOptionsPage.Show();




        /// <summary>
        /// Exit profile page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExitToHomeFromProfile_Click(object sender, EventArgs e) => pnlProfilePage.Hide();




        /// <summary>
        /// button for guest account in showing about page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAboutProjectGuest_Click(object sender, EventArgs e) => GoToAboutPage();




        /// <summary>
        /// Admin button for about page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbout_Click(object sender, EventArgs e) => GoToAboutPage();

        // Guest UI buttons
        private void Hover1(object sender, EventArgs e) => btnPlayAsGuest.ForeColor = hover1;
        private void Leave1(object sender, EventArgs e) => btnPlayAsGuest.ForeColor = leave;
        private void Hover2(object sender, EventArgs e) => btnAboutProjectGuest.ForeColor = hover1;
        private void Leave2(object sender, EventArgs e) => btnAboutProjectGuest.ForeColor = leave;
        private void Hover3(object sender, EventArgs e) => btnHowToPlayeGuest.ForeColor = hover1;
        private void Leave3(object sender, EventArgs e) => btnHowToPlayeGuest.ForeColor = leave;
        private void Hover4(object sender, EventArgs e) => btnOptionsGuest.ForeColor = hover1;
        private void Leave4(object sender, EventArgs e) => btnOptionsGuest.ForeColor = leave;
        private void Hover5(object sender, EventArgs e) => btnExitGuest.ForeColor = hover1;
        private void Leave5(object sender, EventArgs e) => btnExitGuest.ForeColor = leave;
        private void Hover11(object sender, EventArgs e) => btnStartGame.ForeColor = hover2;
        private void Leave11(object sender, EventArgs e) => btnStartGame.ForeColor = leave;
        private void Hover12(object sender, EventArgs e) => btnAbout.ForeColor = hover2;
        private void Leave12(object sender, EventArgs e) => btnAbout.ForeColor = leave;
        private void Hover13(object sender, EventArgs e) => btnHowToPlay.ForeColor = hover2;
        private void Leave13(object sender, EventArgs e) => btnHowToPlay.ForeColor = leave;
        private void Hover14(object sender, EventArgs e) => btnProfile.ForeColor = hover2;
        private void Leave14(object sender, EventArgs e) => btnProfile.ForeColor = leave;
        private void Hover15(object sender, EventArgs e) => btnOptions.ForeColor = hover2;
        private void Leave15(object sender, EventArgs e) => btnOptions.ForeColor = leave;
        private void Hover16(object sender, EventArgs e) => btnScores.ForeColor = hover2;
        private void Leave16(object sender, EventArgs e) => btnScores.ForeColor = leave;
        private void Hover17(object sender, EventArgs e) => btnLogOut.ForeColor = hover2;
        private void Leave17(object sender, EventArgs e) => btnLogOut.ForeColor = leave;

        private void color1Click(object sender, EventArgs e)
        {
            lc1.Visible = true;
            lc2.Visible = !true;
            lc3.Visible = !true;
            lc4.Visible = !true;
            lc5.Visible = !true;
            lc6.Visible = !true;
            lc7.Visible = !true;
            lc8.Visible = !true;

            btnOptionsExit.Text = "Save Changes and Exit";
            admin.selectedTheme = "yellow";
            SetTheme();
        }

        private void color2Click(object sender, EventArgs e)
        {
            lc1.Visible = !true;
            lc2.Visible = true;
            lc3.Visible = !true;
            lc4.Visible = !true;
            lc5.Visible = !true;
            lc6.Visible = !true;
            lc7.Visible = !true;
            lc8.Visible = !true;

            btnOptionsExit.Text = "Save Changes and Exit";
            admin.selectedTheme = "brown";
            pnlColor1.BackColor = yellow1;
            SetTheme();
        }

        private void color3Click(object sender, EventArgs e)
        {
            lc1.Visible = !true;
            lc2.Visible = !true;
            lc3.Visible = true;
            lc4.Visible = !true;
            lc5.Visible = !true;
            lc6.Visible = !true;
            lc7.Visible = !true;
            lc8.Visible = !true;

            btnOptionsExit.Text = "Save Changes and Exit";
            admin.selectedTheme = "aquamarine";
            pnlColor1.BackColor = yellow1;

            SetTheme();

        }

        private void color4Click(object sender, EventArgs e)
        {
            lc1.Visible = !true;
            lc2.Visible = !true;
            lc3.Visible = !true;
            lc4.Visible = true;
            lc5.Visible = !true;
            lc6.Visible = !true;
            lc7.Visible = !true;
            lc8.Visible = !true;

            btnOptionsExit.Text = "Save Changes and Exit";
            admin.selectedTheme = "darkred";
            pnlColor1.BackColor = yellow1;

            SetTheme();
        }

        private void color5Click(object sender, EventArgs e)
        {
            lc1.Visible = !true;
            lc2.Visible = !true;
            lc3.Visible = !true;
            lc4.Visible = !true;
            lc5.Visible = true;
            lc6.Visible = !true;
            lc7.Visible = !true;
            lc8.Visible = !true;

            btnOptionsExit.Text = "Save Changes and Exit";
            admin.selectedTheme = "darkgreen";
            pnlColor1.BackColor = yellow1;

            SetTheme();
        }

        private void color6Click(object sender, EventArgs e)
        {
            lc1.Visible = !true;
            lc2.Visible = !true;
            lc3.Visible = !true;
            lc4.Visible = !true;
            lc5.Visible = !true;
            lc6.Visible = true;
            lc7.Visible = !true;
            lc8.Visible = !true;

            btnOptionsExit.Text = "Save Changes and Exit";
            admin.selectedTheme = "orange";
            pnlColor1.BackColor = yellow1;

            SetTheme();
        }

        private void color7Click(object sender, EventArgs e)
        {
            lc1.Visible = !true;
            lc2.Visible = !true;
            lc3.Visible = !true;
            lc4.Visible = !true;
            lc5.Visible = !true;
            lc6.Visible = !true;
            lc7.Visible = true;
            lc8.Visible = !true;

            btnOptionsExit.Text = "Save Changes and Exit";
            admin.selectedTheme = "cornflowerblue";
            pnlColor1.BackColor = yellow1;

            SetTheme();
        }

        private void color8Click(object sender, EventArgs e)
        {
            lc1.Visible = !true;
            lc2.Visible = !true;
            lc3.Visible = !true;
            lc4.Visible = !true;
            lc5.Visible = !true;
            lc6.Visible = !true;
            lc7.Visible = !true;
            lc8.Visible = true;

            btnOptionsExit.Text = "Save Changes and Exit";
            admin.selectedTheme = "purple";
            pnlColor1.BackColor = yellow1;

            SetTheme();
        }

        private void btnCloseMenu_Click(object sender, EventArgs e) => pnlDifficultyChoice.Hide();

        private void StartMedium(object sender, EventArgs e)
        {
            GameDifficulty = mediumGame.ReturnGameType();
            StartGame("admin");
        }

        private void clsoeButtonHekHok(object sender, EventArgs e)
        {
            pnlScoresPanelhehe.Hide();
        }

        private void pnlHowToPlay_Paint(object sender, PaintEventArgs e)
        {
            pnlHowToPlay.Show();
        }

        private void howtoplayHide_Click(object sender, EventArgs e)
        {
            pnlHowToPlay.Hide();
        }



        /// <summary>
        /// button for how to play guest
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHowToPlayeGuest_Click(object sender, EventArgs e)
        {
            pnlHowToPlay.BringToFront();
            pnlHowToPlay.BackColor = BackColor;
            pnlHowToPlay.Location = new Point(0,0);
            pnlHowToPlay.Show();
        }




        /// <summary>
        /// button for how to play for admin account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            pnlHowToPlay.BringToFront();
            pnlHowToPlay.Location = new Point(0,0);
            pnlHowToPlay.BackColor = BackColor;
            pnlHowToPlay.Show();
        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProfile_Click(object sender, EventArgs e)
        {
            lblJoinedDate.Text = $"Joined on: {dateJoined}";
            lblusernameDisplay.Text = "@" + username;
            lblGender.Text = $"Gender: {gender}";
            lblProfileName.Text = nameofAdmin;
            pnlProfilePage.BringToFront();
            lblAge.Text = $"Age: {age}";
            pnlProfilePage.Show();
        }




        /// <summary>
        /// hehe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScores_Click(object sender, EventArgs e)
        {

            if(scoreHistory.Text == "" || scoreHistory.Text == null)
            {
                MessageBox.Show(
                "You don't have any history yet! \n" +
                "Please play at least (1) game/s!",
                "Message",
                MessageBoxButtons.OK,
                MessageBoxIcon.Hand);
            }
            else
            {
                pnlScoresPanelhehe.BringToFront();
                pnlScoresPanelhehe.Show();
                pnlScoresPanelhehe.Location = new Point(0, 0);
            }
        }

    }
}
