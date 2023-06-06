using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace System.Design.Assist
{
    // secret stuff hehe
    #region Colliders.System
    //using System;
    //using System.Collections.Generic;
    //using System.Windows.Forms;

    //namespace LightsOut.Classes
    //{
    //    internal class Colliders // PARENT CLASS
    //    {
    //        #region Declarations

    //        public bool finishedLoading;

    //        internal List<PictureBox> set7 = new List<PictureBox>();
    //        internal List<PictureBox> set8 = new List<PictureBox>();
    //        internal List<PictureBox> set9 = new List<PictureBox>();
    //        internal List<PictureBox> set10 = new List<PictureBox>();

    //        internal List<PictureBox> set1 = new List<PictureBox>(); // far left
    //        internal List<PictureBox> set2 = new List<PictureBox>(); // middle left
    //        internal List<PictureBox> set3 = new List<PictureBox>(); // center
    //        internal List<PictureBox> set4 = new List<PictureBox>(); // middle right
    //        internal List<PictureBox> set5 = new List<PictureBox>(); // far right

    //        internal List<PictureBox> set11 = new List<PictureBox>();
    //        internal List<PictureBox> set12 = new List<PictureBox>();
    //        internal List<PictureBox> set13 = new List<PictureBox>();
    //        internal List<PictureBox> set14 = new List<PictureBox>();

    //        public List<List<PictureBox>> colliderSets = new List<List<PictureBox>>();

    //        internal bool doOnce;

    //        #endregion Declarations

    //        /// <summary>
    //        /// Add the given colliders to a List<PictureBox> set
    //        /// </summary>
    //        /// <param name="setNumber">Set number you want to asign it to</param>
    //        /// <param name="collider1">[0]</param>
    //        /// <param name="collider2">[1]</param>
    //        /// <param name="collider3">[2]</param>
    //        /// <param name="collider4">[3]</param>
    //        /// <param name="collider5">[4]</param>
    //        internal void SetColliders(
    //            int setNumber,
    //            PictureBox collider1, // index 0
    //            PictureBox collider2, // index 1
    //            PictureBox collider3, // index 2
    //            PictureBox collider4, // index 3
    //            PictureBox collider5  // index 4
    //            )
    //        {
    //            try
    //            {
    //                switch (setNumber)
    //                {
    //                    case 1: // far left
    //                        set1.Add(collider1);
    //                        set1.Add(collider2);
    //                        set1.Add(collider3);
    //                        set1.Add(collider4);
    //                        set1.Add(collider5);
    //                        colliderSets.Add(set1);
    //                        break;
    //                    case 2: // middle left
    //                        set2.Add(collider1);
    //                        set2.Add(collider2);
    //                        set2.Add(collider3);
    //                        set2.Add(collider4);
    //                        set2.Add(collider5);
    //                        colliderSets.Add(set2);
    //                        break;
    //                    case 3: // center
    //                        set3.Add(collider1);
    //                        set3.Add(collider2);
    //                        set3.Add(collider3);
    //                        set3.Add(collider4);
    //                        set3.Add(collider5);
    //                        colliderSets.Add(set3);
    //                        break;
    //                    case 4: // middle right
    //                        set4.Add(collider1);
    //                        set4.Add(collider2);
    //                        set4.Add(collider3);
    //                        set4.Add(collider4);
    //                        set4.Add(collider5);
    //                        colliderSets.Add(set4);
    //                        break;
    //                    case 5: // far right
    //                        set5.Add(collider1);
    //                        set5.Add(collider2);
    //                        set5.Add(collider3);
    //                        set5.Add(collider4);
    //                        set5.Add(collider5);
    //                        colliderSets.Add(set5);
    //                        break;
    //                    case 7:
    //                        set7.Add(collider1);
    //                        set7.Add(collider2);
    //                        set7.Add(collider3);
    //                        set7.Add(collider4);
    //                        set7.Add(collider5);
    //                        colliderSets.Add(set7);
    //                        break;
    //                    case 8:
    //                        set8.Add(collider1);
    //                        set8.Add(collider2);
    //                        set8.Add(collider3);
    //                        set8.Add(collider4);
    //                        set8.Add(collider5);
    //                        colliderSets.Add(set8);
    //                        break;
    //                    case 9:
    //                        set9.Add(collider1);
    //                        set9.Add(collider2);
    //                        set9.Add(collider3);
    //                        set9.Add(collider4);
    //                        set9.Add(collider5);
    //                        colliderSets.Add(set9);
    //                        break;
    //                    case 10:
    //                        set10.Add(collider1);
    //                        set10.Add(collider2);
    //                        set10.Add(collider3);
    //                        set10.Add(collider4);
    //                        set10.Add(collider5);
    //                        colliderSets.Add(set10);
    //                        break;
    //                    case 11:
    //                        set11.Add(collider1);
    //                        set11.Add(collider2);
    //                        set11.Add(collider3);
    //                        set11.Add(collider4);
    //                        set11.Add(collider5);
    //                        colliderSets.Add(set11);
    //                        break;
    //                    case 12:
    //                        set12.Add(collider1);
    //                        set12.Add(collider2);
    //                        set12.Add(collider3);
    //                        set12.Add(collider4);
    //                        set12.Add(collider5);
    //                        colliderSets.Add(set12);
    //                        break;
    //                    case 13:
    //                        set13.Add(collider1);
    //                        set13.Add(collider2);
    //                        set13.Add(collider3);
    //                        set13.Add(collider4);
    //                        set13.Add(collider5);
    //                        colliderSets.Add(set13);
    //                        break;
    //                    case 14:
    //                        set14.Add(collider1);
    //                        set14.Add(collider2);
    //                        set14.Add(collider3);
    //                        set14.Add(collider4);
    //                        set14.Add(collider5);
    //                        colliderSets.Add(set14);
    //                        break;
    //                    default:
    //                        throw new ArgumentOutOfRangeException();
    //                }
    //            }
    //            catch (ArgumentOutOfRangeException)
    //            {
    //                MessageBox.Show("Argument given is out of range!", "Exception recognized!");
    //            }
    //            catch (Exception e)
    //            {
    //                MessageBox.Show($"Exception is not specified!\nError: {e.Message}",
    //                    "Exception recognized!");
    //            }
    //        }



    //        /// <summary>
    //        /// Arranges the colliders per collider
    //        /// </summary>
    //        /// <param name="c">
    //        /// Collider Control</param>
    //        /// <param name="linenumber">
    //        /// Line Order</param>
    //        /// <param name="numOfOrder">
    //        /// Order in Line</param>
    //        /// <param name="LeftOrRightSideCollider">
    //        /// Determines which side of the character when player faces up</param>
    //        /// <param name="DirectionFacing">Determine when to arrange </param>
    //        internal void ArrangeColliders(
    //           Control c, // Collider
    //           int linenumber, // line number representation
    //           int numOfOrder,
    //           string LeftOrRightSideCollider,
    //           string DirectionFacing
    //           )
    //        {
    //            // initialize finished as false 
    //            bool finished = false;
    //            int shift = (numOfOrder * linenumber); // set the shift value according to the given parameters

    //            #region Local Methods Declaration

    //            // shifts the colliders to their proper position
    //            void AddTopAndLeft()
    //            {
    //                c.Top += shift;
    //                c.Left += shift;
    //                finished = true;
    //            }

    //            void AddTopSubLeft()
    //            {
    //                c.Top += shift;
    //                c.Left -= shift;
    //                finished = true;
    //            }

    //            void SubTopAndLeft()
    //            {
    //                c.Top -= shift;
    //                c.Left -= shift;
    //                finished = true;
    //            }

    //            void SubTopAddLeft()
    //            {
    //                c.Top -= shift;
    //                c.Left += shift;
    //                finished = true;
    //            }

    //            #endregion

    //            switch (DirectionFacing)
    //            {
    //                case "top":
    //                    if (LeftOrRightSideCollider == "right")
    //                        AddTopAndLeft();
    //                    else // (LeftOrRightSideCollider == "left")
    //                        AddTopSubLeft();
    //                    break;
    //                case "bottom":
    //                    if (LeftOrRightSideCollider == "right")
    //                        SubTopAndLeft();
    //                    else
    //                        SubTopAddLeft();
    //                    break;
    //                case "left":
    //                    if (LeftOrRightSideCollider == "right")
    //                        SubTopAddLeft();
    //                    else
    //                        AddTopAndLeft();
    //                    break;
    //                case "right":
    //                    if (LeftOrRightSideCollider == "right")
    //                        AddTopSubLeft();
    //                    else
    //                        SubTopAndLeft();
    //                    break;
    //            }


    //            finishedLoading = finished; // changes to true so that the Tracker() method will do its job
    //        }


    //        /// <summary>
    //        /// Individually arranges the colliders per set
    //        /// </summary>
    //        /// <param name="set1"></param>
    //        /// <param name="set2"></param>
    //        /// <param name="face"></param>
    //        /// <param name="pos"></param>
    //        private void ArrangeColliderSet(List<PictureBox> set1, List<PictureBox> set2, string face, int pos)
    //        {
    //            // right
    //            for (int i = 1; i < 5; i++)
    //            {
    //                ArrangeColliders(set1[i - 1], pos, i, "right", face);
    //            }


    //            // left 
    //            for (int i = 1; i < 5; i++)
    //            {
    //                ArrangeColliders(set2[i - 1], pos, i, "left", face);
    //            }
    //        }



    //        /// <summary>
    //        /// Arranges the Colliders as one method
    //        /// </summary>
    //        /// <param name="face"></param>
    //        private void ArrangeColliderMethod(string face)
    //        {
    //            // ugly but works
    //            ArrangeColliderSet(set4, set2, face, 1);
    //            ArrangeColliderSet(set5, set1, face, 3);
    //            ArrangeColliderSet(set11, set10, face, 5);
    //            ArrangeColliderSet(set12, set9, face, 7);
    //            ArrangeColliderSet(set13, set8, face, 9);
    //            ArrangeColliderSet(set14, set7, face, 11);
    //        }



    //        /// <summary>
    //        /// Collider used to have a tendency to break off from its radius or supposed
    //        /// range or space from the player, this method fixes that issue and now prevents the colliders from
    //        /// separating from the player or breaking off.
    //        /// </summary>
    //        /// <param name="directionFacing"></param>
    //        internal void FixBreaking(string directionFacing) // done
    //        {
    //            // Sets all of the colliders location in a single line
    //            // DO NOT CHANGE !!
    //            if (doOnce)
    //            {
    //                for (int i = 0; i < 4; i++)
    //                {

    //                    // hard to read but shorter
    //                    set1[i].Location = set2[i].Location = set4[i].Location =
    //                    set5[i].Location = set7[i].Location = set8[i].Location =
    //                    set9[i].Location = set10[i].Location = set11[i].Location =
    //                    set12[i].Location = set13[i].Location = set14[i].Location = set3[i].Location;
    //                }
    //                doOnce = false;
    //            }



    //            // then gets arranged in the code block below
    //            string GetFace()
    //            {
    //                switch (directionFacing)
    //                {
    //                    case "forward": return "top";
    //                    case "backward": return "bottom";
    //                    case "left": return "left";
    //                    case "right": return "right";
    //                    default: return "";
    //                }
    //            }


    //            // Arrange the colliders depending on the direction given
    //            ArrangeColliderMethod(GetFace());
    //        }



    //    }
    //}

    #endregion
    #region GameMechanics.System
    //using System;
    //using System.Collections.Generic;
    //using System.Drawing;
    //using System.Windows.Forms;

    //namespace LightsOut.Classes.Game
    //{
    //    internal class GameMechanics : Colliders
    //    {
    //        #region Declarations
    //        public int diffX, diffY;
    //        public bool backward;
    //        public bool forward;
    //        bool CclckWs;
    //        bool clckWs;
    //        bool Turn;
    //        int speed;
    //        int rotationAngle = 0;
    //        internal Control character;
    //        internal Point colliderNewPoint;

    //        A_Admin admin;
    //        Player Player;
    //        Control bigmap;
    //        Control minimap;
    //        PictureBox playerIconOnMiniMap;
    //        public GameMechanics(Control character, A_Admin admin, PictureBox playerIconOnMiniMap, Control bigmap, Control minimap)
    //        {
    //            this.character = character;
    //            this.admin = admin;
    //            this.playerIconOnMiniMap = playerIconOnMiniMap;
    //            this.bigmap = bigmap;
    //            this.minimap = minimap;
    //            Turn = false;
    //        }
    //        #endregion
    //        internal void LoadGame(Form form) // done
    //        {

    //            form.Show();

    //            CclckWs = false;
    //            clckWs = false;
    //            finishedLoading = true;

    //            doOnce = true;
    //            FixBreaking("forward"); // Fix breaking method is still experimental

    //            Color view = Color.Gray;

    //            foreach (Control ctr in form.Controls)
    //                if (ctr.AccessibleDescription == "colliders")
    //                    ctr.BackColor = view;

    //            Player = new Player(character);
    //        }




    //        /// <summary>
    //        /// Timer event on main form for tracking the displacement of colliders from one another
    //        /// </summary>
    //        /// <param name="character">player entity</param>
    //        /// <param name="c1">collider</param>
    //        /// <param name="form1"></param>
    //        internal void Tracker()
    //        {
    //            if (finishedLoading == true)
    //            {
    //                const int spacing = 12; // spacing is referring to the space between colliders

    //                foreach (List<PictureBox> set in colliderSets)
    //                {
    //                    SetCollidersToStick(set, spacing);
    //                }
    //                diffX = set3[0].Location.X - character.Location.X;
    //                diffY = character.Location.Y - set3[0].Location.Y;
    //            }
    //        }

    //        /// <summary>
    //        /// Method for keeping the colliders intact
    //        /// </summary>
    //        /// <param name="set">Set of colliders</param>
    //        /// <param name="spacing">spcing between colliders</param>
    //        private void SetCollidersToStick(List<PictureBox> set, int spacing)
    //        {
    //            for (int i = 1; i < 6; i++)
    //            {
    //                StickToControl(set[i - 1], character, i, spacing);
    //            }
    //        }


    //        /// <summary>
    //        /// Key press
    //        /// </summary>
    //        /// <param name="sender"></param>
    //        /// <param name="e"></param>
    //        public void KeyDownMethod(object sender, KeyEventArgs e)
    //        {
    //            if (finishedLoading == true)
    //            {
    //                if (e.KeyCode == System.Windows.Forms.Keys.Left)
    //                {
    //                    CclckWs = true;
    //                    clckWs = false;
    //                    RotateLeft();
    //                }
    //                if (e.KeyCode == System.Windows.Forms.Keys.Right)
    //                {
    //                    CclckWs = false;
    //                    clckWs = true;
    //                    RotateRight();
    //                }
    //                // Player Movement
    //                if (e.KeyCode == System.Windows.Forms.Keys.W)
    //                {
    //                    forward = true;
    //                }
    //                if (e.KeyCode == System.Windows.Forms.Keys.S)
    //                {
    //                    backward = true;
    //                }
    //            }
    //        }



    //        // minimap miniplayer icon
    //        private void RotateLeft()
    //        {
    //            rotationAngle = -90;
    //            RotateImage();
    //        }
    //        private void RotateRight()
    //        {
    //            rotationAngle = 90;
    //            RotateImage();
    //        }



    //        /// <summary>
    //        /// Key released
    //        /// </summary>
    //        /// <param name="sender"></param>
    //        /// <param name="e"></param>
    //        public void KeyUpMethod(object sender, KeyEventArgs e)
    //        {
    //            if (finishedLoading == true)
    //            {
    //                if (e.KeyCode == System.Windows.Forms.Keys.Left)
    //                {
    //                    CclckWs = false;
    //                    clckWs = false;

    //                }
    //                if (e.KeyCode == System.Windows.Forms.Keys.Right)
    //                {
    //                    CclckWs = false;
    //                    clckWs = false;

    //                }

    //                // Player Movement
    //                if (e.KeyCode == System.Windows.Forms.Keys.W)
    //                {
    //                    forward = false;
    //                }
    //                if (e.KeyCode == System.Windows.Forms.Keys.S)
    //                {
    //                    backward = false;
    //                }
    //            }
    //        }



    //        /// <summary>
    //        /// Moving The player and player entities (player entities are controls or game objects that are not neccessarily 
    //        /// the player however, moves with the player)
    //        /// </summary>
    //        /// <param name="character"> Character or the Control that represent the player. </param>
    //        /// <param name="c1"> Collider that is the nearest one to the player. </param>
    //        /// <param name="form1"> Form where the player moves around in. </param>
    //        /// <param name="finishedLoading"> True if form has finished loading, false if not</param>
    //        /// <remarks form1></remarks>
    //        public void PlayerMovement(Control form1)
    //        {
    //            finishedLoading = true;

    //            if (finishedLoading == true)
    //            {
    //                Player.Movement(form1, forward, backward, diffX, diffY);
    //            }
    //        }
    //        internal void StickToControl(Control ctr1, Control center, int numOfOrderOfCtr1, int spacing)
    //        {
    //            int squareOneXValue; // x value in the cartesian plane
    //            int squareOneYValue; // y value in the cartesian plane

    //            squareOneXValue = (ctr1.Left - center.Left);
    //            squareOneYValue = (ctr1.Bottom - center.Bottom);

    //            // center of the cartesian plane = character
    //            int centerXvalue = center.Location.X - center.Location.X; // x value 0
    //            int centerYvalue = center.Location.Y - center.Location.Y; // y value 0

    //            int placement = (numOfOrderOfCtr1 * spacing); // spacing of control from the center control
    //            int readjust = numOfOrderOfCtr1 * 4;

    //            if (squareOneXValue <= 0 && squareOneXValue < centerXvalue - placement) // if collider is on the left side of the cartesian plane
    //            {
    //                ctr1.Left += readjust;
    //                doOnce = true;
    //                FixBreaking("left");
    //            }
    //            if (squareOneYValue <= 0 && squareOneYValue < centerYvalue - placement)
    //            {
    //                ctr1.Top += readjust;
    //                doOnce = true;
    //                FixBreaking("forward");
    //            }
    //            if (squareOneXValue >= 0 && squareOneXValue > centerXvalue + placement) // if collider is on the right side of the cartesian plane
    //            {
    //                ctr1.Left -= readjust;
    //                doOnce = true;
    //                FixBreaking("right");
    //            }
    //            if (squareOneYValue >= 0 && squareOneYValue > centerYvalue + placement)
    //            {
    //                ctr1.Top -= readjust;
    //                doOnce = true;
    //                FixBreaking("backward");
    //            }



    //            if (squareOneXValue < 0 && squareOneXValue < centerXvalue - placement
    //                && squareOneYValue > 0 && squareOneYValue > centerYvalue - placement) // if collider is on the lower left side of the cartesian plane
    //            {
    //                ctr1.Left += readjust;
    //                ctr1.Top -= readjust;
    //            }
    //            if (squareOneXValue > 0 && squareOneXValue > centerXvalue + placement
    //                && squareOneYValue > 0 && squareOneYValue > centerYvalue + placement) // if collider is on the upper right side of the cartesian plane
    //            {
    //                ctr1.Left -= readjust;
    //                ctr1.Top += readjust;
    //            }
    //            if (squareOneXValue > 0 && squareOneXValue > centerXvalue - placement
    //                && squareOneYValue < 0 && squareOneYValue < centerYvalue - placement) // if collider is on the lower right side of the cartesian plane
    //            {
    //                ctr1.Left -= readjust;
    //                ctr1.Top -= readjust;
    //            }
    //            if (squareOneXValue < 0 && squareOneXValue < centerXvalue - placement
    //                && squareOneYValue < 0 && squareOneYValue < centerYvalue - placement) // if collider is on the upper left side of the cartesian plane
    //            {
    //                ctr1.Left -= readjust;
    //                ctr1.Top += readjust;
    //            }
    //        }
    //        internal void MovementForColliders()
    //        {

    //            if (finishedLoading == true)
    //            {
    //                const int speed = 2;

    //                foreach (List<PictureBox> set in colliderSets)
    //                {
    //                    SetColliderView(set, speed);
    //                }
    //            }
    //        }

    //        private void SetColliderView(List<PictureBox> set, int speed)
    //        {
    //            // sadly, for loop doesn't work for this
    //            ColliderForView(set[0], 1, speed);
    //            ColliderForView(set[1], 2, speed);
    //            ColliderForView(set[2], 3, speed);
    //            ColliderForView(set[3], 4, speed);
    //            ColliderForView(set[4], 5, speed);
    //        }

    //        internal void ColliderForView(Control ctr1, int numofOrderInControl, int speedDefault)
    //        {
    //            speed = (speedDefault * numofOrderInControl);

    //            int diffX = ctr1.Location.X - character.Location.X;
    //            int diffY = character.Location.Y - ctr1.Location.Y;

    //            colliderNewPoint = new Point(diffX, diffY);


    //            if (clckWs) // if player presses left key to turn counter clock wise
    //            {
    //                // if player is looking up
    //                if (colliderNewPoint.X >= 0 && colliderNewPoint.Y >= 0)
    //                {
    //                    ctr1.Top += speed;
    //                    ctr1.Left += speed;
    //                }
    //                if (colliderNewPoint.X >= 0 && colliderNewPoint.Y <= 0)
    //                {
    //                    ctr1.Left -= speed;
    //                    ctr1.Top += speed;
    //                }

    //                // if player is looking down
    //                if (colliderNewPoint.X <= 0 && colliderNewPoint.Y <= 0)
    //                {
    //                    ctr1.Left -= speed;
    //                    ctr1.Top -= speed;
    //                }
    //                if (colliderNewPoint.X <= 0 && colliderNewPoint.Y >= 0)
    //                {
    //                    ctr1.Top -= speed;
    //                    ctr1.Left += speed;
    //                }
    //            }
    //            if (CclckWs) // if player presses right key to turn clock wise
    //            {
    //                // if player is looking up
    //                if (colliderNewPoint.X >= 0 && colliderNewPoint.Y >= 0)
    //                {
    //                    ctr1.Top -= speed;
    //                    ctr1.Left -= speed;
    //                }
    //                if (colliderNewPoint.X >= 0 && colliderNewPoint.Y <= 0)
    //                {
    //                    ctr1.Left += speed;
    //                    ctr1.Top -= speed;
    //                }

    //                // if player is looking down
    //                if (colliderNewPoint.X <= 0 && colliderNewPoint.Y <= 0)
    //                {
    //                    ctr1.Left += speed;
    //                    ctr1.Top += speed;
    //                }
    //                if (colliderNewPoint.X <= 0 && colliderNewPoint.Y >= 0)
    //                {
    //                    ctr1.Top += speed;
    //                    ctr1.Left -= speed;
    //                }
    //            }
    //        }


    //        public void SelectMiniMap(Control bigmap, Control minimap)
    //        {
    //            this.bigmap = bigmap;
    //            this.minimap = minimap;
    //        }


    //        public void RenderMiniMap()
    //        {
    //            // get the common ratio to divide to the character location in order to get the equal location for the icon
    //            decimal differenceOfMapX = bigmap.Width / minimap.Width;
    //            decimal differenceOfMapY = bigmap.Height / minimap.Height;

    //            // get the location for the mini icon for the player from the player's actual position
    //            decimal iconX = character.Location.X / (int)Math.Floor(differenceOfMapX);
    //            decimal iconY = character.Location.Y / (int)Math.Floor(differenceOfMapY);

    //            // if we don't do this then the upper left point of the picture box of the mini player icon on mini map will
    //            // be the one set on the new point
    //            int iconAdjustment = playerIconOnMiniMap.Width / 2;

    //            // set precise location for mini player icon
    //            playerIconOnMiniMap.Location = new Point((int)Math.Floor(iconX) - iconAdjustment, (int)Math.Floor(iconY) - iconAdjustment); // apparently 15 is the difference idk
    //        }


    //        /// <summary>
    //        /// Overload of the main RotateImage(), but references the main method.
    //        /// </summary>
    //        private void RotateImage() => playerIconOnMiniMap.BackgroundImage = RotateImage(playerIconOnMiniMap.BackgroundImage, rotationAngle);


    //        /// <summary>
    //        /// Rotates the image in order to
    //        /// </summary>
    //        /// <param name="image"></param>
    //        /// <param name="angle"></param>
    //        /// <returns></returns>
    //        private Image RotateImage(Image image, int angle)
    //        {
    //            Bitmap rotatedImage = new Bitmap(image.Width, image.Height);
    //            rotatedImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

    //            // 'using' disposes the created Graphics by releasing its resources
    //            // first then disposes the resource used after the use of the code
    //            using (Graphics graphics = Graphics.FromImage(rotatedImage))
    //            {
    //                graphics.TranslateTransform(image.Width / 2, image.Height / 2); // moves the 0,0 location to the center of the image
    //                graphics.RotateTransform(angle); // rotates the image on new point 0,0
    //                graphics.TranslateTransform(-image.Width / 2, -image.Height / 2);// returns the 0,0 location to the upper left of the image
    //                graphics.DrawImage(image, Point.Empty);
    //            }

    //            return rotatedImage;
    //        }
    //    }
    //}

    #endregion
    #region GameStart.System
    //using System;
    //using System.Collections.Generic;
    //using System.Drawing;
    //using System.Linq;
    //using System.Text;
    //using System.Threading.Tasks;
    //using System.Windows.Forms;

    //namespace LightsOut.Classes.Game.GamePlay
    //{
    //    internal abstract class BaseClassGameStart
    //    {
    //        #region Initializations
    //        public GameMechanics Mechanics;
    //        public A_Admin Admin;
    //        public int TotalNumOfKeysToCollect;
    //        public int CollectedKeys;
    //        public Form game_Form;
    //        public string GameStatus;
    //        public int Score;
    //        public int TimeFinished;
    //        public int TimeToFinish;
    //        public int StartingScore;
    //        public int LightsOutTimer;
    //        #endregion
    //        public BaseClassGameStart()
    //        {
    //            // Initial score for all game modes
    //            StartingScore = 20000;
    //        }
    //        #region Abstract Methods
    //        public abstract void StartGame();
    //        public abstract void CalculateScoreCompleted();
    //        public abstract void ChooseToExitGameUnfinished();
    //        public abstract bool HasCollectedAllKeys();
    //        public abstract bool LightsOutEvent();
    //        public abstract void ResetLightsOutEventTimer();
    //        public abstract string ReturnGameType();
    //        #endregion

    //    }
    //}

    #endregion
    #region Easy.System
    //namespace LightsOut.Classes.Game.GamePlay
    //{
    //    internal class EasyDifficulty : BaseClassGameStart
    //    {
    //        public EasyDifficulty()
    //        {
    //            TotalNumOfKeysToCollect = 1;
    //            Score = 0;
    //            TimeToFinish = 300; // 5 minutes 
    //            LightsOutTimer = 30;
    //            CollectedKeys = 0;
    //        }



    //        // Start Game Method
    //        public override void StartGame()
    //        {
    //            Score = 0;
    //            TimeToFinish = 300; // 5 minutes 
    //        }


    //        // Score Calculation if status is complete
    //        public override void CalculateScoreCompleted()
    //        {
    //            GameStatus = "completed";
    //            Score = (StartingScore - (TimeToFinish - TimeFinished)) + (TotalNumOfKeysToCollect * 100);
    //        }


    //        // Player chose to Exit
    //        public override void ChooseToExitGameUnfinished()
    //        {
    //            GameStatus = "unfinished";
    //            Score = (StartingScore - 1000 - (TimeToFinish * 10) - (TotalNumOfKeysToCollect * 100));
    //        }


    //        // check if all keys are collected
    //        public override bool HasCollectedAllKeys()
    //        {
    //            return TotalNumOfKeysToCollect == CollectedKeys;
    //        }


    //        // lights out event check
    //        public override bool LightsOutEvent()
    //        {
    //            return LightsOutTimer == 0;
    //        }


    //        public override void ResetLightsOutEventTimer()
    //        {
    //            LightsOutTimer = 30;
    //        }

    //        public override string ReturnGameType() => "EASY";
    //    }
    //}

    #endregion
    #region Hard.System
    //using System;
    //using System.Collections.Generic;
    //using System.Linq;
    //using System.Text;
    //using System.Threading.Tasks;
    //using System.Windows.Forms;
    //using global::LightsOut.Classes.Game.GamePlay;

    //namespace LightsOut.Classes.Game.GamePlay
    //{
    //    internal class HardDifficulty : BaseClassGameStart
    //    {
    //        public HardDifficulty() : base()
    //        {
    //            TotalNumOfKeysToCollect = 4;
    //            Score = 0;
    //            TimeToFinish = 300; // 5 minutes
    //            LightsOutTimer = 10;
    //            CollectedKeys = 0;
    //        }



    //        // Start Game Method
    //        public override void StartGame()
    //        {
    //            Score = 0;
    //            TimeToFinish = 180;
    //        }


    //        // Score Calculation if status is complete
    //        public override void CalculateScoreCompleted()
    //        {
    //            GameStatus = "completed";
    //            Score = (StartingScore - (TimeToFinish - TimeFinished)) + (TotalNumOfKeysToCollect * 100);
    //        }



    //        // Player chose to Exit
    //        public override void ChooseToExitGameUnfinished()
    //        {
    //            GameStatus = "unfinished";
    //            Score = (StartingScore - 1000 - (TimeToFinish * 10) - (TotalNumOfKeysToCollect * 100));
    //        }


    //        // check if all keys are collected
    //        public override bool HasCollectedAllKeys()
    //        {
    //            return TotalNumOfKeysToCollect == CollectedKeys;
    //        }


    //        // lights out event check
    //        public override bool LightsOutEvent()
    //        {
    //            return LightsOutTimer == 0;
    //        }



    //        public override void ResetLightsOutEventTimer()
    //        {
    //            LightsOutTimer = 10;
    //        }

    //        public override string ReturnGameType() => "HARD";
    //    }
    //}

    #endregion
    #region Medium.System
    //using System;
    //using System.CodeDom;
    //using System.Collections.Generic;
    //using System.Linq;
    //using System.Text;
    //using System.Threading.Tasks;

    //namespace LightsOut.Classes.Game.GamePlay
    //{
    //    internal class MediumDifficulty : BaseClassGameStart
    //    {
    //        public MediumDifficulty()
    //        {
    //            TotalNumOfKeysToCollect = 3;
    //            Score = 0;
    //            TimeToFinish = 240; // 4 minutes
    //            LightsOutTimer = 20;
    //        }


    //        // Start Game Method
    //        public override void StartGame()
    //        {
    //            Score = 0;
    //            TimeToFinish = 240; // 5 minutes 
    //        }



    //        // Score Calculation if status is complete
    //        public override void CalculateScoreCompleted()
    //        {
    //            GameStatus = "completed";
    //            Score = (StartingScore - (TimeToFinish - TimeFinished)) + (TotalNumOfKeysToCollect * 100);
    //        }



    //        // Player chose to Exit
    //        public override void ChooseToExitGameUnfinished()
    //        {
    //            GameStatus = "unfinished";
    //            Score = (StartingScore - 1000 - (TimeToFinish * 10) - (TotalNumOfKeysToCollect * 100));
    //        }



    //        // check if all keys are collected
    //        public override bool HasCollectedAllKeys()
    //        {
    //            return TotalNumOfKeysToCollect == CollectedKeys;
    //        }



    //        // lights out event check
    //        public override bool LightsOutEvent()
    //        {
    //            return LightsOutTimer == 0;
    //        }
    //        public override void ResetLightsOutEventTimer()
    //        {
    //            LightsOutTimer = 30;
    //        }

    //        public override string ReturnGameType() => "MEDIUM";
    //    }
    //}

    #endregion
    #region Perspective.System
    //using LightsOut.Classes.Game;
    //using LightsOut.Classes.Game.Perspective_Rendering;
    //using System;
    //using System.Collections.Generic;
    //using System.Drawing;
    //using System.Net.NetworkInformation;
    //using System.Windows.Forms;

    //namespace LightsOut.Classes
    //{
    //    internal class Perspective : IWalls, IGroundAndCeiling
    //    {
    //        #region Attributes
    //        public List<PictureBox> set1 = new List<PictureBox>();
    //        public List<PictureBox> set2 = new List<PictureBox>();
    //        public List<PictureBox> set3 = new List<PictureBox>();
    //        public List<PictureBox> set4 = new List<PictureBox>();
    //        public List<PictureBox> set5 = new List<PictureBox>();

    //        public List<PictureBox> set7 = new List<PictureBox>();
    //        public List<PictureBox> set8 = new List<PictureBox>();
    //        public List<PictureBox> set9 = new List<PictureBox>();
    //        public List<PictureBox> set10 = new List<PictureBox>();

    //        public List<PictureBox> set11 = new List<PictureBox>();
    //        public List<PictureBox> set12 = new List<PictureBox>();
    //        public List<PictureBox> set13 = new List<PictureBox>();
    //        public List<PictureBox> set14 = new List<PictureBox>();

    //        bool depth1, depth2, depth3, depth4, depth5, depth6;
    //        A_Admin admin;
    //        GameMechanics player;

    //        public Panel w1;
    //        public Panel w2;
    //        public Panel w3;
    //        public Panel w4;
    //        public Panel w5;
    //        public Panel w6;
    //        public Panel w7;
    //        public Panel w8;
    //        public Panel w9;
    //        public Panel w10;

    //        public Panel w11;
    //        public Panel w12;
    //        public Panel w13;
    //        public Panel w14;
    //        public Panel w15;
    //        public Panel w16;
    //        public Panel w17;
    //        public Panel w18;
    //        public Panel w19;
    //        public Panel w20;

    //        public Panel w21;
    //        public Panel w22;
    //        public Panel w23;
    //        public Panel w24;
    //        public Panel w25;
    //        public Panel w26;
    //        public Panel w27;
    //        public Panel w28;
    //        public Panel w29;
    //        public Panel w30;

    //        public Panel w31;
    //        public Panel w32;
    //        public Panel w33;
    //        public Panel w34;
    //        public Panel w35;
    //        public Panel w36;
    //        public Panel w37;
    //        public Panel w38;
    //        public Panel w39;
    //        public Panel w40;

    //        public Panel w41; //


    //        public Color movingColor1 = Color.FromArgb(40, 40, 40);
    //        public Color movingColor2 = Color.FromArgb(15, 15, 15);
    //        public Control screen;
    //        public Control character;
    //        #endregion

    //        #region Constructor
    //        public Perspective // Constructor to be used for passing the set colliders
    //            (
    //                List<PictureBox> set1,
    //                List<PictureBox> set2,
    //                List<PictureBox> set3,
    //                List<PictureBox> set4,
    //                List<PictureBox> set5,
    //                List<PictureBox> set7,
    //                List<PictureBox> set8,
    //                List<PictureBox> set9,
    //                List<PictureBox> set10,
    //                List<PictureBox> set11,
    //                List<PictureBox> set12,
    //                List<PictureBox> set13,
    //                List<PictureBox> set14,
    //                A_Admin admin,
    //                Control screen,
    //                GameMechanics player
    //            )
    //        {
    //            this.set1 = set1;
    //            this.set2 = set2;
    //            this.set3 = set3;
    //            this.set4 = set4;
    //            this.set5 = set5;
    //            this.set7 = set7;
    //            this.set8 = set8;
    //            this.set9 = set9;
    //            this.set10 = set10;
    //            this.set11 = set11;
    //            this.set12 = set12;
    //            this.set13 = set13;
    //            this.set14 = set14;
    //            this.admin = admin;
    //            this.screen = screen;
    //            this.player = player;
    //        }

    //        public Perspective() { /**/ }
    //        public Perspective(Control screen, Control character)
    //        {
    //            this.screen = screen;
    //            this.character = character;
    //        }
    //        #endregion

    //        #region Walls
    //        public void Walls(
    //        Panel w1,
    //        Panel w2,
    //        Panel w3,
    //        Panel w4,
    //        Panel w5,
    //        Panel w6,
    //        Panel w7,
    //        Panel w8,
    //        Panel w9,
    //        Panel w10,
    //        Panel w11,
    //        Panel w12,
    //        Panel w13,
    //        Panel w14,
    //        Panel w15,
    //        Panel w16,
    //        Panel w17,
    //        Panel w18,
    //        Panel w19,
    //        Panel w20,
    //        Panel w21,
    //        Panel w22,
    //        Panel w23,
    //        Panel w24,
    //        Panel w25,
    //        Panel w26,
    //        Panel w27,
    //        Panel w28,
    //        Panel w29,
    //        Panel w30,
    //        Panel w31,
    //        Panel w32,
    //        Panel w33,
    //        Panel w34,
    //        Panel w35,
    //        Panel w36,
    //        Panel w37,
    //        Panel w38,
    //        Panel w39,
    //        Panel w40,
    //        Panel w41
    //            )
    //        {
    //            this.w1 = w1;
    //            this.w2 = w2;
    //            this.w3 = w3;
    //            this.w4 = w4;
    //            this.w5 = w5;
    //            this.w6 = w6;
    //            this.w7 = w7;
    //            this.w8 = w8;
    //            this.w9 = w9;
    //            this.w10 = w10;
    //            this.w11 = w11;
    //            this.w12 = w12;
    //            this.w13 = w13;
    //            this.w14 = w14;
    //            this.w15 = w15;
    //            this.w16 = w16;
    //            this.w17 = w17;
    //            this.w18 = w18;
    //            this.w19 = w19;
    //            this.w20 = w20;
    //            this.w21 = w21;
    //            this.w22 = w22;
    //            this.w23 = w23;
    //            this.w24 = w24;
    //            this.w25 = w25;
    //            this.w26 = w26;
    //            this.w27 = w27;
    //            this.w28 = w28;
    //            this.w29 = w29;
    //            this.w30 = w30;
    //            this.w31 = w31;
    //            this.w32 = w32;
    //            this.w33 = w33;
    //            this.w34 = w34;
    //            this.w35 = w35;
    //            this.w36 = w36;
    //            this.w37 = w37;
    //            this.w38 = w38;
    //            this.w39 = w39;
    //            this.w40 = w40;
    //            this.w41 = w41;
    //        }

    //        #endregion

    //        /* depth 0 = no collision
    //         * depth 1 = collision on 5          Farthest
    //         * depth 2 = collision on 4             |
    //         * depth 3 = collision on 3             |
    //         * depth 4 = collision on 2             V
    //         * depth 5 & 6 = collision on 1      Nearest
    //         */

    //        public Color ApplySelectedTheme(string selectedTheme, int index)
    //        {
    //            #region Color Theme Lists
    //            List<Color> yellow = new List<Color>()
    //        {
    //            Color.FromArgb(255, 186, 59),
    //            Color.FromArgb(209, 138, 38),
    //            Color.FromArgb(179, 119, 36),
    //            Color.FromArgb(156, 94, 33),
    //            Color.FromArgb(97, 59, 22),
    //            Color.FromArgb(38, 24, 10),
    //            Color.FromArgb(15, 10, 5)
    //        };
    //            List<Color> brown = new List<Color>()
    //        {
    //            Color.FromArgb(139, 69, 19),
    //            Color.FromArgb(115, 59, 18),
    //            Color.FromArgb(89, 46, 14),
    //            Color.FromArgb(64, 34, 11),
    //            Color.FromArgb(41, 22, 8),
    //            Color.FromArgb(20, 11, 4),
    //            Color.FromArgb(5, 3, 1)
    //        };
    //            List<Color> aquamarine = new List<Color>()
    //        {
    //            Color.FromArgb(127, 255, 212),
    //            Color.FromArgb(97, 201, 166),
    //            Color.FromArgb(79, 158, 131),
    //            Color.FromArgb(57, 112, 93),
    //            Color.FromArgb(36, 69, 58),
    //            Color.FromArgb(18, 33, 28),
    //            Color.FromArgb(9, 15, 13)
    //        };
    //            List<Color> darkred = new List<Color>()
    //        {
    //            Color.FromArgb(189, 26, 26),
    //            Color.FromArgb(143, 21, 21),
    //            Color.FromArgb(115, 18, 18),
    //            Color.FromArgb(87, 16, 16),
    //            Color.FromArgb(59, 13, 13),
    //            Color.FromArgb(28, 7, 7),
    //            Color.FromArgb(15, 4, 4)
    //        };
    //            List<Color> darkgreen = new List<Color>()
    //        {
    //            Color.FromArgb(57, 138, 33),
    //            Color.FromArgb(32, 107, 24),
    //            Color.FromArgb(22, 79, 16),
    //            Color.FromArgb(15, 61, 10),
    //            Color.FromArgb(11, 38, 8),
    //            Color.FromArgb(6, 20, 4),
    //            Color.FromArgb(2, 8, 2)
    //        };
    //            List<Color> orange = new List<Color>()
    //        {
    //            Color.FromArgb(255, 160, 36),
    //            Color.FromArgb(199, 113, 22),
    //            Color.FromArgb(168, 95, 17),
    //            Color.FromArgb(138, 74, 11),
    //            Color.FromArgb(66, 37, 9),
    //            Color.FromArgb(20, 12, 4),
    //            Color.FromArgb(10, 6, 2)
    //        };
    //            List<Color> cornflowerblue = new List<Color>()
    //        {
    //            Color.FromArgb(100, 149, 237),
    //            Color.FromArgb(75, 119, 189),
    //            Color.FromArgb(56, 92, 150),
    //            Color.FromArgb(38, 67, 115),
    //            Color.FromArgb(29, 49, 82),
    //            Color.FromArgb(18, 28, 46),
    //            Color.FromArgb(11, 16, 26)
    //        };
    //            List<Color> purple = new List<Color>()
    //        {
    //            Color.FromArgb(157, 34, 179),
    //            Color.FromArgb(132, 27, 150),
    //            Color.FromArgb(112, 19, 128),
    //            Color.FromArgb(93, 14, 107),
    //            Color.FromArgb(67, 12, 77),
    //            Color.FromArgb(36, 9, 41),
    //            Color.FromArgb(20, 6, 23)
    //        };
    //            #endregion

    //            switch (selectedTheme)
    //            {
    //                case "yellow":
    //                    return yellow[index];
    //                case "brown":
    //                    return brown[index];
    //                case "aquamarine":
    //                    return aquamarine[index];
    //                case "darkred":
    //                    return darkred[index];
    //                case "darkgreen":
    //                    return darkgreen[index];
    //                case "orange":
    //                    return orange[index];
    //                case "cornflowerblue":
    //                    return cornflowerblue[index];
    //                case "purple":
    //                    return purple[index];
    //                default:
    //                    return Color.Black;
    //            }
    //        }

    //        public void StillOnGround(Control ground)
    //        {
    //            bool GroundIsVertical = (ground.Width < ground.Height);
    //            bool IsPlayerStillOnGround = (character.Bounds.IntersectsWith(ground.Bounds));



    //            if (character.Top < ground.Top && GroundIsVertical && IsPlayerStillOnGround)
    //            {
    //                foreach (Control character in screen.Controls)
    //                {
    //                    if (character.AccessibleName == "player")
    //                    {
    //                        character.Top += 5;
    //                    }
    //                }
    //            }
    //            if (character.Top > ground.Top + ground.Height - character.Height && GroundIsVertical && IsPlayerStillOnGround)
    //            {
    //                foreach (Control character in screen.Controls)
    //                {
    //                    if (character.AccessibleName == "player")
    //                    {
    //                        character.Top -= 5;
    //                    }
    //                }
    //            }
    //            if (character.Left < ground.Left && !GroundIsVertical && IsPlayerStillOnGround)
    //            {
    //                foreach (Control character in screen.Controls)
    //                {
    //                    if (character.AccessibleName == "player")
    //                    {
    //                        character.Left += 5;
    //                    }
    //                }
    //            }
    //            if (character.Left > ground.Left + ground.Width - character.Width && !GroundIsVertical && IsPlayerStillOnGround)
    //            {
    //                foreach (Control character in screen.Controls)
    //                {
    //                    if (character.AccessibleName == "player")
    //                    {
    //                        character.Left -= 5;
    //                    }
    //                }
    //            }




    //            if (character.Left < ground.Left && GroundIsVertical && IsPlayerStillOnGround)
    //            {
    //                foreach (Control character in screen.Controls)
    //                {
    //                    if (character.AccessibleName == "player")
    //                    {
    //                        character.Left++;
    //                    }
    //                }
    //            }
    //            if (character.Left > ground.Left && GroundIsVertical && IsPlayerStillOnGround)
    //            {
    //                foreach (Control character in screen.Controls)
    //                {
    //                    if (character.AccessibleName == "player")
    //                    {
    //                        character.Left--;
    //                    }
    //                }
    //            }


    //            if (character.Top < ground.Top && !GroundIsVertical && IsPlayerStillOnGround)
    //            {
    //                foreach (Control character in screen.Controls)
    //                {
    //                    if (character.AccessibleName == "player")
    //                    {
    //                        character.Top++;
    //                    }
    //                }
    //            }
    //            if (character.Top > ground.Top && !GroundIsVertical && IsPlayerStillOnGround)
    //            {
    //                foreach (Control character in screen.Controls)
    //                {
    //                    if (character.AccessibleName == "player")
    //                    {
    //                        character.Top--;
    //                    }
    //                }
    //            }
    //        }




    //        // returns selected theme color based of an index given
    //        public Color AddThemeColor(int index)
    //        {
    //            return ApplySelectedTheme(admin.selectedTheme, index);
    //        }




    //        /// <summary>
    //        /// Render perspective on screen
    //        /// </summary>
    //        /// <param name="color"> String input to decide what part of the screen render sets</param>
    //        /// <param name="setList"> Set list, a set of colliders arranged from  1 - 5 (0 index to 4) and is 
    //        /// from nearest to furthest, 0 being the nearest, and 4 being the farthest</param>
    //        /// <param name="form">
    //        /// Form on which the game takes place</param>
    //        /// 
    //        public void RenderPerspectiveMainScreenArea(string column, List<PictureBox> setList) // done
    //        {
    //            Color change;

    //            // 0, 1, 2, 3, 4  || Index in the list setlist[n]
    //            foreach (Control render in screen.Controls) // foreach for the render panels in the game
    //            {
    //                if (render.AccessibleDescription == "depth0")
    //                {
    //                    if (!CollidingWithWalls(setList[4]))
    //                    { // checks if collider setList index 4 (5th collider, further out) is colliding with a wall | no collision
    //                        if (render.AccessibleName == column) // looks for the proper row/column to render
    //                        {
    //                            change = ApplySelectedTheme(admin.selectedTheme, 5); // sets new values for color
    //                            render.BackColor = change; // changes the values accordingly
    //                        }
    //                    }

    //                    if (CollidingWithWalls(setList[4]))
    //                    {// Index 4 being the farthest to the player (has the darkest color, except for no collision color)
    //                        if (render.AccessibleName == column)
    //                        {
    //                            change = ApplySelectedTheme(admin.selectedTheme, 4);
    //                            render.BackColor = change;
    //                        }
    //                    }

    //                    if (CollidingWithWalls(setList[3]))
    //                    { // Index 3 || collider 4 
    //                        if (render.AccessibleName == column)
    //                        {
    //                            change = ApplySelectedTheme(admin.selectedTheme, 3);
    //                            render.BackColor = change;
    //                        }
    //                    }

    //                    if (CollidingWithWalls(setList[2]))
    //                    { // Index 2 || collider 3
    //                        if (render.AccessibleName == column)
    //                        {
    //                            change = ApplySelectedTheme(admin.selectedTheme, 2);
    //                            render.BackColor = change;
    //                        }
    //                    }

    //                    if (CollidingWithWalls(setList[1]))
    //                    { // Index 1 || collider 2

    //                        if (render.AccessibleName == column)
    //                        {
    //                            change = ApplySelectedTheme(admin.selectedTheme, 1);
    //                            render.BackColor = change;
    //                        }
    //                    }

    //                    if (CollidingWithWalls(setList[0]))
    //                    { // Index 0 being the nearest to the player (has the brightest color)
    //                        if (render.AccessibleName == column)
    //                        {
    //                            change = ApplySelectedTheme(admin.selectedTheme, 0);
    //                            render.BackColor = change;
    //                        }
    //                    }
    //                }
    //            }
    //        }





    //        /// <summary>
    //        /// Checks if the given collider Rect collides with a wall Rect
    //        /// </summary>
    //        /// <param name="collider">Collider hekhok</param>
    //        /// <returns></returns>
    //        public bool CollidingWithWalls(Control collider)
    //        {
    //            return (
    //                collider.Bounds.IntersectsWith(w1.Bounds) ||
    //                collider.Bounds.IntersectsWith(w2.Bounds) ||
    //                collider.Bounds.IntersectsWith(w3.Bounds) ||
    //                collider.Bounds.IntersectsWith(w4.Bounds) ||
    //                collider.Bounds.IntersectsWith(w5.Bounds) ||
    //                collider.Bounds.IntersectsWith(w6.Bounds) ||
    //                collider.Bounds.IntersectsWith(w7.Bounds) ||
    //                collider.Bounds.IntersectsWith(w8.Bounds) ||
    //                collider.Bounds.IntersectsWith(w9.Bounds) ||
    //                collider.Bounds.IntersectsWith(w10.Bounds) ||
    //                collider.Bounds.IntersectsWith(w11.Bounds) ||
    //                collider.Bounds.IntersectsWith(w12.Bounds) ||
    //                collider.Bounds.IntersectsWith(w13.Bounds) ||
    //                collider.Bounds.IntersectsWith(w14.Bounds) ||
    //                collider.Bounds.IntersectsWith(w15.Bounds) ||
    //                collider.Bounds.IntersectsWith(w16.Bounds) ||
    //                collider.Bounds.IntersectsWith(w17.Bounds) ||
    //                collider.Bounds.IntersectsWith(w18.Bounds) ||
    //                collider.Bounds.IntersectsWith(w19.Bounds) ||
    //                collider.Bounds.IntersectsWith(w20.Bounds) ||
    //                collider.Bounds.IntersectsWith(w21.Bounds) ||
    //                collider.Bounds.IntersectsWith(w22.Bounds) ||
    //                collider.Bounds.IntersectsWith(w23.Bounds) ||
    //                collider.Bounds.IntersectsWith(w24.Bounds) ||
    //                collider.Bounds.IntersectsWith(w25.Bounds) ||
    //                collider.Bounds.IntersectsWith(w26.Bounds) ||
    //                collider.Bounds.IntersectsWith(w27.Bounds) ||
    //                collider.Bounds.IntersectsWith(w28.Bounds) ||
    //                collider.Bounds.IntersectsWith(w29.Bounds) ||
    //                collider.Bounds.IntersectsWith(w30.Bounds) ||
    //                collider.Bounds.IntersectsWith(w31.Bounds) ||
    //                collider.Bounds.IntersectsWith(w32.Bounds) ||
    //                collider.Bounds.IntersectsWith(w33.Bounds) ||
    //                collider.Bounds.IntersectsWith(w34.Bounds) ||
    //                collider.Bounds.IntersectsWith(w35.Bounds) ||
    //                collider.Bounds.IntersectsWith(w36.Bounds) ||
    //                collider.Bounds.IntersectsWith(w37.Bounds) ||
    //                collider.Bounds.IntersectsWith(w38.Bounds) ||
    //                collider.Bounds.IntersectsWith(w39.Bounds) ||
    //                collider.Bounds.IntersectsWith(w40.Bounds) ||
    //                collider.Bounds.IntersectsWith(w41.Bounds)
    //                ); // di madag loop oi
    //        }

    //        /// <summary>
    //        /// Renders the ground and ceiling for the on screen panels display
    //        /// </summary>
    //        /// <param name="screen">Where the rendering takes place</param>
    //        /// <param name="_column1">What panel is triggered to use as basis</param>
    //        public void RenderPerspectiveForGroundAndCeiling(Control _column1)
    //        {
    //            Control Column;
    //            try
    //            {
    //                #region Storing values on variables
    //                Column = _column1;

    //                Color depth = Color.FromArgb(40, 40, 40);

    //                #endregion

    //                foreach (Control Render in screen.Controls) // 
    //                {
    //                    // if panel is the in the same column
    //                    if (Render.AccessibleName == Column.AccessibleName)
    //                    {
    //                        if (Column.BackColor == ApplySelectedTheme(admin.selectedTheme, 5)) // check panel color
    //                        {
    //                            if (Render.AccessibleDescription == "depth1")
    //                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 5);

    //                            if (Render.AccessibleDescription == "depth2")
    //                                Render.BackColor = depth;

    //                            if (Render.AccessibleDescription == "depth3")
    //                                Render.BackColor = depth;

    //                            if (Render.AccessibleDescription == "depth4")
    //                                Render.BackColor = depth;

    //                            if (Render.AccessibleDescription == "depth5")
    //                                Render.BackColor = depth;

    //                            if (Render.AccessibleDescription == "depth6")
    //                                Render.BackColor = depth;
    //                        }
    //                        if (Column.BackColor == ApplySelectedTheme(admin.selectedTheme, 4)) // check panel color
    //                        {
    //                            if (Render.AccessibleDescription == "depth1")
    //                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 4);

    //                            if (Render.AccessibleDescription == "depth2")
    //                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 4);

    //                            if (Render.AccessibleDescription == "depth3")
    //                                Render.BackColor = depth;

    //                            if (Render.AccessibleDescription == "depth4")

    //                                Render.BackColor = depth;

    //                            if (Render.AccessibleDescription == "depth5")
    //                                Render.BackColor = depth;

    //                            if (Render.AccessibleDescription == "depth6")
    //                                Render.BackColor = depth;
    //                        }
    //                        if (Column.BackColor == ApplySelectedTheme(admin.selectedTheme, 3)) // check panel color
    //                        {
    //                            if (Render.AccessibleDescription == "depth1")
    //                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 3);

    //                            if (Render.AccessibleDescription == "depth2")
    //                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 3);

    //                            if (Render.AccessibleDescription == "depth3")
    //                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 3);

    //                            if (Render.AccessibleDescription == "depth4")
    //                                Render.BackColor = depth;

    //                            if (Render.AccessibleDescription == "depth5")
    //                                Render.BackColor = depth;

    //                            if (Render.AccessibleDescription == "depth6")
    //                                Render.BackColor = depth;
    //                        }
    //                        if (Column.BackColor == ApplySelectedTheme(admin.selectedTheme, 2)) // check panel color
    //                        {
    //                            if (Render.AccessibleDescription == "depth1")
    //                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 2);

    //                            if (Render.AccessibleDescription == "depth2")
    //                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 2);

    //                            if (Render.AccessibleDescription == "depth3")
    //                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 2);

    //                            if (Render.AccessibleDescription == "depth4")
    //                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 2);

    //                            if (Render.AccessibleDescription == "depth5")
    //                                Render.BackColor = depth;

    //                            if (Render.AccessibleDescription == "depth6")
    //                                Render.BackColor = depth;
    //                        }
    //                        if (Column.BackColor == ApplySelectedTheme(admin.selectedTheme, 1)) // check panel color
    //                        {
    //                            if (Render.AccessibleDescription == "depth1")
    //                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 1);

    //                            if (Render.AccessibleDescription == "depth2")
    //                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 1);

    //                            if (Render.AccessibleDescription == "depth3")
    //                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 1);

    //                            if (Render.AccessibleDescription == "depth4")
    //                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 1);

    //                            if (Render.AccessibleDescription == "depth5")
    //                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 1);

    //                            if (Render.AccessibleDescription == "depth6")
    //                                Render.BackColor = depth;
    //                        }
    //                        if (Column.BackColor == ApplySelectedTheme(admin.selectedTheme, 0)) // check panel color
    //                        {
    //                            if (Render.AccessibleDescription == "depth1")
    //                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 0);

    //                            if (Render.AccessibleDescription == "depth2")
    //                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 0);

    //                            if (Render.AccessibleDescription == "depth3")
    //                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 0);

    //                            if (Render.AccessibleDescription == "depth4")
    //                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 0);

    //                            if (Render.AccessibleDescription == "depth5")
    //                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 0);

    //                            if (Render.AccessibleDescription == "depth6")
    //                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 0);
    //                        }
    //                    }
    //                }
    //            }
    //            catch (Exception) {/**/}
    //        }
    //        /// <summary>
    //        /// Changes the ground Control given based of the string given
    //        /// </summary>
    //        /// <param name="ground">Control that will be checked for AccessibleDescription</param>
    //        /// <param name="depthFirst">First Depth or the Depth previous</param>
    //        /// <param name="depthSecond">Second Depth, the Control that will be updated next</param>
    //        public void ChangeGroundColor(Control ground, string depthFirst, string depthSecond)
    //        {
    //            if (ground.AccessibleDescription == depthFirst)
    //                ground.BackColor = movingColor1;
    //            if (ground.AccessibleDescription == depthSecond)
    //                ground.BackColor = movingColor2;
    //        }
    //    }
    //}

    #endregion
    #region GameObject.System
    //using System.Windows.Forms;

    //namespace LightsOut.Classes
    //{
    //    internal abstract class BaseClassGameObject
    //    {
    //        public int movementspeed;
    //        public int numOfEntities;

    //        public abstract void Movement(Control form1, bool forward, bool backward, int diffX, int diffY);
    //    }
    //}

    #endregion
    #region Player.System
    //using LightsOut.Classes.Game;
    //using System.Windows.Forms;

    //namespace LightsOut.Classes
    //{
    //    internal class Player : BaseClassGameObject
    //    {
    //        Control player;
    //        public Player(Control player)
    //        {
    //            movementspeed = 5;
    //            numOfEntities = 1;
    //            this.player = player;
    //        }
    //        public bool CheckCollisionWithEntity(Form form, string type)
    //        {
    //            bool result = true;
    //            foreach (Control enemy in form.Controls)
    //            {
    //                if (enemy.AccessibleDescription == type) // enemy or key
    //                {
    //                    result = (player.Bounds.IntersectsWith(enemy.Bounds));
    //                    return result;
    //                }
    //            }
    //            return result;
    //        }
    //        public override void Movement(Control form1, bool forward, bool backward, int diffX, int diffY)
    //        {
    //            foreach (Control ground in form1.Controls)
    //            {
    //                if (ground.AccessibleName == "ground")
    //                {
    //                    if (player.Bounds.IntersectsWith(ground.Bounds))
    //                    {
    //                        int speed = 5;
    //                        if (forward && (0 < diffY)) // collider facing up/forward
    //                            foreach (Control c in form1.Controls)
    //                                if (c.AccessibleName == player.AccessibleName)
    //                                    c.Top -= speed;


    //                        if (forward && (0 > diffY))
    //                            foreach (Control c in form1.Controls)
    //                                if (c.AccessibleName == player.AccessibleName)
    //                                    c.Top += speed;


    //                        if (forward && (0 < diffX))
    //                            foreach (Control c in form1.Controls)
    //                                if (c.AccessibleName == player.AccessibleName)
    //                                    c.Left += speed;


    //                        if (forward && (0 > diffX))
    //                            foreach (Control c in form1.Controls)
    //                                if (c.AccessibleName == player.AccessibleName)
    //                                    c.Left -= speed;


    //                        if (backward && (0 < diffY)) // collider facing up/forward
    //                            foreach (Control c in form1.Controls)
    //                                if (c.AccessibleName == player.AccessibleName)
    //                                    c.Top += speed;


    //                        if (backward && (0 > diffY))
    //                            foreach (Control c in form1.Controls)
    //                                if (c.AccessibleName == player.AccessibleName)
    //                                    c.Top -= speed;


    //                        if (backward && (0 < diffX))
    //                            foreach (Control c in form1.Controls)
    //                                if (c.AccessibleName == player.AccessibleName)
    //                                    c.Left -= speed;


    //                        if (backward && (0 > diffX))
    //                            foreach (Control c in form1.Controls)
    //                                if (c.AccessibleName == player.AccessibleName)
    //                                    c.Left += speed;
    //                    }
    //                }
    //            }
    //        }
    //    }
    //}

    #endregion
    #region Animate.System
    //using System.Windows.Forms;
    //using global::LightsOut.Classes.Homepage;

    //namespace LightsOut.Classes.Homepage
    //{
    //    internal class Animate : BaseClassHomePage
    //    {
    //        private bool back;
    //        private bool runonce = true;



    //        public Animate() : base() { }
    //        public Animate(bool back) : base() { this.back = back; }
    //        public Animate(bool back, int speedOfAnimation) : base(speedOfAnimation)
    //        {
    //            this.back = back;
    //        }




    //        /// <summary>
    //        /// Main Header Animation Method with default speed.
    //        /// </summary>
    //        /// <param name="header">
    //        /// The Control you want to move or to act as your header
    //        /// </param>
    //        /// <param name="form">
    //        /// The form on which the animation will take place
    //        /// </param>
    //        public void HeaderAnimation(Control header, Form form)
    //        {
    //            // title animation
    //            if (header.Top < -6)
    //                header.Top += 4;
    //            else
    //                if (header.Top < -5)
    //                header.Top += 2;
    //        }




    //        /// <summary>
    //        /// Overload of Header Animation Method, 
    //        /// add true or false in the argument
    //        /// in order to use the speed given in the parameterized constructor.
    //        /// </summary>
    //        /// <param name="header">
    //        /// The Control you want to move or to act as your header
    //        /// </param>
    //        /// <param name="form">
    //        /// The form on which the animation will take place
    //        /// </param>
    //        /// <param name="Custom">
    //        /// Set to true or false, automatically uses the speed given on the constrctor that was called during
    //        /// object definition, if none was given then, possible null reference.
    //        /// </param>
    //        public void HeaderAnimation(Control header, Form form, bool Custom) // Just set true to customize speed
    //        {
    //            // title animation
    //            if (header.Top < form.Height)
    //                header.Top += (speedOfAnimation) * 2;
    //            else
    //                if (header.Top < -(speedOfAnimation))
    //                header.Top += (speedOfAnimation);
    //        }




    //        /// <summary>
    //        /// Animation Method for panels (Four) to move in order from left to right. 
    //        /// </summary>
    //        /// <param name="mv1">
    //        /// Moves first
    //        /// </param>
    //        /// <param name="mv2">
    //        /// Moves second
    //        /// </param>
    //        /// <param name="mv3">
    //        /// Moves third
    //        /// </param>
    //        /// <param name="mv4">
    //        /// Moves last
    //        /// </param>
    //        public void LeftToRightAnimationFour(Control mv1, Control mv2, Control mv3, Control mv4)
    //        {
    //            // Left side animation
    //            if (mv1.Left < 0)
    //                mv1.Left += 5;
    //            if (mv1.Left >= 0 && mv2.Left < 0)
    //                mv2.Left += 10;
    //            if (mv2.Left >= 0 && mv3.Left < 0)
    //                mv3.Left += 15;
    //            if (mv3.Left >= 0 && mv4.Left < 0)
    //                mv4.Left += 20;
    //        }




    //        /// <summary>
    //        /// Animation Method for panels (Four) to move in order from right to left.
    //        /// </summary>
    //        /// <param name="mv1">
    //        /// Moves first
    //        /// </param>
    //        /// <param name="mv2">
    //        /// Moves second
    //        /// </param>
    //        /// <param name="mv3">
    //        /// Moves third
    //        /// </param>
    //        /// <param name="mv4">
    //        /// Moves last
    //        /// </param>
    //        public void RightToLeftAnimationFour(Control mv1, Control mv2, Control mv3, Control mv4, Form form)
    //        {

    //            // Right Side animation
    //            if (mv1.Left > form.Width - mv1.Width)
    //                mv1.Left -= 5;
    //            if (mv1.Left <= form.Width - mv1.Width &&
    //                mv2.Left > form.Width - mv2.Width)
    //                mv2.Left -= 10;
    //            if (mv2.Left <= form.Width - mv2.Width &&
    //                mv3.Left > form.Width - mv3.Width)
    //                mv3.Left -= 15;
    //            if (mv3.Left <= form.Width - mv3.Width &&
    //                mv4.Left > form.Width - mv4.Width)
    //                mv4.Left -= 20;
    //        }




    //        /// <summary>
    //        /// Up and down animation loop, makes it look like it's bouncing!
    //        /// </summary>
    //        /// <param name="mv">
    //        /// Control you want to animate
    //        /// </param>
    //        public void UpDownLoopAnimation(Control mv)
    //        {
    //            // Guest mode text animation up and down loop
    //            if (mv.Top > 315 && back == false)
    //            {
    //                mv.Top--;
    //            }
    //            if (mv.Top <= 315)
    //                back = true;
    //            if (back == true && mv.Top <= 323)
    //            {
    //                mv.Top++;
    //            }
    //            if (mv.Top >= 323)
    //                back = false;
    //        }




    //        /// <summary>
    //        /// Overload of Up and down animation loop, makes it look like it's bouncing!
    //        /// </summary>
    //        /// <param name="mv">
    //        /// Control you want to animate
    //        /// </param>
    //        /// <param name="topY">
    //        /// Top Y coordinates of how far up you want the control to go
    //        /// </param>
    //        /// <param name="bottomY">
    //        /// Bottom Y coordinates of how far up you want the control to go
    //        /// </param>
    //        public void UpDownLoopAnimation(Control mv, int topY, int bottomY)
    //        {
    //            // Guest mode text animation up and down loop
    //            if (mv.Top > topY && back == false)
    //            {
    //                mv.Top--;
    //            }
    //            if (mv.Top <= topY)
    //                back = true;
    //            if (back == true && mv.Top <= bottomY)
    //            {
    //                mv.Top++;
    //            }
    //            if (mv.Top >= bottomY)
    //                back = false;
    //        }




    //        /// <summary>
    //        /// Overload of Up and down animation loop, makes it look like it's bouncing!
    //        /// </summary>
    //        /// <param name="mv">
    //        /// Control you want to animate
    //        /// </param>
    //        /// <param name="topY">
    //        /// Top Y coordinates of how far up you want the control to go
    //        /// </param>
    //        /// <param name="bottomY">
    //        /// Bottom Y coordinates of how far up you want the control to go
    //        /// </param>
    //        public void UpDownLoopAnimation(Control mv, int space)
    //        {
    //            int topY = 0;
    //            int bottomY = 0;

    //            if (runonce)
    //            {
    //                topY = mv.Top - space;
    //                bottomY = mv.Top;
    //            }
    //            // Guest mode text animation up and down loop
    //            if (mv.Top > topY && back == false)
    //            {
    //                mv.Top--;
    //            }
    //            if (mv.Top <= topY)
    //                back = true;
    //            if (back == true && mv.Top <= bottomY)
    //            {
    //                mv.Top++;
    //            }
    //            if (mv.Top >= bottomY)
    //                back = false;
    //        }



    //        /// <summary>
    //        /// Drops the selected control until it is no longer visible in the form
    //        /// </summary>
    //        /// <param name="mv"></param>
    //        /// <param name="frm"></param>
    //        public void DropDownAnimation(Control mv, Form frm)
    //        {
    //            if (mv.Top < frm.Height)
    //                mv.Top += 4;
    //        }



    //        //public void OpenPanelAnimation()
    //        //{

    //        //}
    //    }
    //}

    #endregion
    #region GameForm.System
    //using LightsOut.Classes;
    //using LightsOut.Classes.Game;
    //using LightsOut.Classes.Game.GamePlay;
    //using LightsOut.Properties;
    //using System;
    //using System.Collections.Generic;
    //using System.Design.Assist;
    //using System.Drawing;
    //using System.Runtime.Remoting.Messaging;
    //using System.Threading.Tasks;
    //using System.Windows.Forms;
    //using global::LightsOut;
    //using System.Security.Cryptography;

    //namespace LightsOut.Forms
    //{
    //    public partial class GameForm : Form // Main Form where the game takes place
    //    {

    //        #region Declaration and Constructors of Form


    //        // Account type identifier; "guest" or "admin"
    //        string identifier;
    //        string GameDifficulty;

    //        Perspective Render;
    //        Perspective Ground;
    //        GameMechanics Mechanics;
    //        Mark Design = new Mark();
    //        A_Admin admin = new A_Admin();
    //        List<Control> keys = new List<Control>();
    //        frmLoadingWindow aLoadingWindow = new frmLoadingWindow("guest");
    //        frmLoadingWindow aLoadingWindow2 = new frmLoadingWindow("admin");

    //        bool gameIsPaused;
    //        bool startCountDown;

    //        HardDifficulty StartGameHard = new HardDifficulty();
    //        EasyDifficulty StartGameEasy = new EasyDifficulty();
    //        MediumDifficulty StartGameMedium = new MediumDifficulty();

    //        int TimeToFinish;
    //        int CollectedKeys;
    //        int lightsOutCount;
    //        int countDownBeforeStart;
    //        int TotalNumOfKeysToCollect;



    //        /// <summary>
    //        /// Generic Microsoft Generated Constructor
    //        /// </summary>
    //        public GameForm() { InitializeComponent(); }


    //        /// <summary>
    //        /// Constructor for Guest Mode
    //        /// </summary>
    //        /// <param name="identifier"></param>
    //        public GameForm(string identifier)
    //        {
    //            InitializeComponent();
    //            this.identifier = identifier;
    //            Design.RoundCorner(e5, 30);
    //            Design.RoundCorner(pnlRenderedScreen, 30);

    //            if (identifier == "guest")
    //            {
    //                GameDifficulty = "EASY";
    //            }
    //        }



    //        /// <summary>
    //        /// Constructor for Admin
    //        /// </summary>
    //        /// <param name="identifier"></param>
    //        /// <param name="admin"></param>
    //        /// <param name="GameDifficulty"></param>
    //        internal GameForm(string identifier, A_Admin admin, string GameDifficulty)
    //        {
    //            InitializeComponent();
    //            this.identifier = identifier;
    //            this.admin = admin;
    //            this.GameDifficulty = GameDifficulty;

    //            Design.RoundCorner(e5, 30);
    //            Design.RoundCorner(pnlRenderedScreen, 30);
    //        }


    //        #endregion


    //        /// <summary>
    //        /// Sets the difficulty of the game, method is called on load to prepare the game before starting
    //        /// </summary>
    //        private void SetDifficulty()
    //        {
    //            switch (GameDifficulty)
    //            {
    //                case "HARD":
    //                    lightsOutCount = StartGameHard.LightsOutTimer;
    //                    TimeToFinish = StartGameHard.TimeToFinish;
    //                    CollectedKeys = StartGameHard.CollectedKeys;
    //                    TotalNumOfKeysToCollect = StartGameHard.TotalNumOfKeysToCollect;
    //                    break;
    //                case "EASY":
    //                    lightsOutCount = StartGameEasy.LightsOutTimer;
    //                    TimeToFinish = StartGameEasy.TimeToFinish;
    //                    CollectedKeys = StartGameEasy.CollectedKeys;
    //                    TotalNumOfKeysToCollect = StartGameEasy.TotalNumOfKeysToCollect;
    //                    break;
    //                case "MEDIUM":
    //                    lightsOutCount = StartGameMedium.LightsOutTimer;
    //                    TimeToFinish = StartGameMedium.TimeToFinish;
    //                    CollectedKeys = StartGameMedium.CollectedKeys;
    //                    TotalNumOfKeysToCollect = StartGameMedium.TotalNumOfKeysToCollect;
    //                    break;
    //            }
    //        }



    //        /// <summary>
    //        /// Checks if it is time for a Lights Out Event
    //        /// </summary>
    //        /// <returns></returns>
    //        private bool LightsOutEventCheck()
    //        {
    //            switch (GameDifficulty)
    //            {
    //                case "HARD":
    //                    StartGameHard.LightsOutTimer = lightsOutCount;
    //                    return StartGameHard.LightsOutEvent();
    //                case "EASY":
    //                    StartGameEasy.LightsOutTimer = lightsOutCount;
    //                    return StartGameEasy.LightsOutEvent();
    //                case "MEDIUM":
    //                    StartGameMedium.LightsOutTimer = lightsOutCount;
    //                    return StartGameMedium.LightsOutEvent();
    //                default: return false;
    //            }
    //        }



    //        /// <summary>
    //        /// Resets the Lights Out Event per Difficulty
    //        /// </summary>
    //        private void ResetLightsOutEventTimer()
    //        {
    //            switch (GameDifficulty)
    //            {
    //                case "HARD":
    //                    StartGameHard.ResetLightsOutEventTimer();
    //                    lightsOutCount = StartGameHard.LightsOutTimer;
    //                    break;
    //                case "EASY":
    //                    StartGameEasy.ResetLightsOutEventTimer();
    //                    lightsOutCount = StartGameEasy.LightsOutTimer;
    //                    break;
    //                case "MEDIUM":
    //                    StartGameMedium.ResetLightsOutEventTimer();
    //                    lightsOutCount = StartGameMedium.LightsOutTimer;
    //                    break;
    //            }
    //        }



    //        /// <summary>
    //        /// Returns the number of Keys to collect depending on what difficulty the game is on
    //        /// </summary>
    //        /// <returns></returns>
    //        private int GetNumberOfKeys()
    //        {
    //            switch (GameDifficulty)
    //            {
    //                case "HARD":
    //                    return StartGameHard.TotalNumOfKeysToCollect;
    //                case "EASY":
    //                    return StartGameEasy.TotalNumOfKeysToCollect;
    //                case "MEDIUM":
    //                    return StartGameMedium.TotalNumOfKeysToCollect;
    //                default: return 0;
    //            }
    //        }


    //        // random integer container
    //        int ran;

    //        /// <summary>
    //        /// Randomize the Keys to different locations
    //        /// </summary>
    //        private void RandomizeColliderLocation()
    //        {
    //            Random ran = new Random();

    //            for (int i = 0; i < GetNumberOfKeys(); i++)
    //            {
    //                this.ran = ran.Next(0, 14);
    //                keys[this.ran].Show();
    //            }
    //        }



    //        /// <summary>
    //        /// Game Load Method
    //        /// </summary>
    //        /// <param name="sender"></param>
    //        /// <param name="e"></param>
    //        private void GameLoad(object sender, EventArgs e)
    //        {
    //            //ForDebuggingOnly();
    //            foreach (Control keys in pnlMiniMapHard.Controls)
    //            {
    //                if (keys.AccessibleDescription == "keys")
    //                {
    //                    keys.Hide();
    //                }
    //            }


    //            #region Keys Region
    //            keys.Add(k1);
    //            keys.Add(k2);
    //            keys.Add(k3);
    //            keys.Add(k4);
    //            keys.Add(k5);
    //            keys.Add(k6);
    //            keys.Add(k7);
    //            keys.Add(k8);
    //            keys.Add(k9);
    //            keys.Add(k10);
    //            keys.Add(k11);
    //            keys.Add(k12);
    //            keys.Add(k13);
    //            keys.Add(k14);
    //            keys.Add(k15);
    //            #endregion

    //            // Initialize Mechanics and Ground
    //            Mechanics = new GameMechanics(characterEntity, admin, playerDot, pnlMechanicsHard, pnlMiniMapHard);
    //            Ground = new Perspective(pnlMechanicsHard, characterEntity);

    //            #region Render Declaration
    //            Render = new Perspective
    //                (
    //                    Mechanics.set1,
    //                    Mechanics.set2,
    //                    Mechanics.set3,
    //                    Mechanics.set4,
    //                    Mechanics.set5,
    //                    Mechanics.set7,
    //                    Mechanics.set8,
    //                    Mechanics.set9,
    //                    Mechanics.set10,
    //                    Mechanics.set11,
    //                    Mechanics.set12,
    //                    Mechanics.set13,
    //                    Mechanics.set14,
    //                    admin,
    //                    pnlRenderedScreen,
    //                    Mechanics
    //                );
    //            #endregion


    //            // Apply Difficulty
    //            SetDifficulty();

    //            // Set lights out panel
    //            lightsOutEvent.BringToFront();
    //            lightsOutEvent.Hide();
    //            lightsOutEvent.Location = new Point(Width / 2 - lightsOutEvent.Width / 2, Height / 2 - lightsOutEvent.Height / 2);

    //            countDownBeforeStart = 10;
    //            pnlMiniMapHard.Location = new Point(40, 460);
    //            pnlRenderedScreen.Location = new Point(22, 22);

    //            Mechanics.finishedLoading = true;
    //            ColliderMovementTimer.Start();
    //            Enabled = true;
    //            Focus();

    //            // Set In-Game UI Design Point Values
    //            e5.Location = new Point(Width / 2 - (e5.Width / 2), Height / 2 - (e5.Height / 2));
    //            pnlStatus.Left = pnlMiniMapHard.Left + pnlMiniMapHard.Width;
    //            pnlStatus.Top = pnlMiniMapHard.Top + pnlMiniMapHard.Height - pnlStatus.Height;

    //            // prepare on load
    //            lblCountDown.Show();
    //            lblGameStartsIn.Show();
    //            lblGameStartsIn.Location = new Point(440, 308);

    //            // Set Countdown Point Values
    //            lblCountDown.Left = lblGameStartsIn.Left + lblGameStartsIn.Width;
    //            lblCountDown.Top = lblGameStartsIn.Top;

    //            // Stop Movement Related Timers
    //            ColliderMovementTimer.Stop();
    //            PlayerMovementTimer.Stop();
    //            ColliderPositionTracker.Stop();


    //            // pause game
    //            gameIsPaused = true;


    //            // set all colliders to arrange before game start
    //            Mechanics.SetColliders(1, g1, g2, g3, g4, g5); // set 1
    //            Mechanics.SetColliders(2, b1, b2, b3, b4, b5); // set 2
    //            Mechanics.SetColliders(3, m1, m2, m3, m4, m5); // set 3
    //            Mechanics.SetColliders(4, r1, r2, r3, r4, r5); // set 4
    //            Mechanics.SetColliders(5, y1, y2, y3, y4, y5); // set 5

    //            Mechanics.SetColliders(7, dp1, dp2, dp3, dp4, dp5); // set 7
    //            Mechanics.SetColliders(8, s1, s2, s3, s4, s5); // set 8
    //            Mechanics.SetColliders(9, t1, t2, t3, t4, t5); // set 9
    //            Mechanics.SetColliders(10, d1, d2, d3, d4, d5); // set 10

    //            Mechanics.SetColliders(11, br1, br2, br3, br4, br5); // set 11
    //            Mechanics.SetColliders(12, mb1, mb2, mb3, mb4, mb5); // set 12
    //            Mechanics.SetColliders(13, o1, o2, o3, o4, o5); // set 13
    //            Mechanics.SetColliders(14, bl1, bl2, bl3, bl4, bl5); // set 14

    //            #region Walls
    //            Render.Walls
    //                (
    //                wall1,
    //                wall2,
    //                wall3,
    //                wall4,
    //                wall5,
    //                wall6,
    //                wall7,
    //                wall8,
    //                wall9,
    //                wall10,
    //                wall11,
    //                wall12,
    //                wall13,
    //                wall14,
    //                wall15,
    //                wall16,
    //                wall17,
    //                wall18,
    //                wall19,
    //                wall20,
    //                wall21,
    //                wall22,
    //                wall23,
    //                wall24,
    //                wall25,
    //                wall26,
    //                wall27,
    //                wall28,
    //                wall29,
    //                wall30,
    //                wall31,
    //                wall32,
    //                wall33,
    //                wall34,
    //                wall35,
    //                wall36,
    //                wall37,
    //                wall37,
    //                wall39,
    //                wall40,
    //                wall41
    //                );
    //            #endregion


    //            // applies the selected color mode
    //            Perspective getColor = new Perspective();
    //            foreach (Control ctr in pnlRenderedScreen.Controls)
    //            {
    //                Color set = Color.FromArgb(40, 40, 40);
    //                if (ctr.AccessibleDescription != "depth0")
    //                    ctr.BackColor = set;


    //                // changing the color when the player chooses a color
    //                if (ctr.AccessibleDescription == "WALLS")
    //                    ctr.BackColor = getColor.ApplySelectedTheme(admin.selectedTheme, 6);



    //                if (ctr.AccessibleName == "ground")
    //                    ctr.Visible = false;
    //            }

    //            // Hide End-Game Score Result screen
    //            e5.Hide();
    //            startCountDown = true;

    //            // Load game after preparation
    //            Mechanics.LoadGame(this);
    //            lblKC.ForeColor = lblResultsHeader.ForeColor = getColor.ApplySelectedTheme(admin.selectedTheme, 5);
    //            keyss.ForeColor = scoree.ForeColor = lblScr.ForeColor = getColor.ApplySelectedTheme(admin.selectedTheme, 5);


    //            RandomizeColliderLocation(); // random enemy location (?)
    //                                         //ForDebuggingOnly();
    //        }



    //        /// <summary>
    //        /// This Method is called during debugging the colliders methods and other functions,
    //        /// to check errors and to test functionalities during new implementations
    //        /// </summary>
    //        private void ForDebuggingOnly() // should have 0 references during actual game load
    //        {
    //            foreach (Control panels in Controls)
    //            {
    //                if (panels.AccessibleName == "maps")
    //                {
    //                    panels.BringToFront();
    //                    foreach (Control panel in panels.Controls)
    //                        if (panel.AccessibleName == "ground")
    //                            panel.Hide();
    //                }
    //            }

    //            pnlMechanicsHard.Location = new Point(0, 0);
    //            lblGameStartsIn.Left = pnlMiniMapHard.Left = pnlMechanicsHard.Left;
    //            pnlMiniMapHard.Location = new Point(0, pnlMechanicsHard.Height);
    //            lblGameStartsIn.Top = pnlMiniMapHard.Top + lblGameStartsIn.Height;

    //            pnlMechanicsHard.BringToFront();
    //            pnlMechanicsHard.Show();
    //            pnlStatus.Left = Width - pnlStatus.Width;
    //            pnlStatus.Top = 0;
    //        }


    //        private void EndGame()
    //        {
    //            //hide some and stop some
    //            pnlMiniMapHard.Hide();
    //            pnlStatus.Hide();
    //            PlayerMovementTimer.Stop();
    //            ColliderPositionTracker.Stop();
    //            PlayerMovementTimer.Stop();
    //            GroundDisplayRenderer.Stop();
    //            DisplayOnScreenRendererTimer.Stop();

    //            // store score value
    //            int scoreFinal = GetScore();
    //            gameIsPaused = true;

    //            if (admin.GameStatus == "unfinished")
    //            {
    //                // store score value
    //                scoreFinal = 100 * CollectedKeys;
    //            }
    //            else
    //                admin.GameStatus = "completed game";

    //            // display score
    //            scoree.Text = scoreFinal.ToString();
    //            admin.score = scoreFinal;
    //            keyss.Text = $"{CollectedKeys}/{TotalNumOfKeysToCollect}";
    //        }



    //        /// <summary>
    //        /// Releases the Resources in the Form (" StackOverFlowException " : after multiple attempts in the game)
    //        /// </summary>
    //        void Release() // fixed the StackOverflowException with this
    //        {
    //            foreach (Control c in Controls)
    //                this.Controls.Remove(c);

    //            Resources.ResourceManager.ReleaseAllResources();
    //            Dispose(true);
    //        }



    //        // Key Press Method
    //        private void KeyIsPressed(object sender, KeyPressEventArgs e)
    //        {
    //            //R a a e Q D
    //            //; 10 U ; ; ;
    //            if (e.KeyChar == 'c') // press c to exit
    //            {
    //                Release();
    //                admin.score = 10;
    //                admin.GameStatus = "unfinished";
    //                EndGame();
    //                QuitGame();
    //                DisplayLoadingWindow(identifier, admin);
    //            }
    //        }


    //        // Loading Window/Form Method
    //        private void DisplayLoadingWindow(string identifier, A_Admin admin)
    //        {
    //            #region Private Definintion
    //            void LaunchLoadingForGuestUI()
    //            {
    //                Release();
    //                aLoadingWindow = new frmLoadingWindow("guest");
    //                Hide();
    //                aLoadingWindow.Show();
    //                aLoadingWindow.Enabled = true;
    //            }

    //            void LaunchLoadingForAdminUI()
    //            {
    //                Release();
    //                admin.datePlayed = DateTime.Now;
    //                admin.GameStatus = GetGameStatus();
    //                aLoadingWindow2 = new frmLoadingWindow("admin", admin, true);
    //                Hide();
    //                aLoadingWindow2.Show();
    //                aLoadingWindow2.Enabled = true;
    //            }
    //            #endregion

    //            switch (identifier)
    //            {
    //                case "guest": LaunchLoadingForGuestUI(); break;
    //                case "admin": LaunchLoadingForAdminUI(); break;
    //            }

    //        }


    //        #region Go To Methods (Timer, Event Checker)
    //        private void ColliderPosTrack(object sender, EventArgs e) => Mechanics.Tracker();
    //        private void MiniMapRender(object sender, EventArgs e) => Mechanics.RenderMiniMap();
    //        private void KeyIsDown(object sender, KeyEventArgs e) => Mechanics.KeyDownMethod(sender, e);
    //        private void KeyIsReleased(object sender, KeyEventArgs e) => Mechanics.KeyUpMethod(sender, e);
    //        private void PlayerMovementTime(object sender, EventArgs e) => Mechanics.PlayerMovement(pnlMechanicsHard);
    //        #endregion




    //        // Collider Movement Method, responsible for rotating the methods clock wise and counter clock wise
    //        private void ColliderMovement(object sender, EventArgs e)
    //        {
    //            // Difference between the first collider and the character
    //            int GetTheDifferenceOfX = m1.Location.X - Mechanics.character.Location.X;
    //            int GetTheDifferenceOfY = Mechanics.character.Location.Y - m1.Location.Y;

    //            Mechanics.diffX = GetTheDifferenceOfX;
    //            Mechanics.diffY = GetTheDifferenceOfY;

    //            for (int i = 0; i < 6; i++)
    //                Mechanics.MovementForColliders();

    //        }



    //        // Render Screen Method for timer
    //        private void RenderScreen(object sender, EventArgs e)
    //        {
    //            #region A series of repetetive code unfit for human eyes

    //            // Responsible for leading the display of the game
    //            #region Main screen area for render
    //            Render.RenderPerspectiveMainScreenArea("1", Render.set7);
    //            Render.RenderPerspectiveMainScreenArea("2", Render.set7);
    //            Render.RenderPerspectiveMainScreenArea("3", Render.set7);

    //            Render.RenderPerspectiveMainScreenArea("4", Render.set8);
    //            Render.RenderPerspectiveMainScreenArea("5", Render.set8);
    //            Render.RenderPerspectiveMainScreenArea("6", Render.set8);
    //            Render.RenderPerspectiveMainScreenArea("7", Render.set8);
    //            Render.RenderPerspectiveMainScreenArea("8", Render.set8);

    //            Render.RenderPerspectiveMainScreenArea("9", Render.set9);
    //            Render.RenderPerspectiveMainScreenArea("10", Render.set9);
    //            Render.RenderPerspectiveMainScreenArea("11", Render.set9);

    //            Render.RenderPerspectiveMainScreenArea("12", Render.set10);
    //            Render.RenderPerspectiveMainScreenArea("13", Render.set10);
    //            Render.RenderPerspectiveMainScreenArea("14", Render.set10);

    //            Render.RenderPerspectiveMainScreenArea("15", Render.set1);
    //            Render.RenderPerspectiveMainScreenArea("16", Render.set1);

    //            Render.RenderPerspectiveMainScreenArea("17", Render.set2);

    //            Render.RenderPerspectiveMainScreenArea("18", Render.set2);

    //            Render.RenderPerspectiveMainScreenArea("19", Render.set3);
    //            Render.RenderPerspectiveMainScreenArea("20", Render.set3);
    //            Render.RenderPerspectiveMainScreenArea("21", Render.set3);// center collider
    //            Render.RenderPerspectiveMainScreenArea("22", Render.set3);
    //            Render.RenderPerspectiveMainScreenArea("23", Render.set3);

    //            Render.RenderPerspectiveMainScreenArea("24", Render.set4);

    //            Render.RenderPerspectiveMainScreenArea("25", Render.set4);

    //            Render.RenderPerspectiveMainScreenArea("26", Render.set5);
    //            Render.RenderPerspectiveMainScreenArea("27", Render.set5);

    //            Render.RenderPerspectiveMainScreenArea("28", Render.set11);
    //            Render.RenderPerspectiveMainScreenArea("29", Render.set11);
    //            Render.RenderPerspectiveMainScreenArea("30", Render.set11);

    //            Render.RenderPerspectiveMainScreenArea("31", Render.set12);
    //            Render.RenderPerspectiveMainScreenArea("32", Render.set12);
    //            Render.RenderPerspectiveMainScreenArea("33", Render.set12);

    //            Render.RenderPerspectiveMainScreenArea("34", Render.set13);
    //            Render.RenderPerspectiveMainScreenArea("35", Render.set13);
    //            Render.RenderPerspectiveMainScreenArea("36", Render.set13);
    //            Render.RenderPerspectiveMainScreenArea("37", Render.set13);
    //            Render.RenderPerspectiveMainScreenArea("38", Render.set13);

    //            Render.RenderPerspectiveMainScreenArea("39", Render.set14);
    //            Render.RenderPerspectiveMainScreenArea("40", Render.set14);
    //            Render.RenderPerspectiveMainScreenArea("41", Render.set14);

    //            e1.BackColor = Render.AddThemeColor(0);
    //            e2.BackColor = Render.AddThemeColor(1);
    //            e3.BackColor = Render.AddThemeColor(2);
    //            e4.BackColor = Render.AddThemeColor(3);
    //            e5.BackColor = Render.AddThemeColor(4);

    //            btnExitGame.BackColor = Render.AddThemeColor(5);

    //            #endregion Main screen area for render

    //            // Responsible for properly displaying the walls
    //            #region PerspectiveStretch
    //            foreach (Panel pixel in pnlRenderedScreen.Controls)
    //            {
    //                if (pixel.AccessibleDescription == "depth0")
    //                {
    //                    Render.RenderPerspectiveForGroundAndCeiling(pixel);
    //                }
    //            }
    //            #endregion PerspectiveStretch

    //            #endregion A series of repetetive code unfit for human eyes
    //        }



    //        // Keeps the player on the Ground Controls
    //        private void KeepPlayerOnGround(object sender, EventArgs e)
    //        {
    //            #region StillOnGround();

    //            foreach (Control ground in pnlMechanicsHard.Controls)
    //            {
    //                if (ground.AccessibleName == "ground")
    //                    Ground.StillOnGround(ground);
    //            }

    //            #endregion StillOnGround();
    //        }




    //        // Method for removing the Vision of the player (Blinking Lights Effect)
    //        private void PlayerNoVision()
    //        {
    //            foreach (Control pix in pnlRenderedScreen.Controls)
    //            {
    //                pix.BackColor = Color.Black;
    //            }
    //        }




    //        // Returns the score of the game
    //        private int GetScore()
    //        {
    //            switch (GameDifficulty)
    //            {
    //                case "HARD": return (StartGameHard.TimeToFinish) - StartGameHard.TimeFinished + (StartGameHard.StartingScore - (StartGameHard.TotalNumOfKeysToCollect));
    //                case "EASY": return (StartGameEasy.TimeToFinish) - StartGameEasy.TimeFinished + (StartGameEasy.StartingScore - (StartGameEasy.TotalNumOfKeysToCollect));
    //                case "MEDIUM": return (StartGameMedium.TimeToFinish) - StartGameMedium.TimeFinished + (StartGameMedium.StartingScore - (StartGameMedium.TotalNumOfKeysToCollect));
    //                default:
    //                    return 0;
    //            }
    //        }




    //        // Quit and Compute
    //        private void QuitGame()
    //        {
    //            switch (GameDifficulty)
    //            {
    //                case "HARD": StartGameHard.CalculateScoreCompleted(); break;
    //                case "EASY": StartGameEasy.CalculateScoreCompleted(); break;
    //                case "MEDIUM": StartGameMedium.CalculateScoreCompleted(); break;
    //                default:
    //                    break;
    //            }
    //        }





    //        // Add numOfKeys
    //        private void AddKeysToCollection()
    //        {
    //            switch (GameDifficulty)
    //            {
    //                case "HARD": StartGameHard.CollectedKeys++; break;
    //                case "EASY": StartGameEasy.CollectedKeys++; break;
    //                case "MEDIUM": StartGameMedium.CollectedKeys++; break;
    //                default:
    //                    break;
    //            }
    //        }





    //        // Returns the number of keys to be collected
    //        private int KeysToBeCollected()
    //        {
    //            switch (GameDifficulty)
    //            {
    //                case "HARD": return StartGameHard.TotalNumOfKeysToCollect;
    //                case "EASY": return StartGameEasy.TotalNumOfKeysToCollect;
    //                case "MEDIUM": return StartGameMedium.TotalNumOfKeysToCollect;
    //                default:
    //                    return 0;
    //            }
    //        }




    //        // Get current amount of keys collected by the player
    //        private int GetCurrentCollectedKeys()
    //        {
    //            switch (GameDifficulty)
    //            {
    //                case "HARD": return StartGameHard.CollectedKeys;
    //                case "EASY": return StartGameEasy.CollectedKeys;
    //                case "MEDIUM": return StartGameMedium.CollectedKeys;
    //                default:
    //                    return 0;
    //            }
    //        }





    //        // Returns the Game Status: "unfinished"
    //        private string GetGameStatus()
    //        {
    //            switch (GameDifficulty)
    //            {
    //                case "HARD": StartGameHard.ChooseToExitGameUnfinished(); return StartGameHard.GameStatus;
    //                case "EASY": StartGameEasy.ChooseToExitGameUnfinished(); return StartGameEasy.GameStatus;
    //                case "MEDIUM": StartGameMedium.ChooseToExitGameUnfinished(); return StartGameMedium.GameStatus;
    //                default:
    //                    return "";
    //            }
    //        }




    //        // Main
    //        private async void MainTimerForGameplay(object sender, EventArgs e)
    //        {
    //            // Check for Collision with keys
    //            foreach (Control keys in keys)
    //            {
    //                if (playerDot.Bounds.IntersectsWith(keys.Bounds) && keys.Visible == true)
    //                {
    //                    keys.Visible = false;
    //                    AddKeysToCollection();
    //                }
    //            }


    //            // Check if the player has exited the maze (since the maze exit is at x = 0)
    //            if (characterEntity.Top < 0)
    //            {
    //                admin.GameStatus = "completed";
    //                EndGame();
    //                foreach (Control c in pnlRenderedScreen.Controls)
    //                {
    //                    c.BackColor = Color.Black;
    //                }
    //                e5.Enabled = true;

    //                e5.Show();
    //            }

    //            // lights out event
    //            if (LightsOutEventCheck())
    //            {
    //                gameIsPaused = true;
    //                pnlMiniMapHard.Hide();
    //                pnlStatus.Hide();
    //                lightsOutEvent.BringToFront();
    //                lightsOutEvent.Show();
    //                PlayerNoVision();

    //                await Task.Delay(5000); // 5 seconds
    //                lightsOutEvent.Hide();

    //                ResetLightsOutEventTimer();
    //                gameIsPaused = false;
    //            }



    //            // Continue if game is not paused
    //            if (!gameIsPaused)
    //            {
    //                pnlMiniMapHard.Show();
    //                pnlStatus.Show();
    //                lightsOutEvent.Hide();
    //                ColliderMovementTimer.Start();
    //                ColliderPositionTracker.Start();
    //                PlayerMovementTimer.Start();
    //                GroundDisplayRenderer.Start();
    //                DisplayOnScreenRendererTimer.Start();

    //                lblLightsOutCount.Text = (lightsOutCount--).ToString() + 's';
    //                lblTimeRemaining.Text = (TimeToFinish--).ToString() + 's';
    //                CollectedKeys = GetCurrentCollectedKeys();
    //                TotalNumOfKeysToCollect = KeysToBeCollected();

    //                lblKeysCollected.Text = $"{CollectedKeys}/{TotalNumOfKeysToCollect}";

    //                if (TimeToFinish <= 0)
    //                {
    //                    await Task.Delay(100);
    //                    e5.Show();
    //                }
    //            }
    //            else // game is paused
    //            {
    //                pnlMiniMapHard.Hide();
    //                pnlStatus.Hide();
    //                PlayerMovementTimer.Stop();
    //                ColliderPositionTracker.Stop();
    //                PlayerMovementTimer.Stop();
    //                GroundDisplayRenderer.Stop();
    //                DisplayOnScreenRendererTimer.Stop();
    //            }



    //            // Count down begins on load because of the bool true on load
    //            if (startCountDown)
    //            {
    //                // color red
    //                if (countDownBeforeStart < 4)
    //                    lblCountDown.ForeColor = Color.Red;

    //                // decrement till 0
    //                if (countDownBeforeStart > 0)
    //                    lblCountDown.Text = (countDownBeforeStart--).ToString();
    //                else // finished count
    //                {
    //                    lblCountDown.Hide();
    //                    lblGameStartsIn.Hide();
    //                    gameIsPaused = false;
    //                    startCountDown = false;
    //                }
    //            }
    //        }



    //        // Exit game 
    //        private void btnExitGame_Click(object sender, EventArgs e)
    //        {
    //            admin.GameStatus = "COMPLETED";
    //            DisplayLoadingWindow(identifier, admin);
    //        }
    //    }
    //}

    #endregion
    #region HomePage.System
    //using LightsOut.Classes;
    //using LightsOut.Classes.Game.GamePlay;
    //using LightsOut.Classes.Homepage;
    //using LightsOut.Forms;
    //using System;
    //using System.Design.Assist;
    //using System.Drawing;
    //using System.Security.Cryptography.X509Certificates;
    //using System.Windows.Forms;
    //using global::LightsOut.Classes.Homepage;
    //using global::LightsOut.Forms;
    //using global::LightsOut;
    //using System.Runtime.InteropServices.ComTypes;
    //using System.Security.Cryptography;

    //namespace LightsOut
    //{
    //    internal partial class frmHomePage : Form
    //    {
    //        // Home page class members initialization
    //        private string nameofAdmin, dateJoined, age, username, gender;
    //        private string identifier;
    //        private string selectedTheme;
    //        private Point locationForDifficultyMenu;
    //        private string GameStatus;


    //        //color1 theme yellow
    //        Color yellow1 = Color.FromArgb(255, 186, 59);


    //        Mark Design = new Mark();
    //        A_Admin admin = new A_Admin();
    //        FadePanel fade = new FadePanel();
    //        Animate Animation = new Animate();
    //        BaseClassHomePage _homePage = new BaseClassHomePage();
    //        HardDifficulty hardGame = new HardDifficulty();
    //        EasyDifficulty easyGame = new EasyDifficulty();
    //        MediumDifficulty mediumGame = new MediumDifficulty();

    //        bool addHistory;
    //        string GameDifficulty;

    //        // Button behavior
    //        Color hover1 = Color.HotPink;
    //        Color hover2 = Color.Orange;
    //        Color leave = Color.FromArgb(255, 248, 220);




    //        /// <summary>
    //        /// Default Constructor
    //        /// </summary>
    //        public frmHomePage() { InitializeComponent(); }





    //        /// <summary>
    //        /// Custom contrsuctor for passing identifier
    //        /// </summary>
    //        /// <param name="identifier"></param>
    //        public frmHomePage(string identifier)
    //        {
    //            InitializeComponent();
    //            this.identifier = identifier;
    //        }




    //        /// <summary>
    //        /// Constructor for passing admin name
    //        /// </summary>
    //        /// <param name="identifier"></param>
    //        /// <param name="admin"></param>
    //        public frmHomePage(string identifier, A_Admin admin)
    //        {
    //            InitializeComponent();
    //            this.identifier = identifier;
    //            this.admin = admin;
    //            nameofAdmin = admin.Name;
    //            dateJoined = admin.joinedDate;
    //            age = admin.age;
    //            username = admin.Username;
    //            gender = admin.gender;
    //            selectedTheme = admin.selectedTheme;
    //            Design.RoundCorner(pnlGamesPlayed, 20);

    //        }



    //        /// <summary>
    //        /// Constructor for passing admin name
    //        /// </summary>
    //        /// <param name="identifier"></param>
    //        /// <param name="admin"></param>
    //        public frmHomePage(string identifier, A_Admin admin, bool pass)
    //        {
    //            InitializeComponent();
    //            this.identifier = identifier;
    //            this.admin = admin;
    //            nameofAdmin = admin.Name;
    //            dateJoined = admin.joinedDate;
    //            age = admin.age;
    //            username = admin.Username;
    //            gender = admin.gender;
    //            selectedTheme = admin.selectedTheme;

    //            Design.RoundCorner(pnlGamesPlayed, 20);
    //            GameStatus = admin.GameStatus;


    //            addHistory = pass;
    //        }



    //        /// <summary>
    //        /// Timer for animation during first load up of the form
    //        /// </summary>
    //        /// <param name="sender"></param>
    //        /// <param name="e"></param>
    //        private void animationOnStart(object sender, EventArgs e)
    //        {
    //            Animation.RightToLeftAnimationFour(vm1, vm2, vm3, vm4, FindForm());
    //            Animation.LeftToRightAnimationFour(mv1, mv2, mv3, mv4);
    //            Animation.DropDownAnimation(pnlAnimate, FindForm());
    //            Animation.HeaderAnimation(pnlHeader, FindForm());
    //            Animation.UpDownLoopAnimation(lblguestMode);
    //        }


    //        /// <summary>
    //        /// Home page load up, sets values of variables and sets the panels
    //        /// to their respective positions in the form during load up
    //        /// </summary>
    //        /// <param name="sender"></param>
    //        /// <param name="e"></param>
    //        private void frmHomePage_Load(object sender, EventArgs e)
    //        {
    //            if (!addHistory) { /**/ }
    //            else
    //                scoreHistory.Text += $"Score: {admin.score} || Date and Time: {admin.datePlayed} || {GameStatus}\n";

    //            // Set values on load up
    //            pnlOptionsPage.Visible = false;
    //            pnlProfilePage.Visible = false;
    //            pnlAboutPage.Visible = false;
    //            pnlHowToPlay.Visible = false;

    //            // Panel locations preparation on load
    //            pnlGuestLogIn.Location = new Point(526, 379);
    //            pnlAdminLogin.Location = new Point(540, 322);
    //            lblguestMode.Location = new Point(625, 323);
    //            pnlAnimate.Location = new Point(532, 280);
    //            pnlHeader.Location = new Point(538, -300);
    //            pnlOptionsPage.Location = new Point(0, 0);
    //            pnlProfilePage.Location = new Point(0, 0);
    //            pnlAboutPage.Location = new Point(0, 0);



    //            // Left side panels
    //            mv1.Location = new Point(0 - mv1.Width, 0);
    //            mv2.Location = new Point(0 - mv2.Width, 0);
    //            mv3.Location = new Point(0 - mv3.Width, 0);
    //            mv4.Location = new Point(0 - mv4.Width, 0);




    //            // Right side panels
    //            vm1.Location = new Point(this.Width, 0);
    //            vm2.Location = new Point(this.Width, 0);
    //            vm3.Location = new Point(this.Width, 0);
    //            vm4.Location = new Point(this.Width, 0);




    //            // Arrange menus 
    //            foreach (Control c in this.Controls)
    //                if ((string)c.AccessibleDescription == "menus")
    //                    c.SendToBack();




    //            // Arrange buttons to SendToBack so that the buttons will be behind the panels
    //            foreach (Control button in this.Controls)
    //                if (button.AccessibleDescription == "buttonshehe")
    //                    button.SendToBack();




    //            // form size: 1519, 818


    //            // location for difficulty menu
    //            int xForm = (int)Math.Floor(Width / 2.0);
    //            int yForm = (int)Math.Floor(Height / 2.0);

    //            int xMenu = (int)Math.Floor(pnlDifficultyChoice.Width / 2.0);
    //            int yMenu = (int)Math.Floor(pnlDifficultyChoice.Height / 2.0);

    //            locationForDifficultyMenu = new Point(xForm - xMenu, yForm - yMenu);
    //            pnlDifficultyChoice.Location = locationForDifficultyMenu;
    //            pnlDifficultyChoice.BringToFront();
    //            pnlDifficultyChoice.Hide();

    //            pnlColor6.BackColor = Color.FromArgb(255, 160, 36);

    //            if (identifier == "guest")
    //            {
    //                // Guest UI display
    //                btnOptionsExit.BackColor = Color.FromArgb(84, 14, 55);
    //                lblTitle.ForeColor = Color.FromArgb(250, 155, 236);
    //                this.BackColor = Color.FromArgb(5, 20, 18);

    //                pnlop1.BackColor = Color.FromArgb(237, 31, 210);
    //                pnlop2.BackColor = Color.FromArgb(176, 37, 158);
    //                pnlop3.BackColor = Color.FromArgb(143, 36, 129);
    //                pnlop4.BackColor = Color.FromArgb(115, 30, 104);

    //                mv1.BackColor = Color.FromArgb(237, 31, 210);
    //                mv2.BackColor = Color.FromArgb(176, 37, 158);
    //                mv3.BackColor = Color.FromArgb(143, 36, 129);
    //                mv4.BackColor = Color.FromArgb(115, 30, 104);

    //                vm1.BackColor = Color.FromArgb(237, 31, 210);
    //                vm2.BackColor = Color.FromArgb(176, 37, 158);
    //                vm3.BackColor = Color.FromArgb(143, 36, 129);
    //                vm4.BackColor = Color.FromArgb(115, 30, 104);

    //                pnlAdminLogin.Visible = false;
    //                pnlAdminLogin.Enabled = false;
    //                pnlGuestLogIn.Visible = true;
    //                pnlGuestLogIn.Enabled = true;
    //                lblguestMode.Visible = true;

    //                lc1.Enabled = false;
    //                lc2.Enabled = false;
    //                lc3.Enabled = false;
    //                lc4.Enabled = false;
    //                lc5.Enabled = false;
    //                lc6.Enabled = false;
    //                lc7.Enabled = false;
    //                lc8.Enabled = false;

    //                pnlColor1.Enabled = false;
    //                pnlColor2.Enabled = false;
    //                pnlColor3.Enabled = false;
    //                pnlColor4.Enabled = false;
    //                pnlColor5.Enabled = false;
    //                pnlColor6.Enabled = false;
    //                pnlColor7.Enabled = false;
    //                pnlColor8.Enabled = false;
    //            }
    //            else if (identifier == "admin")
    //            {
    //                // Admin UI display
    //                pnlGuestLogIn.Enabled = false;
    //                pnlGuestLogIn.Visible = false;
    //                pnlAdminLogin.Visible = true;
    //                pnlAdminLogin.Enabled = true;
    //                lblguestMode.Visible = false;

    //                lblPleaseLoginn.Visible = false;

    //                lc1.Visible = true;
    //                lc2.Visible = false;
    //                lc3.Visible = false;
    //                lc4.Visible = false;
    //                lc5.Visible = false;
    //                lc6.Visible = false;
    //                lc7.Visible = false;
    //                lc8.Visible = false;

    //                pnlColor1.Visible = true;
    //                pnlColor2.Visible = true;
    //                pnlColor3.Visible = true;
    //                pnlColor4.Visible = true;
    //                pnlColor5.Visible = true;
    //                pnlColor6.Visible = true;
    //                pnlColor7.Visible = true;
    //                pnlColor8.Visible = true;

    //                lblColormodee.Visible = true;

    //                SetTheme();
    //            }


    //            // About page text on load
    //            lblAbouttxt.Text = _homePage.AboutPageTextDisplay();
    //        }



    //        private void ShowDifficultyOptions()
    //        {
    //            pnlDifficultyChoice.Show();
    //        }
    //        // Defining methods for some buttons




    //        /// <summary>
    //        /// Start Game method, takes 1 argument to identify if the player about to play is an admin or guest
    //        /// </summary>
    //        /// <param name="identifier"></param>
    //        private void StartGame(string identifier)
    //        {
    //            if (identifier == "guest")
    //            {
    //                GameForm game = new GameForm("guest");
    //                try
    //                {
    //                    this.Hide();
    //                    game.Show();
    //                }
    //                catch (System.ComponentModel.Win32Exception) { game.Dispose(); }
    //            }
    //            else if (identifier == "admin")
    //            {
    //                GameForm game1 = new GameForm("admin", admin, GameDifficulty);
    //                try
    //                {
    //                    this.Hide();
    //                    game1.Show();
    //                }
    //                catch (System.ComponentModel.Win32Exception) { game1.Dispose(); }
    //            }
    //        }




    //        private void btnStartHardOptionClickEvent(object sender, EventArgs e)
    //        {
    //            GameDifficulty = hardGame.ReturnGameType();
    //            StartGame("admin");
    //        }


    //        private void StartEasyGame(object sender, EventArgs e)
    //        {
    //            GameDifficulty = easyGame.ReturnGameType();
    //            StartGame("admin");
    //        }


    //        /// <summary>
    //        /// Method for getting the About the page
    //        /// </summary>
    //        private void GoToAboutPage()
    //        {
    //            pnlAboutPage.BringToFront();
    //            pnlAboutPage.Show();
    //        }





    //        /// <summary>
    //        /// Exit to Log in page, can be used in both guest account type and admin account type
    //        /// </summary>
    //        private void ExitTo()
    //        {
    //            frmLogInForm login = new frmLogInForm("admin", admin) { Enabled = true };
    //            this.Enabled = false;
    //            login.Show();
    //            this.Hide();
    //        }



    //        // Homepage buttons
    //        private void btnLogOut_Click(object sender, EventArgs e) => ExitTo();
    //        private void btnExitGuest_Click(object sender, EventArgs e) => ExitTo();
    //        private void btnPlayAsGuest_Click(object sender, EventArgs e) => StartGame("guest");
    //        private void btnOptions_Click(object sender, EventArgs e) => pnlOptionsPage.Show();
    //        private void btnExit_Click(object sender, EventArgs e) => pnlAboutPage.Hide();
    //        private void btnOptionsExit_Click(object sender, EventArgs e) => pnlOptionsPage.Hide();

    //        private void btnStartGame_Click(object sender, EventArgs e)
    //        {
    //            pnlDifficultyChoice.Show();

    //            //StartGame("admin"); 
    //        }


    //        private void SetTheme()
    //        {
    //            switch (admin.selectedTheme)
    //            {
    //                case "yellow":
    //                    Color yellow1 = Color.FromArgb(255, 186, 59);
    //                    Color yellow2 = Color.FromArgb(209, 138, 38);
    //                    Color yellow3 = Color.FromArgb(179, 119, 36);
    //                    Color yellow4 = Color.FromArgb(156, 94, 33);
    //                    Color yellow5 = Color.FromArgb(20, 20, 20);
    //                    Color firebrick = Color.Firebrick;

    //                    btnOptionsExit.BackColor = Color.Firebrick;
    //                    btnExitToHomeFromProfile.BackColor = Color.Firebrick;
    //                    btnExitToHomeFromProfile.BackgroundImage = null;

    //                    pnlDifficultyChoice.BackColor = yellow1;
    //                    pfp1.BackColor = yellow1;
    //                    pnlop1.BackColor = yellow1;
    //                    vm1.BackColor = yellow1;
    //                    mv1.BackColor = yellow1;
    //                    ps0.BackColor = yellow1;
    //                    scoreHistory.BackColor = yellow1;

    //                    pnlDifficultyBorder1.BackColor = yellow2;
    //                    pfp5.BackColor = yellow2;
    //                    pfp2.BackColor = yellow2;
    //                    pnlop2.BackColor = yellow2;
    //                    vm2.BackColor = yellow2;
    //                    mv2.BackColor = yellow2;
    //                    ps1.BackColor = yellow2;

    //                    pnlDifficultyBorder2.BackColor = yellow3;
    //                    pfp6.BackColor = yellow3;
    //                    pfp3.BackColor = yellow3;
    //                    pnlop3.BackColor = yellow3;
    //                    vm3.BackColor = yellow3;
    //                    mv3.BackColor = yellow3;
    //                    ps3.BackColor = yellow3;

    //                    pnlProfilePage.BackColor = yellow4;
    //                    pnlop4.BackColor = yellow4;
    //                    vm4.BackColor = yellow4;
    //                    mv4.BackColor = yellow4;
    //                    pnlScoresPanelhehe.BackColor = yellow4;

    //                    pnlDifficultyBanner.BackColor = yellow5;
    //                    BackColor = yellow5;
    //                    pnlOptionsPage.BackColor = yellow5;
    //                    pnlHeader.BackColor = yellow5;
    //                    pnlAnimate.BackColor = yellow5;

    //                    btnEasy.BackColor = firebrick;
    //                    btnMedium.BackColor = firebrick;
    //                    btnClose.BackColor = btnHard.BackColor = firebrick;
    //                    dividerDesign.BackColor = btnCloseMenu.BackColor = firebrick;

    //                    hover2 = Color.Orange;

    //                    foreach (Control buttons in pnlAdminLogin.Controls)
    //                    {
    //                        if (buttons.AccessibleDescription == "buttonsForAdmin")
    //                        {
    //                            buttons.BackgroundImage = null;
    //                            buttons.BackColor = firebrick;
    //                        }
    //                    }
    //                    break;
    //                case "brown":

    //                    Color darkBrown = Color.FromArgb(138, 79, 21);
    //                    Color lightBrown = Color.FromArgb(139, 69, 19);
    //                    Color mediumBrown = Color.FromArgb(115, 59, 18);
    //                    Color deepBrown = Color.FromArgb(89, 46, 14);
    //                    Color darkestBrown = Color.FromArgb(64, 34, 11);
    //                    Color darkGray = Color.FromArgb(20, 20, 20);
    //                    Color darkRed = Color.DarkRed;

    //                    btnOptionsExit.BackColor = darkBrown;
    //                    btnExitToHomeFromProfile.BackColor = darkBrown;
    //                    btnExitToHomeFromProfile.BackgroundImage = null;

    //                    pnlDifficultyChoice.BackColor = lightBrown;
    //                    pfp1.BackColor = lightBrown;
    //                    pnlop1.BackColor = lightBrown;
    //                    vm1.BackColor = lightBrown;
    //                    mv1.BackColor = lightBrown;
    //                    ps0.BackColor = lightBrown;
    //                    scoreHistory.BackColor = lightBrown;

    //                    pnlDifficultyBorder1.BackColor = mediumBrown;
    //                    pfp5.BackColor = mediumBrown;
    //                    pfp2.BackColor = mediumBrown;
    //                    pnlop2.BackColor = mediumBrown;
    //                    vm2.BackColor = mediumBrown;
    //                    mv2.BackColor = mediumBrown;
    //                    ps1.BackColor = mediumBrown;

    //                    pnlDifficultyBorder2.BackColor = deepBrown;
    //                    pfp6.BackColor = deepBrown;
    //                    pfp3.BackColor = deepBrown;
    //                    pnlop3.BackColor = deepBrown;
    //                    vm3.BackColor = deepBrown;
    //                    mv3.BackColor = deepBrown;
    //                    ps2.BackColor = deepBrown;

    //                    pnlProfilePage.BackColor = darkestBrown;
    //                    pnlop4.BackColor = darkestBrown;
    //                    vm4.BackColor = darkestBrown;
    //                    mv4.BackColor = darkestBrown;
    //                    ps3.BackColor = darkestBrown;

    //                    pnlDifficultyBanner.BackColor = darkGray;
    //                    BackColor = darkGray;
    //                    pnlOptionsPage.BackColor = darkGray;
    //                    pnlHeader.BackColor = darkGray;
    //                    pnlAnimate.BackColor = darkGray;
    //                    pnlScoresPanelhehe.BackColor = darkGray;

    //                    btnEasy.BackColor = darkBrown;
    //                    btnMedium.BackColor = darkBrown;
    //                    btnClose.BackColor = btnHard.BackColor = darkBrown;
    //                    dividerDesign.BackColor = btnCloseMenu.BackColor = darkBrown;

    //                    hover2 = darkRed;

    //                    foreach (Control buttons in pnlAdminLogin.Controls)
    //                    {
    //                        if (buttons.AccessibleDescription == "buttonsForAdmin")
    //                        {
    //                            buttons.BackgroundImage = null;
    //                            buttons.BackColor = darkBrown;
    //                        }
    //                    }
    //                    break;
    //                case "aquamarine":

    //                    Color mainBlue = Color.FromArgb(54, 148, 153);
    //                    Color lightGreen = Color.FromArgb(127, 255, 212);
    //                    Color darkGreen = Color.FromArgb(97, 201, 166);
    //                    Color deepGreen = Color.FromArgb(79, 158, 131);
    //                    Color darkTeal = Color.FromArgb(57, 112, 93);
    //                    Color darkSlate = Color.FromArgb(0, 20, 20);
    //                    Color darkBlue = Color.DarkBlue;


    //                    btnOptionsExit.BackColor = mainBlue;
    //                    btnExitToHomeFromProfile.BackColor = mainBlue;
    //                    btnExitToHomeFromProfile.BackgroundImage = null;

    //                    pnlDifficultyChoice.BackColor = lightGreen;
    //                    pfp1.BackColor = lightGreen;
    //                    pnlop1.BackColor = lightGreen;
    //                    vm1.BackColor = lightGreen;
    //                    mv1.BackColor = lightGreen;
    //                    ps0.BackColor = lightGreen;
    //                    scoreHistory.BackColor = lightGreen;

    //                    pnlDifficultyBorder1.BackColor = darkGreen;
    //                    pfp5.BackColor = darkGreen;
    //                    pfp2.BackColor = darkGreen;
    //                    pnlop2.BackColor = darkGreen;
    //                    vm2.BackColor = darkGreen;
    //                    mv2.BackColor = darkGreen;
    //                    ps1.BackColor = darkGreen;

    //                    pnlDifficultyBorder2.BackColor = deepGreen;
    //                    pfp6.BackColor = deepGreen;
    //                    pfp3.BackColor = deepGreen;
    //                    pnlop3.BackColor = deepGreen;
    //                    vm3.BackColor = deepGreen;
    //                    mv3.BackColor = deepGreen;
    //                    ps2.BackColor = deepGreen;

    //                    pnlProfilePage.BackColor = darkTeal;
    //                    pnlop4.BackColor = darkTeal;
    //                    vm4.BackColor = darkTeal;
    //                    mv4.BackColor = darkTeal;
    //                    ps3.BackColor = darkTeal;

    //                    pnlDifficultyBanner.BackColor = darkSlate;
    //                    BackColor = darkSlate;
    //                    pnlOptionsPage.BackColor = darkSlate;
    //                    pnlHeader.BackColor = darkSlate;
    //                    pnlAnimate.BackColor = darkSlate;
    //                    pnlScoresPanelhehe.BackColor = darkSlate;

    //                    btnEasy.BackColor = mainBlue;
    //                    btnMedium.BackColor = mainBlue;
    //                    btnClose.BackColor = btnHard.BackColor = mainBlue;
    //                    dividerDesign.BackColor = btnCloseMenu.BackColor = mainBlue;

    //                    hover2 = darkBlue;

    //                    foreach (Control buttons in pnlAdminLogin.Controls)
    //                    {
    //                        if (buttons.AccessibleDescription == "buttonsForAdmin")
    //                        {
    //                            buttons.BackgroundImage = null;
    //                            buttons.BackColor = mainBlue;
    //                        }
    //                    }
    //                    break;
    //                case "darkred":
    //                    // Define color variables
    //                    Color darkBrown1 = Color.FromArgb(66, 14, 0);
    //                    Color darkRed1 = Color.FromArgb(189, 26, 26);
    //                    Color deepRed = Color.FromArgb(143, 21, 21);
    //                    Color darkestRed = Color.FromArgb(115, 18, 18);
    //                    Color maroon = Color.FromArgb(87, 16, 16);
    //                    Color darkSlate1 = Color.FromArgb(26, 8, 8);
    //                    Color darkGray1 = Color.FromArgb(20, 20, 20);

    //                    // Set control colors
    //                    btnOptionsExit.BackColor = darkBrown1;
    //                    btnExitToHomeFromProfile.BackColor = darkBrown1;
    //                    btnExitToHomeFromProfile.BackgroundImage = null;

    //                    pnlDifficultyChoice.BackColor = darkRed1;
    //                    pfp1.BackColor = darkRed1;
    //                    pnlop1.BackColor = darkRed1;
    //                    vm1.BackColor = darkRed1;
    //                    mv1.BackColor = darkRed1;
    //                    ps0.BackColor = darkRed1;
    //                    scoreHistory.BackColor = darkRed1;

    //                    pnlDifficultyBorder1.BackColor = deepRed;
    //                    pfp5.BackColor = deepRed;
    //                    pfp2.BackColor = deepRed;
    //                    pnlop2.BackColor = deepRed;
    //                    vm2.BackColor = deepRed;
    //                    mv2.BackColor = deepRed;
    //                    ps1.BackColor = deepRed;

    //                    pnlDifficultyBorder2.BackColor = darkestRed;
    //                    pfp6.BackColor = darkestRed;
    //                    pfp3.BackColor = darkestRed;
    //                    pnlop3.BackColor = darkestRed;
    //                    vm3.BackColor = darkestRed;
    //                    mv3.BackColor = darkestRed;
    //                    ps2.BackColor = darkestRed;

    //                    pnlProfilePage.BackColor = maroon;
    //                    pnlop4.BackColor = maroon;
    //                    vm4.BackColor = maroon;
    //                    mv4.BackColor = maroon;
    //                    ps3.BackColor = maroon;


    //                    pnlDifficultyBanner.BackColor = darkSlate1;
    //                    pnlOptionsPage.BackColor = darkSlate1;
    //                    BackColor = darkSlate1;
    //                    pnlHeader.BackColor = darkSlate1;
    //                    pnlAnimate.BackColor = darkSlate1;
    //                    pnlScoresPanelhehe.BackColor = darkSlate1;

    //                    btnEasy.BackColor = darkBrown1;
    //                    btnMedium.BackColor = darkBrown1;
    //                    btnClose.BackColor = btnHard.BackColor = darkBrown1;
    //                    dividerDesign.BackColor = btnCloseMenu.BackColor = darkBrown1;

    //                    hover2 = darkGray1;
    //                    foreach (Control buttons in pnlAdminLogin.Controls)
    //                    {
    //                        if (buttons.AccessibleDescription == "buttonsForAdmin")
    //                        {
    //                            buttons.BackgroundImage = null;
    //                            buttons.BackColor = darkBrown1;
    //                        }
    //                    }
    //                    break;
    //                case "darkgreen":
    //                    // Define color variables
    //                    Color darkGreen1 = Color.FromArgb(61, 125, 51);
    //                    Color darkGreen2 = Color.FromArgb(57, 138, 33);
    //                    Color darkGreen3 = Color.FromArgb(32, 107, 24);
    //                    Color darkGreen4 = Color.FromArgb(22, 79, 16);
    //                    Color darkGreen5 = Color.FromArgb(15, 61, 10);
    //                    Color darkGreen6 = Color.FromArgb(19, 26, 3);
    //                    Color hoverColor = Color.Black;

    //                    // Set control colors
    //                    btnOptionsExit.BackColor = darkGreen1;
    //                    btnExitToHomeFromProfile.BackColor = darkGreen1;
    //                    btnExitToHomeFromProfile.BackgroundImage = null;

    //                    pnlDifficultyChoice.BackColor = darkGreen2;
    //                    pfp1.BackColor = darkGreen2;
    //                    pnlop1.BackColor = darkGreen2;
    //                    vm1.BackColor = darkGreen2;
    //                    mv1.BackColor = darkGreen2;
    //                    ps0.BackColor = darkGreen2;
    //                    scoreHistory.BackColor = darkGreen2;

    //                    pnlDifficultyBorder1.BackColor = darkGreen3;
    //                    pfp5.BackColor = darkGreen3;
    //                    pfp2.BackColor = darkGreen3;
    //                    pnlop2.BackColor = darkGreen3;
    //                    vm2.BackColor = darkGreen3;
    //                    mv2.BackColor = darkGreen3;
    //                    ps1.BackColor = darkGreen3;

    //                    pnlDifficultyBorder2.BackColor = darkGreen4;
    //                    pfp6.BackColor = darkGreen4;
    //                    pfp3.BackColor = darkGreen4;
    //                    pnlop3.BackColor = darkGreen4;
    //                    vm3.BackColor = darkGreen4;
    //                    mv3.BackColor = darkGreen4;
    //                    ps2.BackColor = darkGreen4;

    //                    pnlProfilePage.BackColor = darkGreen5;
    //                    pnlop4.BackColor = darkGreen5;
    //                    vm4.BackColor = darkGreen5;
    //                    mv4.BackColor = darkGreen5;
    //                    ps3.BackColor = darkGreen5;

    //                    pnlDifficultyBanner.BackColor = darkGreen6;
    //                    pnlOptionsPage.BackColor = darkGreen6;
    //                    BackColor = darkGreen6;
    //                    pnlHeader.BackColor = darkGreen6;
    //                    pnlAnimate.BackColor = darkGreen6;
    //                    pnlScoresPanelhehe.BackColor = darkGreen6;

    //                    btnEasy.BackColor = darkGreen1;
    //                    btnMedium.BackColor = darkGreen1;
    //                    btnClose.BackColor = btnHard.BackColor = darkGreen1;
    //                    dividerDesign.BackColor = btnCloseMenu.BackColor = darkGreen1;

    //                    hover2 = hoverColor;

    //                    foreach (Control buttons in pnlAdminLogin.Controls)
    //                    {
    //                        if (buttons.AccessibleDescription == "buttonsForAdmin")
    //                        {
    //                            buttons.BackgroundImage = null;
    //                            buttons.BackColor = darkGreen1;
    //                        }
    //                    }
    //                    break;
    //                case "orange":
    //                    // Define color variables
    //                    Color darkOrange1 = Color.FromArgb(191, 124, 0);
    //                    Color darkOrange2 = Color.FromArgb(255, 160, 36);
    //                    Color darkOrange3 = Color.FromArgb(199, 113, 22);
    //                    Color darkOrange4 = Color.FromArgb(168, 95, 17);
    //                    Color darkOrange5 = Color.FromArgb(138, 74, 11);
    //                    Color darkOrange6 = Color.FromArgb(46, 21, 0);
    //                    Color hoverColor1 = Color.OrangeRed;

    //                    // Set control colors
    //                    btnOptionsExit.BackColor = darkOrange1;
    //                    btnExitToHomeFromProfile.BackColor = darkOrange1;
    //                    btnExitToHomeFromProfile.BackgroundImage = null;

    //                    pnlDifficultyChoice.BackColor = darkOrange2;
    //                    pfp1.BackColor = darkOrange2;
    //                    pnlop1.BackColor = darkOrange2;
    //                    vm1.BackColor = darkOrange2;
    //                    mv1.BackColor = darkOrange2;
    //                    ps0.BackColor = darkOrange2;
    //                    scoreHistory.BackColor = darkOrange2;

    //                    pnlDifficultyBorder1.BackColor = darkOrange3;
    //                    pfp5.BackColor = darkOrange3;
    //                    pfp2.BackColor = darkOrange3;
    //                    pnlop2.BackColor = darkOrange3;
    //                    vm2.BackColor = darkOrange3;
    //                    mv2.BackColor = darkOrange3;
    //                    ps1.BackColor = darkOrange3;

    //                    pnlDifficultyBorder2.BackColor = darkOrange4;
    //                    pfp6.BackColor = darkOrange4;
    //                    pfp3.BackColor = darkOrange4;
    //                    pnlop3.BackColor = darkOrange4;
    //                    vm3.BackColor = darkOrange4;
    //                    mv3.BackColor = darkOrange4;
    //                    ps2.BackColor = darkOrange4;

    //                    pnlProfilePage.BackColor = darkOrange5;
    //                    pnlop4.BackColor = darkOrange5;
    //                    vm4.BackColor = darkOrange5;
    //                    mv4.BackColor = darkOrange5;
    //                    ps3.BackColor = darkOrange5;

    //                    pnlDifficultyBanner.BackColor = darkOrange6;
    //                    pnlOptionsPage.BackColor = darkOrange6;
    //                    BackColor = darkOrange6;
    //                    pnlHeader.BackColor = darkOrange6;
    //                    pnlAnimate.BackColor = darkOrange6;
    //                    pnlScoresPanelhehe.BackColor = darkOrange6;

    //                    btnEasy.BackColor = darkOrange1;
    //                    btnMedium.BackColor = darkOrange1;
    //                    btnClose.BackColor = btnHard.BackColor = darkOrange1;
    //                    dividerDesign.BackColor = btnCloseMenu.BackColor = darkOrange1;

    //                    hover2 = hoverColor1;

    //                    foreach (Control buttons in pnlAdminLogin.Controls)
    //                    {
    //                        if (buttons.AccessibleDescription == "buttonsForAdmin")
    //                        {
    //                            buttons.BackgroundImage = null;
    //                            buttons.BackColor = darkOrange1;
    //                        }
    //                    }
    //                    break;
    //                case "cornflowerblue":
    //                    // Define color variables
    //                    Color cornflowerblue1 = Color.FromArgb(31, 145, 143);
    //                    Color cornflowerblue2 = Color.FromArgb(100, 149, 237);
    //                    Color cornflowerblue3 = Color.FromArgb(75, 119, 189);
    //                    Color cornflowerblue4 = Color.FromArgb(56, 92, 150);
    //                    Color cornflowerblue5 = Color.FromArgb(38, 67, 115);
    //                    Color cornflowerblue6 = Color.FromArgb(18, 53, 61);
    //                    Color hoverColor2 = Color.FromArgb(19, 54, 53);

    //                    // Set control colors
    //                    btnOptionsExit.BackColor = cornflowerblue1;
    //                    btnExitToHomeFromProfile.BackColor = cornflowerblue1;
    //                    btnExitToHomeFromProfile.BackgroundImage = null;

    //                    pnlDifficultyChoice.BackColor = cornflowerblue2;
    //                    pfp1.BackColor = cornflowerblue2;
    //                    pnlop1.BackColor = cornflowerblue2;
    //                    vm1.BackColor = cornflowerblue2;
    //                    mv1.BackColor = cornflowerblue2;
    //                    ps0.BackColor = cornflowerblue2;
    //                    scoreHistory.BackColor = cornflowerblue2;

    //                    pnlDifficultyBorder1.BackColor = cornflowerblue3;
    //                    pfp5.BackColor = cornflowerblue3;
    //                    pfp2.BackColor = cornflowerblue3;
    //                    pnlop2.BackColor = cornflowerblue3;
    //                    vm2.BackColor = cornflowerblue3;
    //                    mv2.BackColor = cornflowerblue3;
    //                    ps1.BackColor = cornflowerblue3;

    //                    pnlDifficultyBorder2.BackColor = cornflowerblue4;
    //                    pfp6.BackColor = cornflowerblue4;
    //                    pfp3.BackColor = cornflowerblue4;
    //                    pnlop3.BackColor = cornflowerblue4;
    //                    vm3.BackColor = cornflowerblue4;
    //                    mv3.BackColor = cornflowerblue4;
    //                    ps2.BackColor = cornflowerblue4;

    //                    pnlProfilePage.BackColor = cornflowerblue5;
    //                    pnlop4.BackColor = cornflowerblue5;
    //                    vm4.BackColor = cornflowerblue5;
    //                    mv4.BackColor = cornflowerblue5;
    //                    ps3.BackColor = cornflowerblue5;

    //                    pnlDifficultyBanner.BackColor = cornflowerblue6;
    //                    pnlOptionsPage.BackColor = cornflowerblue6;
    //                    BackColor = cornflowerblue6;
    //                    pnlHeader.BackColor = cornflowerblue6;
    //                    pnlAnimate.BackColor = cornflowerblue6;
    //                    pnlScoresPanelhehe.BackColor = cornflowerblue6;

    //                    btnEasy.BackColor = cornflowerblue1;
    //                    btnMedium.BackColor = cornflowerblue1;
    //                    btnClose.BackColor = btnHard.BackColor = cornflowerblue1;
    //                    dividerDesign.BackColor = btnCloseMenu.BackColor = cornflowerblue1;

    //                    hover2 = hoverColor2;
    //                    foreach (Control buttons in pnlAdminLogin.Controls)
    //                    {
    //                        if (buttons.AccessibleDescription == "buttonsForAdmin")
    //                        {
    //                            buttons.BackgroundImage = null;
    //                            buttons.BackColor = cornflowerblue1;
    //                        }
    //                    }
    //                    break;
    //                case "purple":
    //                    // Define color variables
    //                    Color purple1 = Color.FromArgb(147, 77, 161);
    //                    Color purple2 = Color.FromArgb(157, 34, 179);
    //                    Color purple3 = Color.FromArgb(132, 27, 150);
    //                    Color purple4 = Color.FromArgb(112, 19, 128);
    //                    Color purple5 = Color.FromArgb(93, 14, 107);
    //                    Color purple6 = Color.FromArgb(27, 7, 31);
    //                    Color hoverColor3 = Color.FromArgb(27, 7, 31);

    //                    // Set control colors
    //                    btnOptionsExit.BackColor = purple1;
    //                    btnExitToHomeFromProfile.BackColor = purple1;
    //                    btnExitToHomeFromProfile.BackgroundImage = null;

    //                    pnlDifficultyChoice.BackColor = purple2;
    //                    pfp1.BackColor = purple2;
    //                    pnlop1.BackColor = purple2;
    //                    vm1.BackColor = purple2;
    //                    mv1.BackColor = purple2;
    //                    ps0.BackColor = purple2;
    //                    scoreHistory.BackColor = purple2;

    //                    pnlDifficultyBorder1.BackColor = purple3;
    //                    pfp5.BackColor = purple3;
    //                    pfp2.BackColor = purple3;
    //                    pnlop2.BackColor = purple3;
    //                    vm2.BackColor = purple3;
    //                    mv2.BackColor = purple3;
    //                    ps1.BackColor = purple3;

    //                    pnlDifficultyBorder2.BackColor = purple4;
    //                    pfp6.BackColor = purple4;
    //                    pfp3.BackColor = purple4;
    //                    pnlop3.BackColor = purple4;
    //                    vm3.BackColor = purple4;
    //                    mv3.BackColor = purple4;
    //                    ps2.BackColor = purple4;

    //                    pnlProfilePage.BackColor = purple5;
    //                    pnlop4.BackColor = purple5;
    //                    vm4.BackColor = purple5;
    //                    mv4.BackColor = purple5;
    //                    ps3.BackColor = purple5;

    //                    pnlProfilePage.BackColor = purple6;
    //                    pnlOptionsPage.BackColor = purple6;
    //                    BackColor = purple6;
    //                    pnlHeader.BackColor = purple6;
    //                    pnlAnimate.BackColor = purple6;
    //                    pnlScoresPanelhehe.BackColor = purple6;

    //                    btnEasy.BackColor = purple1;
    //                    btnMedium.BackColor = purple1;
    //                    btnHard.BackColor = purple1;
    //                    dividerDesign.BackColor = btnCloseMenu.BackColor = purple1;
    //                    btnClose.BackColor = purple1;

    //                    hover2 = hoverColor3;
    //                    foreach (Control buttons in pnlAdminLogin.Controls)
    //                    {
    //                        if (buttons.AccessibleDescription == "buttonsForAdmin")
    //                        {
    //                            buttons.BackgroundImage = null;
    //                            buttons.BackColor = purple1;
    //                        }
    //                    }
    //                    break;
    //                default:
    //                    // hehe programming much wow hehe
    //                    break;
    //            }

    //        }

    //        /// <summary>
    //        /// Button to show options page Guest
    //        /// </summary>
    //        /// <param name="sender"></param>
    //        /// <param name="e"></param>
    //        private void btnOptionsGuest_Click(object sender, EventArgs e) => pnlOptionsPage.Show();




    //        /// <summary>
    //        /// Exit profile page
    //        /// </summary>
    //        /// <param name="sender"></param>
    //        /// <param name="e"></param>
    //        private void btnExitToHomeFromProfile_Click(object sender, EventArgs e) => pnlProfilePage.Hide();




    //        /// <summary>
    //        /// button for guest account in showing about page
    //        /// </summary>
    //        /// <param name="sender"></param>
    //        /// <param name="e"></param>
    //        private void btnAboutProjectGuest_Click(object sender, EventArgs e) => GoToAboutPage();




    //        /// <summary>
    //        /// Admin button for about page
    //        /// </summary>
    //        /// <param name="sender"></param>
    //        /// <param name="e"></param>
    //        private void btnAbout_Click(object sender, EventArgs e) => GoToAboutPage();

    //        // Guest UI buttons
    //        private void Hover1(object sender, EventArgs e) => btnPlayAsGuest.ForeColor = hover1;
    //        private void Leave1(object sender, EventArgs e) => btnPlayAsGuest.ForeColor = leave;
    //        private void Hover2(object sender, EventArgs e) => btnAboutProjectGuest.ForeColor = hover1;
    //        private void Leave2(object sender, EventArgs e) => btnAboutProjectGuest.ForeColor = leave;
    //        private void Hover3(object sender, EventArgs e) => btnHowToPlayeGuest.ForeColor = hover1;
    //        private void Leave3(object sender, EventArgs e) => btnHowToPlayeGuest.ForeColor = leave;
    //        private void Hover4(object sender, EventArgs e) => btnOptionsGuest.ForeColor = hover1;
    //        private void Leave4(object sender, EventArgs e) => btnOptionsGuest.ForeColor = leave;
    //        private void Hover5(object sender, EventArgs e) => btnExitGuest.ForeColor = hover1;
    //        private void Leave5(object sender, EventArgs e) => btnExitGuest.ForeColor = leave;
    //        private void Hover11(object sender, EventArgs e) => btnStartGame.ForeColor = hover2;
    //        private void Leave11(object sender, EventArgs e) => btnStartGame.ForeColor = leave;
    //        private void Hover12(object sender, EventArgs e) => btnAbout.ForeColor = hover2;
    //        private void Leave12(object sender, EventArgs e) => btnAbout.ForeColor = leave;
    //        private void Hover13(object sender, EventArgs e) => btnHowToPlay.ForeColor = hover2;
    //        private void Leave13(object sender, EventArgs e) => btnHowToPlay.ForeColor = leave;
    //        private void Hover14(object sender, EventArgs e) => btnProfile.ForeColor = hover2;
    //        private void Leave14(object sender, EventArgs e) => btnProfile.ForeColor = leave;
    //        private void Hover15(object sender, EventArgs e) => btnOptions.ForeColor = hover2;
    //        private void Leave15(object sender, EventArgs e) => btnOptions.ForeColor = leave;
    //        private void Hover16(object sender, EventArgs e) => btnScores.ForeColor = hover2;
    //        private void Leave16(object sender, EventArgs e) => btnScores.ForeColor = leave;
    //        private void Hover17(object sender, EventArgs e) => btnLogOut.ForeColor = hover2;
    //        private void Leave17(object sender, EventArgs e) => btnLogOut.ForeColor = leave;

    //        private void color1Click(object sender, EventArgs e)
    //        {
    //            lc1.Visible = true;
    //            lc2.Visible = !true;
    //            lc3.Visible = !true;
    //            lc4.Visible = !true;
    //            lc5.Visible = !true;
    //            lc6.Visible = !true;
    //            lc7.Visible = !true;
    //            lc8.Visible = !true;

    //            btnOptionsExit.Text = "Save Changes and Exit";
    //            admin.selectedTheme = "yellow";
    //            SetTheme();
    //        }

    //        private void color2Click(object sender, EventArgs e)
    //        {
    //            lc1.Visible = !true;
    //            lc2.Visible = true;
    //            lc3.Visible = !true;
    //            lc4.Visible = !true;
    //            lc5.Visible = !true;
    //            lc6.Visible = !true;
    //            lc7.Visible = !true;
    //            lc8.Visible = !true;

    //            btnOptionsExit.Text = "Save Changes and Exit";
    //            admin.selectedTheme = "brown";
    //            pnlColor1.BackColor = yellow1;
    //            SetTheme();
    //        }

    //        private void color3Click(object sender, EventArgs e)
    //        {
    //            lc1.Visible = !true;
    //            lc2.Visible = !true;
    //            lc3.Visible = true;
    //            lc4.Visible = !true;
    //            lc5.Visible = !true;
    //            lc6.Visible = !true;
    //            lc7.Visible = !true;
    //            lc8.Visible = !true;

    //            btnOptionsExit.Text = "Save Changes and Exit";
    //            admin.selectedTheme = "aquamarine";
    //            pnlColor1.BackColor = yellow1;

    //            SetTheme();

    //        }

    //        private void color4Click(object sender, EventArgs e)
    //        {
    //            lc1.Visible = !true;
    //            lc2.Visible = !true;
    //            lc3.Visible = !true;
    //            lc4.Visible = true;
    //            lc5.Visible = !true;
    //            lc6.Visible = !true;
    //            lc7.Visible = !true;
    //            lc8.Visible = !true;

    //            btnOptionsExit.Text = "Save Changes and Exit";
    //            admin.selectedTheme = "darkred";
    //            pnlColor1.BackColor = yellow1;

    //            SetTheme();
    //        }

    //        private void color5Click(object sender, EventArgs e)
    //        {
    //            lc1.Visible = !true;
    //            lc2.Visible = !true;
    //            lc3.Visible = !true;
    //            lc4.Visible = !true;
    //            lc5.Visible = true;
    //            lc6.Visible = !true;
    //            lc7.Visible = !true;
    //            lc8.Visible = !true;

    //            btnOptionsExit.Text = "Save Changes and Exit";
    //            admin.selectedTheme = "darkgreen";
    //            pnlColor1.BackColor = yellow1;

    //            SetTheme();
    //        }

    //        private void color6Click(object sender, EventArgs e)
    //        {
    //            lc1.Visible = !true;
    //            lc2.Visible = !true;
    //            lc3.Visible = !true;
    //            lc4.Visible = !true;
    //            lc5.Visible = !true;
    //            lc6.Visible = true;
    //            lc7.Visible = !true;
    //            lc8.Visible = !true;

    //            btnOptionsExit.Text = "Save Changes and Exit";
    //            admin.selectedTheme = "orange";
    //            pnlColor1.BackColor = yellow1;

    //            SetTheme();
    //        }

    //        private void color7Click(object sender, EventArgs e)
    //        {
    //            lc1.Visible = !true;
    //            lc2.Visible = !true;
    //            lc3.Visible = !true;
    //            lc4.Visible = !true;
    //            lc5.Visible = !true;
    //            lc6.Visible = !true;
    //            lc7.Visible = true;
    //            lc8.Visible = !true;

    //            btnOptionsExit.Text = "Save Changes and Exit";
    //            admin.selectedTheme = "cornflowerblue";
    //            pnlColor1.BackColor = yellow1;

    //            SetTheme();
    //        }

    //        private void color8Click(object sender, EventArgs e)
    //        {
    //            lc1.Visible = !true;
    //            lc2.Visible = !true;
    //            lc3.Visible = !true;
    //            lc4.Visible = !true;
    //            lc5.Visible = !true;
    //            lc6.Visible = !true;
    //            lc7.Visible = !true;
    //            lc8.Visible = true;

    //            btnOptionsExit.Text = "Save Changes and Exit";
    //            admin.selectedTheme = "purple";
    //            pnlColor1.BackColor = yellow1;

    //            SetTheme();
    //        }

    //        private void btnCloseMenu_Click(object sender, EventArgs e) => pnlDifficultyChoice.Hide();

    //        private void StartMedium(object sender, EventArgs e)
    //        {
    //            GameDifficulty = mediumGame.ReturnGameType();
    //            StartGame("admin");
    //        }

    //        private void clsoeButtonHekHok(object sender, EventArgs e)
    //        {
    //            pnlScoresPanelhehe.Hide();
    //        }

    //        private void pnlHowToPlay_Paint(object sender, PaintEventArgs e)
    //        {
    //            pnlHowToPlay.Show();
    //        }

    //        private void howtoplayHide_Click(object sender, EventArgs e)
    //        {
    //            pnlHowToPlay.Hide();
    //        }



    //        /// <summary>
    //        /// button for how to play guest
    //        /// </summary>
    //        /// <param name="sender"></param>
    //        /// <param name="e"></param>
    //        private void btnHowToPlayeGuest_Click(object sender, EventArgs e)
    //        {
    //            pnlHowToPlay.BringToFront();
    //            pnlHowToPlay.BackColor = BackColor;
    //            pnlHowToPlay.Location = new Point(0, 0);
    //            pnlHowToPlay.Show();
    //        }




    //        /// <summary>
    //        /// button for how to play for admin account
    //        /// </summary>
    //        /// <param name="sender"></param>
    //        /// <param name="e"></param>
    //        private void btnHowToPlay_Click(object sender, EventArgs e)
    //        {
    //            pnlHowToPlay.BringToFront();
    //            pnlHowToPlay.Location = new Point(0, 0);
    //            pnlHowToPlay.BackColor = BackColor;
    //            pnlHowToPlay.Show();
    //        }




    //        /// <summary>
    //        /// 
    //        /// </summary>
    //        /// <param name="sender"></param>
    //        /// <param name="e"></param>
    //        private void btnProfile_Click(object sender, EventArgs e)
    //        {
    //            lblJoinedDate.Text = $"Joined on: {dateJoined}";
    //            lblusernameDisplay.Text = "@" + username;
    //            lblGender.Text = $"Gender: {gender}";
    //            lblProfileName.Text = nameofAdmin;
    //            pnlProfilePage.BringToFront();
    //            lblAge.Text = $"Age: {age}";
    //            pnlProfilePage.Show();
    //        }




    //        /// <summary>
    //        /// hehe
    //        /// </summary>
    //        /// <param name="sender"></param>
    //        /// <param name="e"></param>
    //        private void btnScores_Click(object sender, EventArgs e)
    //        {

    //            if (scoreHistory.Text == "" || scoreHistory.Text == null)
    //            {
    //                MessageBox.Show(
    //                "You don't have any history yet! \n" +
    //                "Please play at least (1) game/s!",
    //                "Message",
    //                MessageBoxButtons.OK,
    //                MessageBoxIcon.Hand);
    //            }
    //            else
    //            {
    //                pnlScoresPanelhehe.BringToFront();
    //                pnlScoresPanelhehe.Show();
    //                pnlScoresPanelhehe.Location = new Point(0, 0);
    //            }
    //        }

    //    }
    //}

    #endregion
    #region Guest.System
    //namespace LightsOut.Classes
    //{
    //    internal class A_Guest : BaseClassAccounts
    //    {
    //        /// <summary>
    //        /// Default constructor
    //        /// </summary>
    //        public A_Guest()
    //        {
    //            Username = "Guest";
    //            Name = "Player 1";
    //        }
    //        //internal override void RegisterAccount(string username, string password, string nameOfUser)
    //        //{
    //        //    base.RegisterAccount(username, password, nameOfUser);
    //        //}
    //    }
    //}

    #endregion
    #region Accounts.System
    //namespace LightsOut.Classes
    //{
    //    internal class BaseClassAccounts
    //    {
    //        private string username;
    //        private string password;
    //        private string name;
    //        public string joinedDate, firstName, lastName, age, gender, selectedTheme;

    //        public string Username
    //        {
    //            get
    //            {
    //                return username;
    //            }
    //            set
    //            {
    //                if (username is null)
    //                    username = "admin";
    //                else
    //                    username = value;
    //            }
    //        }
    //        public string Password
    //        {
    //            get
    //            {
    //                return password;
    //            }
    //            set
    //            {
    //                //var specialChar = @"!@#$~%^&*()_+{}[]:'\<>?,./'=+-";
    //                //try
    //                //{
    //                //    foreach (char item in specialChar)
    //                //        if (password.Contains(item))
    //                //            password = value;
    //                //}
    //                //catch (Exception) {/**/}

    //                password = value;
    //            }
    //        }
    //        public string Name
    //        {
    //            get
    //            {
    //                return name;
    //            }
    //            set
    //            {
    //                name = value;
    //            }
    //        }
    //        //internal FileStream f;



    //        /// <summary>
    //        /// Method for registering new accounts (implementation in progress)
    //        /// </summary>
    //        /// <param name="username"></param>
    //        /// <param name="password"></param>
    //        /// <param name="nameOfUser"></param>
    //        internal virtual void RegisterAccount(string username, string password, string nameOfUser)
    //        {
    //            this.Username = username;
    //            this.Password = password;
    //            this.Name = nameOfUser;


    //            //f = new FileStream(@"C:\Users\ACT-STUDENT\Desktop\FinalProject\" + "Accounts.txt", FileMode.OpenOrCreate); // Create file          
    //            //StreamWriter eh = new StreamWriter(f); // Create value in file
    //            //eh.WriteLine(Username); // input value in file^^^


    //            ////
    //            //eh.Close();
    //            //f.Close();
    //        }
    //    }
    //}

    #endregion

    class DrawPanel : Panel
    {
        #pragma warning disable CS0169 // The field 'DrawPanel.components' is never used
        private ComponentModel.IContainer components;

        #pragma warning restore CS0169 // The field 'DrawPanel.components' is never used
        public DrawPanel()
        {
            DoubleBuffered = true;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }

    //set1[0].Location = set2[0].Location = set4[0].Location =
    //    set5[0].Location = set7[0].Location = set8[0].Location =
    //    set9[0].Location = set10[0].Location = set11[0].Location =
    //    set12[0].Location = set13[0].Location = set14[0].Location = set3[0].Location;
    //set1[1].Location = set2[1].Location = set4[1].Location =
    //    set5[1].Location = set7[1].Location = set8[1].Location =
    //    set9[1].Location = set10[1].Location = set11[1].Location =
    //    set12[1].Location = set13[1].Location = set14[1].Location = set3[1].Location;
    //set1[2].Location = set2[2].Location = set4[2].Location =
    //    set5[2].Location = set7[2].Location = set8[2].Location =
    //    set9[2].Location = set10[2].Location = set11[2].Location =
    //    set12[2].Location = set13[2].Location = set14[2].Location = set3[2].Location;
    //set1[3].Location = set2[3].Location = set4[3].Location =
    //    set5[3].Location = set7[3].Location = set8[3].Location =
    //    set9[3].Location = set10[3].Location = set11[3].Location =
    //    set12[3].Location = set13[3].Location = set14[3].Location = set3[3].Location;
    //set1[4].Location = set2[4].Location = set4[4].Location =
    //    set5[4].Location = set7[4].Location = set8[4].Location =
    //    set9[4].Location = set10[4].Location = set11[4].Location =
    //    set12[4].Location = set13[4].Location = set14[4].Location = set3[4].Location;



    class FadePanel : Panel
    {
        DrawPanel Layer = new DrawPanel();
        Bitmap image = null;
        float alpha = 0;
        float delta = 1;
        Timer timer = new Timer() { Interval = 25 };

        public bool FadeToParent { get; set; }
        public Color FadeColor { get; set; }
        public bool StaticContent { get; set; }
        public bool Hidden { get; private set; }

        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc1);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc2);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc3);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc4);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc5);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc6);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc7);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc8);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc9);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc10);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc11);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc12);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc13);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc14);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc15);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc16);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc17);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc18);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc19);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc20);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc21);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc22);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc23);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc24);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc25);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc26);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc27);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc28);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc29);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc30);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc31);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc32);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc33);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc34);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc35);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc36);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc37);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc38);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc39);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc40);
        //Render.RenderPerspectiveForGroundAndCeiling(pnlRenderedScreen, sc41);
        public FadePanel()
        {
            DoubleBuffered = true;
            Layer.Size = Size.Empty;
            Layer.Parent = FindForm();
            Layer.BackColor = Color.Transparent;
            Layer.Paint += Layer_Paint;
            BackColor = Color.DodgerBlue;
            FadeToParent = false;
            Color FadeColor = BackColor;
            Hidden = false;
            StaticContent = true;
            Layer.BackgroundImageLayout = ImageLayout.None;
            timer.Tick += timer_Tick;
        }


        void Layer_Paint(object sender, PaintEventArgs e)
        {
            if (alpha >= 0 && alpha <= 255)
            {
                using (SolidBrush brush =
                   new SolidBrush(Color.FromArgb((int)alpha, FadeColor)))
                    e.Graphics.FillRectangle(brush, Layer.ClientRectangle);
            }
        }

        public void CaptureLayer()
        {
            if (image == null) image = new Bitmap(ClientSize.Width, ClientSize.Height);
            DrawToBitmap(image, ClientRectangle);
            Layer.BackgroundImage = image;
        }

        public void FadeOut(int ms)
        {
            alpha = 0;
            delta = 256f / ms * timer.Interval;
            Fade(delta);
        }

        public void FadeIn(int ms)
        {
            alpha = 255;
            delta = -256f / ms * timer.Interval;
            Fade(delta);
        }

        void Fade(float delta)
        {
            if (image == null || !StaticContent) CaptureLayer();
            BringToFront();
            FadeColor = FadeToParent ? Parent.BackColor : FadeColor;
            Layer.BringToFront();
            Layer.Size = ClientSize;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            alpha += delta;
            if (alpha >= 255 || alpha <= 0)
            {
                alpha = delta > 0 ? 255 : 0;
                timer.Stop();
                if (delta < 0) BringToFront(); else SendToBack();
                Hidden = delta > 0;
                Layer.Size = delta > 0 ? ClientSize : Size.Empty;
            }
            Layer.Invalidate();
        }

    }
    internal class Mark
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        internal static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
       );

        /// <summary>
        /// Rounds the Corners of a control that is given.
        /// </summary>
        /// <param name="con"></param>
        internal void RoundCorner(Control con)
            => con.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, con.Width, con.Height, 20, 20));

        /// <summary>
        /// Rounds the Corners of a Control that is given with the given number.
        /// </summary>
        /// <param name="con"></param>
        /// <param name="cond"></param>
        internal void RoundCorner(Control con, int range)
            => con.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, con.Width, con.Height, range, range));


        //hehe
    }
}