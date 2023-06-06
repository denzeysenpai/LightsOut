using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LightsOut.Classes
{
    internal class Colliders // PARENT CLASS
    {
        #region Declarations

        public bool finishedLoading;

        internal List<PictureBox> set7 = new List<PictureBox>();
        internal List<PictureBox> set8 = new List<PictureBox>();
        internal List<PictureBox> set9 = new List<PictureBox>();
        internal List<PictureBox> set10 = new List<PictureBox>();

        internal List<PictureBox> set1 = new List<PictureBox>(); // far left
        internal List<PictureBox> set2 = new List<PictureBox>(); // middle left
        internal List<PictureBox> set3 = new List<PictureBox>(); // center
        internal List<PictureBox> set4 = new List<PictureBox>(); // middle right
        internal List<PictureBox> set5 = new List<PictureBox>(); // far right

        internal List<PictureBox> set11 = new List<PictureBox>();
        internal List<PictureBox> set12 = new List<PictureBox>();
        internal List<PictureBox> set13 = new List<PictureBox>();
        internal List<PictureBox> set14 = new List<PictureBox>();

        public List<List<PictureBox>> colliderSets = new List<List<PictureBox>>();

        internal bool doOnce;

        #endregion Declarations

        /// <summary>
        /// Add the given colliders to a List<PictureBox> set
        /// </summary>
        /// <param name="setNumber">Set number you want to asign it to</param>
        /// <param name="collider1">[0]</param>
        /// <param name="collider2">[1]</param>
        /// <param name="collider3">[2]</param>
        /// <param name="collider4">[3]</param>
        /// <param name="collider5">[4]</param>
        internal void SetColliders(
            int setNumber,
            PictureBox collider1, // index 0
            PictureBox collider2, // index 1
            PictureBox collider3, // index 2
            PictureBox collider4, // index 3
            PictureBox collider5  // index 4
            )
        {
            try
            {
                switch (setNumber)
                {
                    case 1: // far left
                        set1.Add(collider1);
                        set1.Add(collider2);
                        set1.Add(collider3);
                        set1.Add(collider4);
                        set1.Add(collider5);
                        colliderSets.Add(set1);
                        break;
                    case 2: // middle left
                        set2.Add(collider1);
                        set2.Add(collider2);
                        set2.Add(collider3);
                        set2.Add(collider4);
                        set2.Add(collider5);
                        colliderSets.Add(set2);
                        break;
                    case 3: // center
                        set3.Add(collider1);
                        set3.Add(collider2);
                        set3.Add(collider3);
                        set3.Add(collider4);
                        set3.Add(collider5);
                        colliderSets.Add(set3);
                        break;
                    case 4: // middle right
                        set4.Add(collider1);
                        set4.Add(collider2);
                        set4.Add(collider3);
                        set4.Add(collider4);
                        set4.Add(collider5);
                        colliderSets.Add(set4);
                        break;
                    case 5: // far right
                        set5.Add(collider1);
                        set5.Add(collider2);
                        set5.Add(collider3);
                        set5.Add(collider4);
                        set5.Add(collider5);
                        colliderSets.Add(set5);
                        break;
                    case 7:
                        set7.Add(collider1);
                        set7.Add(collider2);
                        set7.Add(collider3);
                        set7.Add(collider4);
                        set7.Add(collider5);
                        colliderSets.Add(set7);
                        break;
                    case 8:
                        set8.Add(collider1);
                        set8.Add(collider2);
                        set8.Add(collider3);
                        set8.Add(collider4);
                        set8.Add(collider5);
                        colliderSets.Add(set8);
                        break;
                    case 9:
                        set9.Add(collider1);
                        set9.Add(collider2);
                        set9.Add(collider3);
                        set9.Add(collider4);
                        set9.Add(collider5);
                        colliderSets.Add(set9);
                        break;
                    case 10:
                        set10.Add(collider1);
                        set10.Add(collider2);
                        set10.Add(collider3);
                        set10.Add(collider4);
                        set10.Add(collider5);
                        colliderSets.Add(set10);
                        break;
                    case 11:
                        set11.Add(collider1);
                        set11.Add(collider2);
                        set11.Add(collider3);
                        set11.Add(collider4);
                        set11.Add(collider5);
                        colliderSets.Add(set11);
                        break;
                    case 12:
                        set12.Add(collider1);
                        set12.Add(collider2);
                        set12.Add(collider3);
                        set12.Add(collider4);
                        set12.Add(collider5);
                        colliderSets.Add(set12);
                        break;
                    case 13:
                        set13.Add(collider1);
                        set13.Add(collider2);
                        set13.Add(collider3);
                        set13.Add(collider4);
                        set13.Add(collider5);
                        colliderSets.Add(set13);
                        break;
                    case 14:
                        set14.Add(collider1);
                        set14.Add(collider2);
                        set14.Add(collider3);
                        set14.Add(collider4);
                        set14.Add(collider5);
                        colliderSets.Add(set14);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Argument given is out of range!", "Exception recognized!");
            }
            catch (Exception e)
            {
                MessageBox.Show($"Exception is not specified!\nError: {e.Message}",
                    "Exception recognized!");
            }
        }



        /// <summary>
        /// Arranges the colliders per collider
        /// </summary>
        /// <param name="c">
        /// Collider Control</param>
        /// <param name="linenumber">
        /// Line Order</param>
        /// <param name="numOfOrder">
        /// Order in Line</param>
        /// <param name="LeftOrRightSideCollider">
        /// Determines which side of the character when player faces up</param>
        /// <param name="DirectionFacing">Determine when to arrange </param>
        internal void ArrangeColliders(
           Control c, // Collider
           int linenumber, // line number representation
           int numOfOrder,
           string LeftOrRightSideCollider,
           string DirectionFacing
           )
        {
            // initialize finished as false 
            bool finished = false;
            int shift = (numOfOrder * linenumber); // set the shift value according to the given parameters

            #region Local Methods Declaration

            // shifts the colliders to their proper position
            void AddTopAndLeft()
            {
                c.Top += shift;
                c.Left += shift;
                finished = true;
            }

            void AddTopSubLeft()
            {
                c.Top += shift;
                c.Left -= shift;
                finished = true;
            }

            void SubTopAndLeft()
            {
                c.Top -= shift;
                c.Left -= shift;
                finished = true;
            }

            void SubTopAddLeft()
            {
                c.Top -= shift;
                c.Left += shift;
                finished = true;
            }

            #endregion

            switch (DirectionFacing)
            {
                case "top":
                    if (LeftOrRightSideCollider == "right")
                        AddTopAndLeft();
                    else // (LeftOrRightSideCollider == "left")
                        AddTopSubLeft();
                    break;
                case "bottom":
                    if (LeftOrRightSideCollider == "right")
                        SubTopAndLeft();
                    else
                        SubTopAddLeft();
                    break;
                case "left":
                    if (LeftOrRightSideCollider == "right")
                        SubTopAddLeft();
                    else
                        AddTopAndLeft();
                    break;
                case "right":
                    if (LeftOrRightSideCollider == "right")
                        AddTopSubLeft();
                    else
                        SubTopAndLeft();
                    break;
            }


            finishedLoading = finished; // changes to true so that the Tracker() method will do its job
        }



        /// <summary>
        /// Individually arranges the colliders per set
        /// </summary>
        /// <param name="set1"></param>
        /// <param name="set2"></param>
        /// <param name="face"></param>
        /// <param name="pos"></param>
        private void ArrangeColliderSet(List<PictureBox> set1, List<PictureBox> set2, string face, int pos)
        {
            // right
            for (int i = 1; i < 5; i++)
            {
                ArrangeColliders(set1[i - 1], pos, i, "right", face);
            }


            // left 
            for (int i = 1; i < 5; i++)
            {
                ArrangeColliders(set2[i - 1], pos, i, "left", face);
            }
        }



        /// <summary>
        /// Arranges the Colliders as one method
        /// </summary>
        /// <param name="face"></param>
        private void ArrangeColliderMethod(string face)
        {
            // ugly but works
            ArrangeColliderSet(set4, set2, face, 1);
            ArrangeColliderSet(set5, set1, face, 3);
            ArrangeColliderSet(set11, set10, face, 5);
            ArrangeColliderSet(set12, set9, face, 7);
            ArrangeColliderSet(set13, set8, face, 9);
            ArrangeColliderSet(set14, set7, face, 11);
        }



        /// <summary>
        /// Collider used to have a tendency to break off from its radius or supposed
        /// range or space from the player, this method fixes that issue and now prevents the colliders from
        /// separating from the player or breaking off.
        /// </summary>
        /// <param name="directionFacing"></param>
        internal void FixBreaking(string directionFacing) // done
        {
            // Sets all of the colliders location in a single line
            // DO NOT CHANGE !!
            if (doOnce)
            {
                for(int i = 0; i < 4; i++)
                {

                    // hard to read but shorter
                    set1[i].Location = set2[i].Location = set4[i].Location =
                    set5[i].Location = set7[i].Location = set8[i].Location =
                    set9[i].Location = set10[i].Location = set11[i].Location =
                    set12[i].Location = set13[i].Location = set14[i].Location = set3[i].Location;
                }
                doOnce = false;
            }



            // then gets arranged in the code block below
            string GetFace()
            {
                switch (directionFacing)
                {
                    case "forward": return "top";
                    case "backward": return "bottom";
                    case "left": return "left";
                    case "right": return "right";
                    default: return "";
                }
            }


            // Arrange the colliders depending on the direction given
            ArrangeColliderMethod(GetFace());
        }



    }
}
