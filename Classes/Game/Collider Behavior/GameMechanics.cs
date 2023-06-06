using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LightsOut.Classes.Game
{
    internal class GameMechanics : Colliders
    {
        #region Declarations
        public int diffX, diffY;
        public bool backward;
        public bool forward;
        bool CclckWs;
        bool clckWs;
        int speed;
        int rotationAngle = 0;
        internal Control character;
        internal Point colliderNewPoint;

        A_Admin admin;
        Player Player;
        Control bigmap;
        Control minimap;
        PictureBox playerIconOnMiniMap;
        public GameMechanics(Control character, A_Admin admin, PictureBox playerIconOnMiniMap, Control bigmap, Control minimap)
        {
            this.character = character;
            this.admin = admin;
            this.playerIconOnMiniMap = playerIconOnMiniMap;
            this.bigmap = bigmap;
            this.minimap = minimap;
        }
        #endregion
        internal void LoadGame(Form form) // done
        {
            
            form.Show();

            CclckWs = false;
            clckWs = false;
            finishedLoading = true;

            doOnce = true;
            FixBreaking("forward"); // Fix breaking method is still experimental

            Color view = Color.Gray;

            foreach (Control ctr in form.Controls)
                if (ctr.AccessibleDescription == "colliders")
                    ctr.BackColor = view;

            Player = new Player(character);
        }
        // dear future self, please note that the code is sensitive to changes because most of the methods work together and rely on eachother.



        /// <summary>
        /// Timer event on main form for tracking the displacement of colliders from one another
        /// </summary>
        /// <param name="character">player entity</param>
        /// <param name="c1">collider</param>
        /// <param name="form1"></param>
        internal void Tracker()
        {
            if (finishedLoading == true)
            {
                const int spacing = 12; // spacing is referring to the space between colliders

                foreach (List<PictureBox> set in colliderSets)
                {
                    SetCollidersToStick(set, spacing);
                }
                diffX = set3[0].Location.X - character.Location.X;
                diffY = character.Location.Y - set3[0].Location.Y;
            }
        }

        /// <summary>
        /// Method for keeping the colliders intact
        /// </summary>
        /// <param name="set">Set of colliders</param>
        /// <param name="spacing">spcing between colliders</param>
        private void SetCollidersToStick(List<PictureBox> set, int spacing)
        {
            for (int i = 1; i < 6; i++)
            {
                StickToControl(set[i - 1], character, i, spacing);
            }
        }


        /// <summary>
        /// Key press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void KeyDownMethod(object sender, KeyEventArgs e)
        {
            if (finishedLoading == true)
            {
                if (e.KeyCode == System.Windows.Forms.Keys.Left)
                {
                    CclckWs = true;
                    clckWs = false;
                    RotateLeft();
                }
                if (e.KeyCode == System.Windows.Forms.Keys.Right)
                {
                    CclckWs = false;
                    clckWs = true;
                    RotateRight();
                }
                // Player Movement
                if (e.KeyCode == System.Windows.Forms.Keys.W)
                {
                    forward = true;
                }
                if (e.KeyCode == System.Windows.Forms.Keys.S)
                {
                    backward = true;
                }
            }
        }



        // minimap miniplayer icon
        private void RotateLeft()
        {
            rotationAngle = -90;
            RotateImage();
        }
        private void RotateRight()
        {
            rotationAngle = 90;
            RotateImage();
        }



        /// <summary>
        /// Key released
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void KeyUpMethod(object sender, KeyEventArgs e)
        {
            if (finishedLoading == true)
            {
                if (e.KeyCode == System.Windows.Forms.Keys.Left)
                {
                    CclckWs = false;
                    clckWs = false;

                }
                if (e.KeyCode == System.Windows.Forms.Keys.Right)
                {
                    CclckWs = false;
                    clckWs = false;

                }

                // Player Movement
                if (e.KeyCode == System.Windows.Forms.Keys.W)
                {
                    forward = false;
                }
                if (e.KeyCode == System.Windows.Forms.Keys.S)
                {
                    backward = false;
                }
            }
        }



        /// <summary>
        /// Moving The player and player entities (player entities are controls or game objects that are not neccessarily 
        /// the player however, moves with the player)
        /// </summary>
        /// <param name="character"> Character or the Control that represent the player. </param>
        /// <param name="c1"> Collider that is the nearest one to the player. </param>
        /// <param name="form1"> Form where the player moves around in. </param>
        /// <param name="finishedLoading"> True if form has finished loading, false if not</param>
        /// <remarks form1></remarks>
        public void PlayerMovement(Control form1)
        {
            finishedLoading = true;

            if (finishedLoading == true)
            {
                Player.Movement(form1, forward, backward, diffX, diffY);
            }
        }
        internal void StickToControl(Control ctr1, Control center, int numOfOrderOfCtr1, int spacing)
        {
            int squareOneXValue; // x value in the cartesian plane
            int squareOneYValue; // y value in the cartesian plane

            squareOneXValue = (ctr1.Left - center.Left);
            squareOneYValue = (ctr1.Bottom - center.Bottom);

            // center of the cartesian plane = character
            int centerXvalue = center.Location.X - center.Location.X; // x value 0
            int centerYvalue = center.Location.Y - center.Location.Y; // y value 0

            int placement = (numOfOrderOfCtr1 * spacing); // spacing of control from the center control
            int readjust = numOfOrderOfCtr1 * 4;

            if (squareOneXValue <= 0 && squareOneXValue < centerXvalue - placement) // if collider is on the left side of the cartesian plane
            {
                ctr1.Left += readjust;
                doOnce = true;
                FixBreaking("left");
            }
            if (squareOneYValue <= 0 && squareOneYValue < centerYvalue - placement)
            {
                ctr1.Top += readjust;
                doOnce = true;
                FixBreaking("forward");
            }
            if (squareOneXValue >= 0 && squareOneXValue > centerXvalue + placement) // if collider is on the right side of the cartesian plane
            {
                ctr1.Left -= readjust;
                doOnce = true;
                FixBreaking("right");
            }
            if (squareOneYValue >= 0 && squareOneYValue > centerYvalue + placement)
            {
                ctr1.Top -= readjust;
                doOnce = true;
                FixBreaking("backward");
            }



            if (squareOneXValue < 0 && squareOneXValue < centerXvalue - placement
                && squareOneYValue > 0 && squareOneYValue > centerYvalue - placement) // if collider is on the lower left side of the cartesian plane
            {
                ctr1.Left += readjust;
                ctr1.Top -= readjust;
            }
            if (squareOneXValue > 0 && squareOneXValue > centerXvalue + placement
                && squareOneYValue > 0 && squareOneYValue > centerYvalue + placement) // if collider is on the upper right side of the cartesian plane
            {
                ctr1.Left -= readjust;
                ctr1.Top += readjust;
            }
            if (squareOneXValue > 0 && squareOneXValue > centerXvalue - placement
                && squareOneYValue < 0 && squareOneYValue < centerYvalue - placement) // if collider is on the lower right side of the cartesian plane
            {
                ctr1.Left -= readjust;
                ctr1.Top -= readjust;
            }
            if (squareOneXValue < 0 && squareOneXValue < centerXvalue - placement
                && squareOneYValue < 0 && squareOneYValue < centerYvalue - placement) // if collider is on the upper left side of the cartesian plane
            {
                ctr1.Left -= readjust;
                ctr1.Top += readjust;
            }
        }
        internal void MovementForColliders()
        {

            if (finishedLoading == true)
            {
                const int speed = 2;

                foreach (List<PictureBox> set in colliderSets)
                {
                    SetColliderView(set, speed);
                }
            }
        }

        private void SetColliderView(List<PictureBox> set, int speed)
        {
            // sadly, for loop doesn't work for this
            ColliderForView(set[0], 1, speed);
            ColliderForView(set[1], 2, speed);
            ColliderForView(set[2], 3, speed);
            ColliderForView(set[3], 4, speed);
            ColliderForView(set[4], 5, speed);
        }

        internal void ColliderForView(Control ctr1, int numofOrderInControl, int speedDefault)
        {
            speed = (speedDefault * numofOrderInControl);

            int diffX = ctr1.Location.X - character.Location.X;
            int diffY = character.Location.Y - ctr1.Location.Y;

            colliderNewPoint = new Point(diffX, diffY);


            if (clckWs) // if player presses left key to turn counter clock wise
            {
                // if player is looking up
                if (colliderNewPoint.X >= 0 && colliderNewPoint.Y >= 0)
                {
                    ctr1.Top += speed;
                    ctr1.Left += speed;
                }
                if (colliderNewPoint.X >= 0 && colliderNewPoint.Y <= 0)
                {
                    ctr1.Left -= speed;
                    ctr1.Top += speed;
                }

                // if player is looking down
                if (colliderNewPoint.X <= 0 && colliderNewPoint.Y <= 0)
                {
                    ctr1.Left -= speed;
                    ctr1.Top -= speed;
                }
                if (colliderNewPoint.X <= 0 && colliderNewPoint.Y >= 0)
                {
                    ctr1.Top -= speed;
                    ctr1.Left += speed;
                }
            }
            if (CclckWs) // if player presses right key to turn clock wise
            {
                // if player is looking up
                if (colliderNewPoint.X >= 0 && colliderNewPoint.Y >= 0)
                {
                    ctr1.Top -= speed;
                    ctr1.Left -= speed;
                }
                if (colliderNewPoint.X >= 0 && colliderNewPoint.Y <= 0)
                {
                    ctr1.Left += speed;
                    ctr1.Top -= speed;
                }

                // if player is looking down
                if (colliderNewPoint.X <= 0 && colliderNewPoint.Y <= 0)
                {
                    ctr1.Left += speed;
                    ctr1.Top += speed;
                }
                if (colliderNewPoint.X <= 0 && colliderNewPoint.Y >= 0)
                {
                    ctr1.Top += speed;
                    ctr1.Left -= speed;
                }
            }
        }


        public void SelectMiniMap(Control bigmap, Control minimap)
        {
            this.bigmap = bigmap;
            this.minimap = minimap;
        }


        public void RenderMiniMap()
        {
            // get the common ratio to divide to the character location in order to get the equal location for the icon
            decimal differenceOfMapX = bigmap.Width / minimap.Width;
            decimal differenceOfMapY = bigmap.Height / minimap.Height;

            // get the location for the mini icon for the player from the player's actual position
            decimal iconX = character.Location.X / (int)Math.Floor(differenceOfMapX);
            decimal iconY = character.Location.Y / (int)Math.Floor(differenceOfMapY);

            // if we don't do this then the upper left point of the picture box of the mini player icon on mini map will
            // be the one set on the new point
            int iconAdjustment = playerIconOnMiniMap.Width / 2;

            // set precise location for mini player icon
            playerIconOnMiniMap.Location = new Point((int)Math.Floor(iconX) - iconAdjustment, (int)Math.Floor(iconY) - iconAdjustment); // apparently 15 is the difference idk
        }


        /// <summary>
        /// Overload of the main RotateImage(), but references the main method.
        /// </summary>
        private void RotateImage() => playerIconOnMiniMap.BackgroundImage = RotateImage(playerIconOnMiniMap.BackgroundImage, rotationAngle);


        /// <summary>
        /// Rotates the image in order to
        /// </summary>
        /// <param name="image"></param>
        /// <param name="angle"></param>
        /// <returns></returns>
        private Image RotateImage(Image image, int angle)
        {
            Bitmap rotatedImage = new Bitmap(image.Width, image.Height);
            rotatedImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            // 'using' disposes the created Graphics by releasing its resources
            // first then disposes the resource used after the use of the code
            using (Graphics graphics = Graphics.FromImage(rotatedImage))
            {
                graphics.TranslateTransform(image.Width / 2, image.Height / 2); // moves the 0,0 location to the center of the image
                graphics.RotateTransform(angle); // rotates the image on new point 0,0
                graphics.TranslateTransform(-image.Width / 2, -image.Height / 2);// returns the 0,0 location to the upper left of the image
                graphics.DrawImage(image, Point.Empty);
            }

            return rotatedImage;
        }
    }
}
