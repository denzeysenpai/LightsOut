using LightsOut.Classes.Game;
using LightsOut.Classes.Game.Perspective_Rendering;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace LightsOut.Classes
{
    internal class Perspective : IWalls, IGroundAndCeiling
    {
        #region Attributes
        public List<PictureBox> set1 = new List<PictureBox>();
        public List<PictureBox> set2 = new List<PictureBox>();
        public List<PictureBox> set3 = new List<PictureBox>();
        public List<PictureBox> set4 = new List<PictureBox>();
        public List<PictureBox> set5 = new List<PictureBox>();

        public List<PictureBox> set7 = new List<PictureBox>();
        public List<PictureBox> set8 = new List<PictureBox>();
        public List<PictureBox> set9 = new List<PictureBox>();
        public List<PictureBox> set10 = new List<PictureBox>();

        public List<PictureBox> set11 = new List<PictureBox>();
        public List<PictureBox> set12 = new List<PictureBox>();
        public List<PictureBox> set13 = new List<PictureBox>();
        public List<PictureBox> set14 = new List<PictureBox>();

#pragma warning disable CS0169 // The field 'Perspective.depth4' is never used
#pragma warning disable CS0169 // The field 'Perspective.depth3' is never used
#pragma warning disable CS0169 // The field 'Perspective.depth2' is never used
#pragma warning disable CS0169 // The field 'Perspective.depth5' is never used
#pragma warning disable CS0169 // The field 'Perspective.depth1' is never used
#pragma warning disable CS0169 // The field 'Perspective.depth6' is never used
        bool depth1, depth2, depth3, depth4, depth5, depth6;
#pragma warning restore CS0169 // The field 'Perspective.depth6' is never used
#pragma warning restore CS0169 // The field 'Perspective.depth1' is never used
#pragma warning restore CS0169 // The field 'Perspective.depth5' is never used
#pragma warning restore CS0169 // The field 'Perspective.depth2' is never used
#pragma warning restore CS0169 // The field 'Perspective.depth3' is never used
#pragma warning restore CS0169 // The field 'Perspective.depth4' is never used
        A_Admin admin;
        GameMechanics player;

        public Panel w1;
        public Panel w2;
        public Panel w3;
        public Panel w4;
        public Panel w5;
        public Panel w6;
        public Panel w7;
        public Panel w8;
        public Panel w9;
        public Panel w10;

        public Panel w11;
        public Panel w12;
        public Panel w13;
        public Panel w14;
        public Panel w15;
        public Panel w16;
        public Panel w17;
        public Panel w18;
        public Panel w19;
        public Panel w20;

        public Panel w21;
        public Panel w22;
        public Panel w23;
        public Panel w24;
        public Panel w25;
        public Panel w26;
        public Panel w27;
        public Panel w28;
        public Panel w29;
        public Panel w30;

        public Panel w31;
        public Panel w32;
        public Panel w33;
        public Panel w34;
        public Panel w35;
        public Panel w36;
        public Panel w37;
        public Panel w38;
        public Panel w39;
        public Panel w40;

        public Panel w41; //


        public Color movingColor1 = Color.FromArgb(40, 40, 40);
        public Color movingColor2 = Color.FromArgb(15, 15, 15);
        public Control screen;
        public Control character;
        #endregion

        #region Constructor
        public Perspective // Constructor to be used for passing the set colliders
            (
                List<PictureBox> set1,
                List<PictureBox> set2,
                List<PictureBox> set3,
                List<PictureBox> set4,
                List<PictureBox> set5,
                List<PictureBox> set7,
                List<PictureBox> set8,
                List<PictureBox> set9,
                List<PictureBox> set10,
                List<PictureBox> set11,
                List<PictureBox> set12,
                List<PictureBox> set13,
                List<PictureBox> set14,
                A_Admin admin,
                Control screen,
                GameMechanics player
            )
        {
            this.set1 = set1;
            this.set2 = set2;
            this.set3 = set3;
            this.set4 = set4;
            this.set5 = set5;
            this.set7 = set7;
            this.set8 = set8;
            this.set9 = set9;
            this.set10 = set10;
            this.set11 = set11;
            this.set12 = set12;
            this.set13 = set13;
            this.set14 = set14;
            this.admin = admin;
            this.screen = screen;
            this.player = player;
        }

        public Perspective() { /**/ }
        public Perspective(Control screen, Control character)
        {
            this.screen = screen;
            this.character = character;
        }
        #endregion

        #region Walls
        public void Walls(
        Panel w1,
        Panel w2,
        Panel w3,
        Panel w4,
        Panel w5,
        Panel w6,
        Panel w7,
        Panel w8,
        Panel w9,
        Panel w10,
        Panel w11,
        Panel w12,
        Panel w13,
        Panel w14,
        Panel w15,
        Panel w16,
        Panel w17,
        Panel w18,
        Panel w19,
        Panel w20,
        Panel w21,
        Panel w22,
        Panel w23,
        Panel w24,
        Panel w25,
        Panel w26,
        Panel w27,
        Panel w28,
        Panel w29,
        Panel w30,
        Panel w31,
        Panel w32,
        Panel w33,
        Panel w34,
        Panel w35,
        Panel w36,
        Panel w37,
        Panel w38,
        Panel w39,
        Panel w40,
        Panel w41
            )
        {
            this.w1 = w1;
            this.w2 = w2;
            this.w3 = w3;
            this.w4 = w4;
            this.w5 = w5;
            this.w6 = w6;
            this.w7 = w7;
            this.w8 = w8;
            this.w9 = w9;
            this.w10 = w10;
            this.w11 = w11;
            this.w12 = w12;
            this.w13 = w13;
            this.w14 = w14;
            this.w15 = w15;
            this.w16 = w16;
            this.w17 = w17;
            this.w18 = w18;
            this.w19 = w19;
            this.w20 = w20;
            this.w21 = w21;
            this.w22 = w22;
            this.w23 = w23;
            this.w24 = w24;
            this.w25 = w25;
            this.w26 = w26;
            this.w27 = w27;
            this.w28 = w28;
            this.w29 = w29;
            this.w30 = w30;
            this.w31 = w31;
            this.w32 = w32;
            this.w33 = w33;
            this.w34 = w34;
            this.w35 = w35;
            this.w36 = w36;
            this.w37 = w37;
            this.w38 = w38;
            this.w39 = w39;
            this.w40 = w40;
            this.w41 = w41;
        }

        #endregion

        /* depth 0 = no collision
         * depth 1 = collision on 5          Farthest
         * depth 2 = collision on 4             |
         * depth 3 = collision on 3             |
         * depth 4 = collision on 2             V
         * depth 5 & 6 = collision on 1      Nearest
         */

        public Color ApplySelectedTheme(string selectedTheme, int index)
        {
            #region Color Theme Lists
            List<Color> yellow = new List<Color>()
            {
                Color.FromArgb(255, 186, 59),
                Color.FromArgb(209, 138, 38),
                Color.FromArgb(179, 119, 36),
                Color.FromArgb(156, 94, 33),
                Color.FromArgb(97, 59, 22),
                Color.FromArgb(38, 24, 10),
                Color.FromArgb(15, 10, 5)
            };
            List<Color> brown = new List<Color>()
            {
                Color.FromArgb(139, 69, 19),
                Color.FromArgb(115, 59, 18),
                Color.FromArgb(89, 46, 14),
                Color.FromArgb(64, 34, 11),
                Color.FromArgb(41, 22, 8),
                Color.FromArgb(20, 11, 4),
                Color.FromArgb(5, 3, 1)
            };
            List<Color> aquamarine = new List<Color>()
            {
                Color.FromArgb(127, 255, 212),
                Color.FromArgb(97, 201, 166),
                Color.FromArgb(79, 158, 131),
                Color.FromArgb(57, 112, 93),
                Color.FromArgb(36, 69, 58),
                Color.FromArgb(18, 33, 28),
                Color.FromArgb(9, 15, 13)
            };
            List<Color> darkred = new List<Color>()
            {
                Color.FromArgb(189, 26, 26),
                Color.FromArgb(143, 21, 21),
                Color.FromArgb(115, 18, 18),
                Color.FromArgb(87, 16, 16),
                Color.FromArgb(59, 13, 13),
                Color.FromArgb(28, 7, 7),
                Color.FromArgb(15, 4, 4)
            };
            List<Color> darkgreen = new List<Color>()
            {
                Color.FromArgb(57, 138, 33),
                Color.FromArgb(32, 107, 24),
                Color.FromArgb(22, 79, 16),
                Color.FromArgb(15, 61, 10),
                Color.FromArgb(11, 38, 8),
                Color.FromArgb(6, 20, 4),
                Color.FromArgb(2, 8, 2)
            };
            List<Color> orange = new List<Color>()
            {
                Color.FromArgb(255, 160, 36),
                Color.FromArgb(199, 113, 22),
                Color.FromArgb(168, 95, 17),
                Color.FromArgb(138, 74, 11),
                Color.FromArgb(66, 37, 9),
                Color.FromArgb(20, 12, 4),
                Color.FromArgb(10, 6, 2)
            };
            List<Color> cornflowerblue = new List<Color>()
            {
                Color.FromArgb(100, 149, 237),
                Color.FromArgb(75, 119, 189),
                Color.FromArgb(56, 92, 150),
                Color.FromArgb(38, 67, 115),
                Color.FromArgb(29, 49, 82),
                Color.FromArgb(18, 28, 46),
                Color.FromArgb(11, 16, 26)
            };
            List<Color> purple = new List<Color>()
            {
                Color.FromArgb(157, 34, 179),
                Color.FromArgb(132, 27, 150),
                Color.FromArgb(112, 19, 128),
                Color.FromArgb(93, 14, 107),
                Color.FromArgb(67, 12, 77),
                Color.FromArgb(36, 9, 41),
                Color.FromArgb(20, 6, 23)
            };
            #endregion

            switch (selectedTheme)
            {
                case "yellow":
                    return yellow[index];
                case "brown":
                    return brown[index];
                case "aquamarine":
                    return aquamarine[index];
                case "darkred":
                    return darkred[index];
                case "darkgreen":
                    return darkgreen[index];
                case "orange":
                    return orange[index];
                case "cornflowerblue":
                    return cornflowerblue[index];
                case "purple":
                    return purple[index];
                default:
                    return Color.Black;
            }
        }

        public void StillOnGround(Control ground)
        {
            bool GroundIsVertical = (ground.Width < ground.Height);
            bool IsPlayerStillOnGround = (character.Bounds.IntersectsWith(ground.Bounds));



            if (character.Top < ground.Top && GroundIsVertical && IsPlayerStillOnGround)
            {
                foreach (Control character in screen.Controls)
                {
                    if (character.AccessibleName == "player")
                    {
                        character.Top += 5;
                    }
                }
            }
            if (character.Top > ground.Top + ground.Height - character.Height && GroundIsVertical && IsPlayerStillOnGround)
            {
                foreach (Control character in screen.Controls)
                {
                    if (character.AccessibleName == "player")
                    {
                        character.Top -= 5;
                    }
                }
            }
            if (character.Left < ground.Left && !GroundIsVertical && IsPlayerStillOnGround)
            {
                foreach (Control character in screen.Controls)
                {
                    if (character.AccessibleName == "player")
                    {
                        character.Left += 5;
                    }
                }
            }
            if (character.Left > ground.Left + ground.Width - character.Width && !GroundIsVertical && IsPlayerStillOnGround)
            {
                foreach (Control character in screen.Controls)
                {
                    if (character.AccessibleName == "player")
                    {
                        character.Left -= 5;
                    }
                }
            }




            if (character.Left < ground.Left && GroundIsVertical && IsPlayerStillOnGround)
            {
                foreach (Control character in screen.Controls)
                {
                    if (character.AccessibleName == "player")
                    {
                        character.Left++;
                    }
                }
            }
            if (character.Left > ground.Left && GroundIsVertical && IsPlayerStillOnGround)
            {
                foreach (Control character in screen.Controls)
                {
                    if (character.AccessibleName == "player")
                    {
                        character.Left--;
                    }
                }
            }


            if (character.Top < ground.Top && !GroundIsVertical && IsPlayerStillOnGround)
            {
                foreach (Control character in screen.Controls)
                {
                    if (character.AccessibleName == "player")
                    {
                        character.Top++;
                    }
                }
            }
            if (character.Top > ground.Top && !GroundIsVertical && IsPlayerStillOnGround)
            {
                foreach (Control character in screen.Controls)
                {
                    if (character.AccessibleName == "player")
                    {
                        character.Top--;
                    }
                }
            }
        }




        // returns selected theme color based of an index given
        public Color AddThemeColor( int index)
        {
            return ApplySelectedTheme(admin.selectedTheme, index);
        }




        /// <summary>
        /// Render perspective on screen
        /// </summary>
        /// <param name="color"> String input to decide what part of the screen render sets</param>
        /// <param name="setList"> Set list, a set of colliders arranged from  1 - 5 (0 index to 4) and is 
        /// from nearest to furthest, 0 being the nearest, and 4 being the farthest</param>
        /// <param name="form">
        /// Form on which the game takes place</param>
        /// 
        public void RenderPerspectiveMainScreenArea(string column, List<PictureBox> setList) // done
        {
            Color change;

            // 0, 1, 2, 3, 4  || Index in the list setlist[n]
            foreach (Control render in screen.Controls) // foreach for the render panels in the game
            {
                if (render.AccessibleDescription == "depth0")
                {
                    if (!CollidingWithWalls(setList[4]))
                    { // checks if collider setList index 4 (5th collider, further out) is colliding with a wall | no collision
                        if (render.AccessibleName == column) // looks for the proper row/column to render
                        {
                            change = ApplySelectedTheme(admin.selectedTheme, 5); // sets new values for color
                            render.BackColor = change; // changes the values accordingly
                        }
                    }

                    if (CollidingWithWalls(setList[4]))
                    {// Index 4 being the farthest to the player (has the darkest color, except for no collision color)
                        if (render.AccessibleName == column)
                        {
                            change = ApplySelectedTheme(admin.selectedTheme, 4);
                            render.BackColor = change;
                        }
                    }

                    if (CollidingWithWalls(setList[3]))
                    { // Index 3 || collider 4 
                        if (render.AccessibleName == column)
                        {
                            change = ApplySelectedTheme(admin.selectedTheme, 3);
                            render.BackColor = change;
                        }
                    }

                    if (CollidingWithWalls(setList[2]))
                    { // Index 2 || collider 3
                        if (render.AccessibleName == column)
                        {
                            change = ApplySelectedTheme(admin.selectedTheme, 2);
                            render.BackColor = change;
                        }
                    }

                    if (CollidingWithWalls(setList[1]))
                    { // Index 1 || collider 2

                        if (render.AccessibleName == column)
                        {
                            change = ApplySelectedTheme(admin.selectedTheme, 1);
                            render.BackColor = change;
                        }
                    }

                    if (CollidingWithWalls(setList[0]))
                    { // Index 0 being the nearest to the player (has the brightest color)
                        if (render.AccessibleName == column)
                        {
                            change = ApplySelectedTheme(admin.selectedTheme, 0);
                            render.BackColor = change;
                        }
                    }
                }
            }
        }





        /// <summary>
        /// Checks if the given collider Rect collides with a wall Rect
        /// </summary>
        /// <param name="collider">Collider hekhok</param>
        /// <returns></returns>
        public bool CollidingWithWalls(Control collider)
        {
            return (
                collider.Bounds.IntersectsWith(w1.Bounds) ||
                collider.Bounds.IntersectsWith(w2.Bounds) ||
                collider.Bounds.IntersectsWith(w3.Bounds) ||
                collider.Bounds.IntersectsWith(w4.Bounds) ||
                collider.Bounds.IntersectsWith(w5.Bounds) ||
                collider.Bounds.IntersectsWith(w6.Bounds) ||
                collider.Bounds.IntersectsWith(w7.Bounds) ||
                collider.Bounds.IntersectsWith(w8.Bounds) ||
                collider.Bounds.IntersectsWith(w9.Bounds) ||
                collider.Bounds.IntersectsWith(w10.Bounds) ||
                collider.Bounds.IntersectsWith(w11.Bounds) ||
                collider.Bounds.IntersectsWith(w12.Bounds) ||
                collider.Bounds.IntersectsWith(w13.Bounds) ||
                collider.Bounds.IntersectsWith(w14.Bounds) ||
                collider.Bounds.IntersectsWith(w15.Bounds) ||
                collider.Bounds.IntersectsWith(w16.Bounds) ||
                collider.Bounds.IntersectsWith(w17.Bounds) ||
                collider.Bounds.IntersectsWith(w18.Bounds) ||
                collider.Bounds.IntersectsWith(w19.Bounds) ||
                collider.Bounds.IntersectsWith(w20.Bounds) ||
                collider.Bounds.IntersectsWith(w21.Bounds) ||
                collider.Bounds.IntersectsWith(w22.Bounds) ||
                collider.Bounds.IntersectsWith(w23.Bounds) ||
                collider.Bounds.IntersectsWith(w24.Bounds) ||
                collider.Bounds.IntersectsWith(w25.Bounds) ||
                collider.Bounds.IntersectsWith(w26.Bounds) ||
                collider.Bounds.IntersectsWith(w27.Bounds) ||
                collider.Bounds.IntersectsWith(w28.Bounds) ||
                collider.Bounds.IntersectsWith(w29.Bounds) ||
                collider.Bounds.IntersectsWith(w30.Bounds) ||
                collider.Bounds.IntersectsWith(w31.Bounds) ||
                collider.Bounds.IntersectsWith(w32.Bounds) ||
                collider.Bounds.IntersectsWith(w33.Bounds) ||
                collider.Bounds.IntersectsWith(w34.Bounds) ||
                collider.Bounds.IntersectsWith(w35.Bounds) ||
                collider.Bounds.IntersectsWith(w36.Bounds) ||
                collider.Bounds.IntersectsWith(w37.Bounds) ||
                collider.Bounds.IntersectsWith(w38.Bounds) ||
                collider.Bounds.IntersectsWith(w39.Bounds) ||
                collider.Bounds.IntersectsWith(w40.Bounds) ||
                collider.Bounds.IntersectsWith(w41.Bounds)
                ); // di madag loop oi
        }

        /// <summary>
        /// Renders the ground and ceiling for the on screen panels display
        /// </summary>
        /// <param name="screen">Where the rendering takes place</param>
        /// <param name="_column1">What panel is triggered to use as basis</param>
        public void RenderPerspectiveForGroundAndCeiling(Control _column1)
        {
            Control Column;
            try
            {
                #region Storing values on variables
                Column = _column1;

                Color depth = Color.FromArgb(40, 40, 40);

                #endregion

                foreach (Control Render in screen.Controls) // 
                {
                    // if panel is the in the same column
                    if (Render.AccessibleName == Column.AccessibleName)
                    {
                        if (Column.BackColor == ApplySelectedTheme(admin.selectedTheme, 5)) // check panel color
                        {
                            if (Render.AccessibleDescription == "depth1")
                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 5);

                            if (Render.AccessibleDescription == "depth2")
                                Render.BackColor = depth;

                            if (Render.AccessibleDescription == "depth3")
                                Render.BackColor = depth;

                            if (Render.AccessibleDescription == "depth4")
                                Render.BackColor = depth;

                            if (Render.AccessibleDescription == "depth5")
                                Render.BackColor = depth;

                            if (Render.AccessibleDescription == "depth6")
                                Render.BackColor = depth;
                        }
                        if (Column.BackColor == ApplySelectedTheme(admin.selectedTheme, 4)) // check panel color
                        {
                            if (Render.AccessibleDescription == "depth1")
                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 4);

                            if (Render.AccessibleDescription == "depth2")
                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 4);

                            if (Render.AccessibleDescription == "depth3")
                                Render.BackColor = depth;

                            if (Render.AccessibleDescription == "depth4")

                                Render.BackColor = depth;

                            if (Render.AccessibleDescription == "depth5")
                                Render.BackColor = depth;

                            if (Render.AccessibleDescription == "depth6")
                                Render.BackColor = depth;
                        }
                        if (Column.BackColor == ApplySelectedTheme(admin.selectedTheme, 3)) // check panel color
                        {
                            if (Render.AccessibleDescription == "depth1")
                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 3);

                            if (Render.AccessibleDescription == "depth2")
                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 3);

                            if (Render.AccessibleDescription == "depth3")
                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 3);

                            if (Render.AccessibleDescription == "depth4")
                                Render.BackColor = depth;

                            if (Render.AccessibleDescription == "depth5")
                                Render.BackColor = depth;

                            if (Render.AccessibleDescription == "depth6")
                                Render.BackColor = depth;
                        }
                        if (Column.BackColor == ApplySelectedTheme(admin.selectedTheme, 2)) // check panel color
                        {
                            if (Render.AccessibleDescription == "depth1")
                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 2);

                            if (Render.AccessibleDescription == "depth2")
                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 2);

                            if (Render.AccessibleDescription == "depth3")
                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 2);

                            if (Render.AccessibleDescription == "depth4")
                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 2);

                            if (Render.AccessibleDescription == "depth5")
                                Render.BackColor = depth;

                            if (Render.AccessibleDescription == "depth6")
                                Render.BackColor = depth;
                        }
                        if (Column.BackColor == ApplySelectedTheme(admin.selectedTheme, 1)) // check panel color
                        {
                            if (Render.AccessibleDescription == "depth1")
                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 1);

                            if (Render.AccessibleDescription == "depth2")
                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 1);

                            if (Render.AccessibleDescription == "depth3")
                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 1);

                            if (Render.AccessibleDescription == "depth4")
                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 1);

                            if (Render.AccessibleDescription == "depth5")
                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 1);

                            if (Render.AccessibleDescription == "depth6")
                                Render.BackColor = depth;
                        }
                        if (Column.BackColor == ApplySelectedTheme(admin.selectedTheme, 0)) // check panel color
                        {
                            if (Render.AccessibleDescription == "depth1")
                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 0);

                            if (Render.AccessibleDescription == "depth2")
                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 0);

                            if (Render.AccessibleDescription == "depth3")
                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 0);

                            if (Render.AccessibleDescription == "depth4")
                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 0);

                            if (Render.AccessibleDescription == "depth5")
                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 0);

                            if (Render.AccessibleDescription == "depth6")
                                Render.BackColor = ApplySelectedTheme(admin.selectedTheme, 0);
                        }
                    }
                }
            }
            catch (Exception) {/**/}
        }
        /// <summary>
        /// Changes the ground Control given based of the string given
        /// </summary>
        /// <param name="ground">Control that will be checked for AccessibleDescription</param>
        /// <param name="depthFirst">First Depth or the Depth previous</param>
        /// <param name="depthSecond">Second Depth, the Control that will be updated next</param>
        public void ChangeGroundColor(Control ground, string depthFirst, string depthSecond)
        {
            if (ground.AccessibleDescription == depthFirst)
                ground.BackColor = movingColor1;
            if (ground.AccessibleDescription == depthSecond)
                ground.BackColor = movingColor2;
        }
    }
}
