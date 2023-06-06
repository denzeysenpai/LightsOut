using LightsOut.Classes;
using LightsOut.Classes.Game;
using LightsOut.Classes.Game.GamePlay;
using LightsOut.Properties;
using System;
using System.Collections.Generic;
using System.Design.Assist;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightsOut.Forms
{
    public partial class GameForm : Form // Main Form where the game takes place
    {

        #region Declaration and Constructors of Form


        // Account type identifier; "guest" or "admin"
        string identifier;
        string GameDifficulty;

        Perspective Render;
        Perspective Ground;
        GameMechanics Mechanics;
        Mark Design = new Mark();
        A_Admin admin = new A_Admin();
        List<Control> keys = new List<Control>();
        frmLoadingWindow aLoadingWindow = new frmLoadingWindow("guest");
        frmLoadingWindow aLoadingWindow2 = new frmLoadingWindow("admin");

        bool gameIsPaused;
        bool startCountDown;

        HardDifficulty StartGameHard = new HardDifficulty();
        EasyDifficulty StartGameEasy = new EasyDifficulty();
        MediumDifficulty StartGameMedium = new MediumDifficulty();

        int TimeToFinish;
        int CollectedKeys;
        int lightsOutCount;
        int countDownBeforeStart;
        int TotalNumOfKeysToCollect;



        /// <summary>
        /// Generic Microsoft Generated Constructor
        /// </summary>
        public GameForm() { InitializeComponent(); }


        /// <summary>
        /// Constructor for Guest Mode
        /// </summary>
        /// <param name="identifier"></param>
        public GameForm(string identifier)
        {
            InitializeComponent();
            this.identifier = identifier;
            Design.RoundCorner(e5, 30);
            Design.RoundCorner(pnlRenderedScreen, 30);

            if (identifier == "guest")
            {
                GameDifficulty = "EASY";
            }
        }



        /// <summary>
        /// Constructor for Admin
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="admin"></param>
        /// <param name="GameDifficulty"></param>
        internal GameForm(string identifier, A_Admin admin, string GameDifficulty)
        {
            InitializeComponent();
            this.identifier = identifier;
            this.admin = admin;
            this.GameDifficulty = GameDifficulty;

            Design.RoundCorner(e5, 30);
            Design.RoundCorner(pnlRenderedScreen, 30);
        }


        #endregion


        /// <summary>
        /// Sets the difficulty of the game, method is called on load to prepare the game before starting
        /// </summary>
        private void SetDifficulty()
        {
            switch (GameDifficulty)
            {
                case "HARD":
                    lightsOutCount = StartGameHard.LightsOutTimer;
                    TimeToFinish = StartGameHard.TimeToFinish;
                    CollectedKeys = StartGameHard.CollectedKeys;
                    TotalNumOfKeysToCollect = StartGameHard.TotalNumOfKeysToCollect;
                    break;
                case "EASY":
                    lightsOutCount = StartGameEasy.LightsOutTimer;
                    TimeToFinish = StartGameEasy.TimeToFinish;
                    CollectedKeys = StartGameEasy.CollectedKeys;
                    TotalNumOfKeysToCollect = StartGameEasy.TotalNumOfKeysToCollect;
                    break;
                case "MEDIUM":
                    lightsOutCount = StartGameMedium.LightsOutTimer;
                    TimeToFinish = StartGameMedium.TimeToFinish;
                    CollectedKeys = StartGameMedium.CollectedKeys;
                    TotalNumOfKeysToCollect = StartGameMedium.TotalNumOfKeysToCollect;
                    break;
            }
        }



        /// <summary>
        /// Checks if it is time for a Lights Out Event
        /// </summary>
        /// <returns></returns>
        private bool LightsOutEventCheck()
        {
            switch (GameDifficulty)
            {
                case "HARD":
                    StartGameHard.LightsOutTimer = lightsOutCount;
                    return StartGameHard.LightsOutEvent();
                case "EASY":
                    StartGameEasy.LightsOutTimer = lightsOutCount;
                    return StartGameEasy.LightsOutEvent();
                case "MEDIUM":
                    StartGameMedium.LightsOutTimer = lightsOutCount;
                    return StartGameMedium.LightsOutEvent();
                default: return false;
            }
        }



        /// <summary>
        /// Resets the Lights Out Event per Difficulty
        /// </summary>
        private void ResetLightsOutEventTimer()
        {
            switch (GameDifficulty)
            {
                case "HARD":
                    StartGameHard.ResetLightsOutEventTimer();
                    lightsOutCount = StartGameHard.LightsOutTimer;
                    break;
                case "EASY":
                    StartGameEasy.ResetLightsOutEventTimer();
                    lightsOutCount = StartGameEasy.LightsOutTimer;
                    break;
                case "MEDIUM":
                    StartGameMedium.ResetLightsOutEventTimer();
                    lightsOutCount = StartGameMedium.LightsOutTimer;
                    break;
            }
        }



        /// <summary>
        /// Returns the number of Keys to collect depending on what difficulty the game is on
        /// </summary>
        /// <returns></returns>
        private int GetNumberOfKeys()
        {
            switch (GameDifficulty)
            {
                case "HARD":
                    return StartGameHard.TotalNumOfKeysToCollect;
                case "EASY":
                    return StartGameEasy.TotalNumOfKeysToCollect;
                case "MEDIUM":
                    return StartGameMedium.TotalNumOfKeysToCollect;
                default: return 0;
            }
        }


        // random integer container
        int ran;

        /// <summary>
        /// Randomize the Keys to different locations
        /// </summary>
        private void RandomizeColliderLocation()
        {
            Random ran = new Random();

            for (int i = 0; i < GetNumberOfKeys(); i++)
            {
                this.ran = ran.Next(0, 14);
                keys[this.ran].Show();
            }
        }



        /// <summary>
        /// Game Load Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameLoad(object sender, EventArgs e)
        {
            //ForDebuggingOnly();
            foreach (Control keys in pnlMiniMapHard.Controls)
            {
                if (keys.AccessibleDescription == "keys")
                {
                    keys.Hide();
                }
            }


            #region Keys Region
            keys.Add(k1);
            keys.Add(k2);
            keys.Add(k3);
            keys.Add(k4);
            keys.Add(k5);
            keys.Add(k6);
            keys.Add(k7);
            keys.Add(k8);
            keys.Add(k9);
            keys.Add(k10);
            keys.Add(k11);
            keys.Add(k12);
            keys.Add(k13);
            keys.Add(k14);
            keys.Add(k15);
            #endregion

            // Initialize Mechanics and Ground
            Mechanics = new GameMechanics(characterEntity, admin, playerDot, pnlMechanicsHard, pnlMiniMapHard);
            Ground = new Perspective(pnlMechanicsHard, characterEntity);

            #region Render Declaration
            Render = new Perspective
                (
                    Mechanics.set1,
                    Mechanics.set2,
                    Mechanics.set3,
                    Mechanics.set4,
                    Mechanics.set5,
                    Mechanics.set7,
                    Mechanics.set8,
                    Mechanics.set9,
                    Mechanics.set10,
                    Mechanics.set11,
                    Mechanics.set12,
                    Mechanics.set13,
                    Mechanics.set14,
                    admin,
                    pnlRenderedScreen,
                    Mechanics
                );
            #endregion


            // Apply Difficulty
            SetDifficulty();

            // Set lights out panel
            lightsOutEvent.BringToFront();
            lightsOutEvent.Hide();
            lightsOutEvent.Location = new Point(Width / 2 - lightsOutEvent.Width / 2, Height / 2 - lightsOutEvent.Height / 2);

            countDownBeforeStart = 10;
            pnlMiniMapHard.Location = new Point(40, 460);
            pnlRenderedScreen.Location = new Point(22, 22);

            Mechanics.finishedLoading = true;
            ColliderMovementTimer.Start();
            Enabled = true;
            Focus();

            // Set In-Game UI Design Point Values
            e5.Location = new Point(Width / 2 - (e5.Width / 2), Height / 2 - (e5.Height / 2));
            pnlStatus.Left = pnlMiniMapHard.Left + pnlMiniMapHard.Width;
            pnlStatus.Top = pnlMiniMapHard.Top + pnlMiniMapHard.Height - pnlStatus.Height;

            // prepare on load
            lblCountDown.Show();
            lblGameStartsIn.Show();
            lblGameStartsIn.Location = new Point(440, 308);

            // Set Countdown Point Values
            lblCountDown.Left = lblGameStartsIn.Left + lblGameStartsIn.Width;
            lblCountDown.Top = lblGameStartsIn.Top;

            // Stop Movement Related Timers
            ColliderMovementTimer.Stop();
            PlayerMovementTimer.Stop();
            ColliderPositionTracker.Stop();


            // pause game
            gameIsPaused = true;


            // set all colliders to arrange before game start
            Mechanics.SetColliders(1, g1, g2, g3, g4, g5); // set 1
            Mechanics.SetColliders(2, b1, b2, b3, b4, b5); // set 2
            Mechanics.SetColliders(3, m1, m2, m3, m4, m5); // set 3
            Mechanics.SetColliders(4, r1, r2, r3, r4, r5); // set 4
            Mechanics.SetColliders(5, y1, y2, y3, y4, y5); // set 5

            Mechanics.SetColliders(7, dp1, dp2, dp3, dp4, dp5); // set 7
            Mechanics.SetColliders(8, s1, s2, s3, s4, s5); // set 8
            Mechanics.SetColliders(9, t1, t2, t3, t4, t5); // set 9
            Mechanics.SetColliders(10, d1, d2, d3, d4, d5); // set 10

            Mechanics.SetColliders(11, br1, br2, br3, br4, br5); // set 11
            Mechanics.SetColliders(12, mb1, mb2, mb3, mb4, mb5); // set 12
            Mechanics.SetColliders(13, o1, o2, o3, o4, o5); // set 13
            Mechanics.SetColliders(14, bl1, bl2, bl3, bl4, bl5); // set 14

            #region Walls
            Render.Walls
                (
                wall1,
                wall2,
                wall3,
                wall4,
                wall5,
                wall6,
                wall7,
                wall8,
                wall9,
                wall10,
                wall11,
                wall12,
                wall13,
                wall14,
                wall15,
                wall16,
                wall17,
                wall18,
                wall19,
                wall20,
                wall21,
                wall22,
                wall23,
                wall24,
                wall25,
                wall26,
                wall27,
                wall28,
                wall29,
                wall30,
                wall31,
                wall32,
                wall33,
                wall34,
                wall35,
                wall36,
                wall37,
                wall37,
                wall39,
                wall40,
                wall41
                );
            #endregion


            // applies the selected color mode
            Perspective getColor = new Perspective();
            foreach (Control ctr in pnlRenderedScreen.Controls)
            {
                Color set = Color.FromArgb(40, 40, 40);
                if (ctr.AccessibleDescription != "depth0")
                    ctr.BackColor = set;


                // changing the color when the player chooses a color
                if (ctr.AccessibleDescription == "WALLS")
                    ctr.BackColor = getColor.ApplySelectedTheme(admin.selectedTheme, 6);



                if (ctr.AccessibleName == "ground")
                    ctr.Visible = false;
            }

            // Hide End-Game Score Result screen
            e5.Hide();
            startCountDown = true;

            // Load game after preparation
            Mechanics.LoadGame(this);
            lblKC.ForeColor = lblResultsHeader.ForeColor = getColor.ApplySelectedTheme(admin.selectedTheme, 5);
            keyss.ForeColor = scoree.ForeColor = lblScr.ForeColor = getColor.ApplySelectedTheme(admin.selectedTheme, 5);


            RandomizeColliderLocation(); // random enemy location (?)
            //ForDebuggingOnly();
        }

        

        /// <summary>
        /// This Method is called during debugging the colliders methods and other functions,
        /// to check errors and to test functionalities during new implementations
        /// </summary>
        private void ForDebuggingOnly() // should have 0 references during actual game load
        {
            foreach (Control panels in Controls)
            {
                if (panels.AccessibleName == "maps")
                {
                    panels.BringToFront();
                    foreach (Control panel in panels.Controls)
                        if (panel.AccessibleName == "ground")
                            panel.Hide();
                }
            }

            pnlMechanicsHard.Location = new Point(0,0);
            lblGameStartsIn.Left = pnlMiniMapHard.Left = pnlMechanicsHard.Left;
            pnlMiniMapHard.Location = new Point(0, pnlMechanicsHard.Height) ;
            lblGameStartsIn.Top = pnlMiniMapHard.Top + lblGameStartsIn.Height;

            pnlMechanicsHard.BringToFront();
            pnlMechanicsHard.Show();
            pnlStatus.Left = Width - pnlStatus.Width;
            pnlStatus.Top = 0;
        }


        private void EndGame()
        {
            //hide some and stop some
            pnlMiniMapHard.Hide();
            pnlStatus.Hide();
            PlayerMovementTimer.Stop();
            ColliderPositionTracker.Stop();
            PlayerMovementTimer.Stop();
            GroundDisplayRenderer.Stop();
            DisplayOnScreenRendererTimer.Stop();

            // store score value
            int scoreFinal = GetScore(); 
            gameIsPaused = true;

            if (admin.GameStatus == "unfinished")
            {
                // store score value
                scoreFinal = 100 * CollectedKeys;
            }
            else
                admin.GameStatus = "completed game";

            // display score
            scoree.Text = scoreFinal.ToString(); 
            admin.score = scoreFinal;
            keyss.Text = $"{CollectedKeys}/{TotalNumOfKeysToCollect}";
        }



        /// <summary>
        /// Releases the Resources in the Form (" StackOverFlowException " : after multiple attempts in the game)
        /// </summary>
        void Release() // fixed the StackOverflowException with this
        {
            foreach (Control c in Controls)
                this.Controls.Remove(c);

            Resources.ResourceManager.ReleaseAllResources();
            Dispose(true);
        }



        // Key Press Method
        private void KeyIsPressed(object sender, KeyPressEventArgs e)
        {
            //R a a e Q D
            //; 10 U ; ; ;
            if (e.KeyChar == 'c') // press c to exit
            {
                Release();
                admin.score = 10;
                admin.GameStatus = "unfinished";
                EndGame();
                QuitGame();
                DisplayLoadingWindow(identifier, admin);
            }
        }


        // Loading Window/Form Method
        private void DisplayLoadingWindow(string identifier, A_Admin admin)
        {
            #region Private Definintion
            void LaunchLoadingForGuestUI()
            {
                Release();
                aLoadingWindow = new frmLoadingWindow("guest");
                Hide();
                aLoadingWindow.Show();
                aLoadingWindow.Enabled = true;
            }

            void LaunchLoadingForAdminUI()
            {
                Release();
                admin.datePlayed = DateTime.Now;
                admin.GameStatus = GetGameStatus();
                aLoadingWindow2 = new frmLoadingWindow("admin", admin, true);
                Hide();
                aLoadingWindow2.Show();
                aLoadingWindow2.Enabled = true;
            }
            #endregion

            switch (identifier)
            {
                case "guest": LaunchLoadingForGuestUI(); break;
                case "admin": LaunchLoadingForAdminUI(); break;
            }

        }


        #region Go To Methods (Timer, Event Checker)
        private void ColliderPosTrack(object sender, EventArgs e) => Mechanics.Tracker();
        private void MiniMapRender(object sender, EventArgs e) => Mechanics.RenderMiniMap();
        private void KeyIsDown(object sender, KeyEventArgs e) => Mechanics.KeyDownMethod(sender, e);
        private void KeyIsReleased(object sender, KeyEventArgs e) => Mechanics.KeyUpMethod(sender, e);
        private void PlayerMovementTime(object sender, EventArgs e) => Mechanics.PlayerMovement(pnlMechanicsHard);
        #endregion




        // Collider Movement Method, responsible for rotating the methods clock wise and counter clock wise
        private void ColliderMovement(object sender, EventArgs e)
        {
            // Difference between the first collider and the character
            int GetTheDifferenceOfX = m1.Location.X - Mechanics.character.Location.X;
            int GetTheDifferenceOfY = Mechanics.character.Location.Y - m1.Location.Y;

            Mechanics.diffX = GetTheDifferenceOfX;
            Mechanics.diffY = GetTheDifferenceOfY;

            for (int i = 0; i < 6; i++)
                Mechanics.MovementForColliders();

        }



        // Render Screen Method for timer
        private void RenderScreen(object sender, EventArgs e)
        {
            #region A series of repetetive code unfit for human eyes

            // Responsible for leading the display of the game
            #region Main screen area for render
            Render.RenderPerspectiveMainScreenArea("1", Render.set7);
            Render.RenderPerspectiveMainScreenArea("2", Render.set7);
            Render.RenderPerspectiveMainScreenArea("3", Render.set7);

            Render.RenderPerspectiveMainScreenArea("4", Render.set8);
            Render.RenderPerspectiveMainScreenArea("5", Render.set8);
            Render.RenderPerspectiveMainScreenArea("6", Render.set8);
            Render.RenderPerspectiveMainScreenArea("7", Render.set8);
            Render.RenderPerspectiveMainScreenArea("8", Render.set8);

            Render.RenderPerspectiveMainScreenArea("9", Render.set9);
            Render.RenderPerspectiveMainScreenArea("10", Render.set9);
            Render.RenderPerspectiveMainScreenArea("11", Render.set9);

            Render.RenderPerspectiveMainScreenArea("12", Render.set10);
            Render.RenderPerspectiveMainScreenArea("13", Render.set10);
            Render.RenderPerspectiveMainScreenArea("14", Render.set10);

            Render.RenderPerspectiveMainScreenArea("15", Render.set1);
            Render.RenderPerspectiveMainScreenArea("16", Render.set1);

            Render.RenderPerspectiveMainScreenArea("17", Render.set2);

            Render.RenderPerspectiveMainScreenArea("18", Render.set2);

            Render.RenderPerspectiveMainScreenArea("19", Render.set3);
            Render.RenderPerspectiveMainScreenArea("20", Render.set3);
            Render.RenderPerspectiveMainScreenArea("21", Render.set3);// center collider
            Render.RenderPerspectiveMainScreenArea("22", Render.set3);
            Render.RenderPerspectiveMainScreenArea("23", Render.set3);

            Render.RenderPerspectiveMainScreenArea("24", Render.set4);

            Render.RenderPerspectiveMainScreenArea("25", Render.set4);

            Render.RenderPerspectiveMainScreenArea("26", Render.set5);
            Render.RenderPerspectiveMainScreenArea("27", Render.set5);

            Render.RenderPerspectiveMainScreenArea("28", Render.set11);
            Render.RenderPerspectiveMainScreenArea("29", Render.set11);
            Render.RenderPerspectiveMainScreenArea("30", Render.set11);

            Render.RenderPerspectiveMainScreenArea("31", Render.set12);
            Render.RenderPerspectiveMainScreenArea("32", Render.set12);
            Render.RenderPerspectiveMainScreenArea("33", Render.set12);

            Render.RenderPerspectiveMainScreenArea("34", Render.set13);
            Render.RenderPerspectiveMainScreenArea("35", Render.set13);
            Render.RenderPerspectiveMainScreenArea("36", Render.set13);
            Render.RenderPerspectiveMainScreenArea("37", Render.set13);
            Render.RenderPerspectiveMainScreenArea("38", Render.set13);

            Render.RenderPerspectiveMainScreenArea("39", Render.set14);
            Render.RenderPerspectiveMainScreenArea("40", Render.set14);
            Render.RenderPerspectiveMainScreenArea("41", Render.set14);

            e1.BackColor = Render.AddThemeColor(0);
            e2.BackColor = Render.AddThemeColor(1);
            e3.BackColor = Render.AddThemeColor(2);
            e4.BackColor = Render.AddThemeColor(3);
            e5.BackColor = Render.AddThemeColor(4);

            btnExitGame.BackColor = Render.AddThemeColor(5);

            #endregion Main screen area for render

            // Responsible for properly displaying the walls
            #region PerspectiveStretch
            foreach (Panel pixel in pnlRenderedScreen.Controls)
            {
                if (pixel.AccessibleDescription == "depth0")
                {
                    Render.RenderPerspectiveForGroundAndCeiling(pixel);
                }
            }
            #endregion PerspectiveStretch

            #endregion A series of repetetive code unfit for human eyes
        }



        // Keeps the player on the Ground Controls
        private void KeepPlayerOnGround(object sender, EventArgs e)
        {
            #region StillOnGround();

            foreach (Control ground in pnlMechanicsHard.Controls)
            {
                if (ground.AccessibleName == "ground")
                    Ground.StillOnGround(ground);
            }

            #endregion StillOnGround();
        }




        // Method for removing the Vision of the player (Blinking Lights Effect)
        private void PlayerNoVision()
        {
            foreach (Control pix in pnlRenderedScreen.Controls)
            {
                pix.BackColor = Color.Black;
            }
        }




        // Returns the score of the game
        private int GetScore()
        {
            switch (GameDifficulty)
            {
                case "HARD": return (StartGameHard.TimeToFinish) - StartGameHard.TimeFinished + (StartGameHard.StartingScore - (StartGameHard.TotalNumOfKeysToCollect));
                case "EASY": return (StartGameEasy.TimeToFinish) - StartGameEasy.TimeFinished + (StartGameEasy.StartingScore - (StartGameEasy.TotalNumOfKeysToCollect));
                case "MEDIUM": return (StartGameMedium.TimeToFinish) - StartGameMedium.TimeFinished + (StartGameMedium.StartingScore - (StartGameMedium.TotalNumOfKeysToCollect));
                default:
                    return 0;
            }
        }




        // Quit and Compute
        private void QuitGame()
        {
            switch (GameDifficulty)
            {
                case "HARD": StartGameHard.CalculateScoreCompleted(); break;
                case "EASY": StartGameEasy.CalculateScoreCompleted(); break;
                case "MEDIUM": StartGameMedium.CalculateScoreCompleted(); break;
                default:
                    break;
            }
        }





        // Add numOfKeys
        private void AddKeysToCollection()
        {
            switch (GameDifficulty)
            {
                case "HARD": StartGameHard.CollectedKeys++; break;
                case "EASY": StartGameEasy.CollectedKeys++; break;
                case "MEDIUM": StartGameMedium.CollectedKeys++; break;
                default:
                    break;
            }
        }





        // Returns the number of keys to be collected
        private int KeysToBeCollected()
        {
            switch (GameDifficulty)
            {
                case "HARD": return StartGameHard.TotalNumOfKeysToCollect;
                case "EASY": return StartGameEasy.TotalNumOfKeysToCollect;
                case "MEDIUM": return StartGameMedium.TotalNumOfKeysToCollect;
                default:
                    return 0;
            }
        }




        // Get current amount of keys collected by the player
        private int GetCurrentCollectedKeys()
        {
            switch (GameDifficulty)
            {
                case "HARD": return StartGameHard.CollectedKeys;
                case "EASY": return StartGameEasy.CollectedKeys;
                case "MEDIUM": return StartGameMedium.CollectedKeys;
                default:
                    return 0;
            }
        }





        // Returns the Game Status: "unfinished"
        private string GetGameStatus()
        {
            switch (GameDifficulty)
            {
                case "HARD": StartGameHard.ChooseToExitGameUnfinished(); return StartGameHard.GameStatus;
                case "EASY": StartGameEasy.ChooseToExitGameUnfinished(); return StartGameEasy.GameStatus;
                case "MEDIUM": StartGameMedium.ChooseToExitGameUnfinished(); return StartGameMedium.GameStatus;
                default:
                    return "";
            }
        }




        // Main
        private async void MainTimerForGameplay(object sender, EventArgs e)
        {
            // Check for Collision with keys
            foreach (Control keys in keys)
            {
                if (playerDot.Bounds.IntersectsWith(keys.Bounds) && keys.Visible == true)
                {
                    keys.Visible = false;
                    AddKeysToCollection();
                }
            }


            // Check if the player has exited the maze (since the maze exit is at x = 0)
            if (characterEntity.Top < 0) 
            {
                admin.GameStatus = "completed";
                EndGame();
                foreach (Control c in pnlRenderedScreen.Controls)
                {
                    c.BackColor = Color.Black;
                }
                e5.Enabled = true;

                e5.Show();
            }

            // lights out event
            if (LightsOutEventCheck()) 
            {
                gameIsPaused = true;
                pnlMiniMapHard.Hide();
                pnlStatus.Hide();
                lightsOutEvent.BringToFront();
                lightsOutEvent.Show();
                PlayerNoVision();

                await Task.Delay(5000); // 5 seconds
                lightsOutEvent.Hide();

                ResetLightsOutEventTimer();
                gameIsPaused = false;
            }



            // Continue if game is not paused
            if (!gameIsPaused) 
            {
                pnlMiniMapHard.Show();
                pnlStatus.Show();
                lightsOutEvent.Hide();
                ColliderMovementTimer.Start();
                ColliderPositionTracker.Start();
                PlayerMovementTimer.Start();
                GroundDisplayRenderer.Start();
                DisplayOnScreenRendererTimer.Start();

                lblLightsOutCount.Text = (lightsOutCount--).ToString() + 's';
                lblTimeRemaining.Text = (TimeToFinish--).ToString() + 's';
                CollectedKeys = GetCurrentCollectedKeys();
                TotalNumOfKeysToCollect = KeysToBeCollected();

                lblKeysCollected.Text = $"{CollectedKeys}/{TotalNumOfKeysToCollect}";

                if (TimeToFinish <= 0)
                {
                    await Task.Delay(100);
                    e5.Show();
                }
            }
            else // game is paused
            {
                pnlMiniMapHard.Hide();
                pnlStatus.Hide();
                PlayerMovementTimer.Stop();
                ColliderPositionTracker.Stop();
                PlayerMovementTimer.Stop();
                GroundDisplayRenderer.Stop();
                DisplayOnScreenRendererTimer.Stop();
            }



            // Count down begins on load because of the bool true on load
            if (startCountDown) 
            {
                // color red
                if (countDownBeforeStart < 4)
                    lblCountDown.ForeColor = Color.Red;

                // decrement till 0
                if (countDownBeforeStart > 0)
                    lblCountDown.Text = (countDownBeforeStart--).ToString();
                else // finished count
                {
                    lblCountDown.Hide();
                    lblGameStartsIn.Hide();
                    gameIsPaused = false;
                    startCountDown = false;
                }
            }
        }



        // Exit game 
        private void btnExitGame_Click(object sender, EventArgs e)
        {
            admin.GameStatus = "COMPLETED";
            DisplayLoadingWindow(identifier, admin);
        }
    }
}
