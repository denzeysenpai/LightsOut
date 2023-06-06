using System.Windows.Forms;

namespace LightsOut.Classes.Homepage
{
    internal class Animate : BaseClassHomePage
    {
        private bool back;
        private bool runonce = true;



        public Animate() : base() { }
        public Animate(bool back) : base() { this.back = back; }
        public Animate(bool back, int speedOfAnimation) : base(speedOfAnimation)
        {
            this.back = back;
        }




        /// <summary>
        /// Main Header Animation Method with default speed.
        /// </summary>
        /// <param name="header">
        /// The Control you want to move or to act as your header
        /// </param>
        /// <param name="form">
        /// The form on which the animation will take place
        /// </param>
        public void HeaderAnimation(Control header, Form form)
        {
            // title animation
            if (header.Top < -6)
                header.Top += 4;
            else
                if (header.Top < -5)
                header.Top += 2;
        }




        /// <summary>
        /// Overload of Header Animation Method, 
        /// add true or false in the argument
        /// in order to use the speed given in the parameterized constructor.
        /// </summary>
        /// <param name="header">
        /// The Control you want to move or to act as your header
        /// </param>
        /// <param name="form">
        /// The form on which the animation will take place
        /// </param>
        /// <param name="Custom">
        /// Set to true or false, automatically uses the speed given on the constrctor that was called during
        /// object definition, if none was given then, possible null reference.
        /// </param>
        public void HeaderAnimation(Control header, Form form, bool Custom) // Just set true to customize speed
        {
            // title animation
            if (header.Top < form.Height)
                header.Top += (speedOfAnimation) * 2;
            else
                if (header.Top < -(speedOfAnimation))
                header.Top += (speedOfAnimation);
        }




        /// <summary>
        /// Animation Method for panels (Four) to move in order from left to right. 
        /// </summary>
        /// <param name="mv1">
        /// Moves first
        /// </param>
        /// <param name="mv2">
        /// Moves second
        /// </param>
        /// <param name="mv3">
        /// Moves third
        /// </param>
        /// <param name="mv4">
        /// Moves last
        /// </param>
        public void LeftToRightAnimationFour(Control mv1, Control mv2, Control mv3, Control mv4)
        {
            // Left side animation
            if (mv1.Left < 0)
                mv1.Left += 5;
            if (mv1.Left >= 0 && mv2.Left < 0)
                mv2.Left += 10;
            if (mv2.Left >= 0 && mv3.Left < 0)
                mv3.Left += 15;
            if (mv3.Left >= 0 && mv4.Left < 0)
                mv4.Left += 20;
        }




        /// <summary>
        /// Animation Method for panels (Four) to move in order from right to left.
        /// </summary>
        /// <param name="mv1">
        /// Moves first
        /// </param>
        /// <param name="mv2">
        /// Moves second
        /// </param>
        /// <param name="mv3">
        /// Moves third
        /// </param>
        /// <param name="mv4">
        /// Moves last
        /// </param>
        public void RightToLeftAnimationFour(Control mv1, Control mv2, Control mv3, Control mv4, Form form)
        {

            // Right Side animation
            if (mv1.Left > form.Width - mv1.Width)
                mv1.Left -= 5;
            if (mv1.Left <= form.Width - mv1.Width &&
                mv2.Left > form.Width - mv2.Width)
                mv2.Left -= 10;
            if (mv2.Left <= form.Width - mv2.Width &&
                mv3.Left > form.Width - mv3.Width)
                mv3.Left -= 15;
            if (mv3.Left <= form.Width - mv3.Width &&
                mv4.Left > form.Width - mv4.Width)
                mv4.Left -= 20;
        }




        /// <summary>
        /// Up and down animation loop, makes it look like it's bouncing!
        /// </summary>
        /// <param name="mv">
        /// Control you want to animate
        /// </param>
        public void UpDownLoopAnimation(Control mv)
        {
            // Guest mode text animation up and down loop
            if (mv.Top > 315 && back == false)
            {
                mv.Top--;
            }
            if (mv.Top <= 315)
                back = true;
            if (back == true && mv.Top <= 323)
            {
                mv.Top++;
            }
            if (mv.Top >= 323)
                back = false;
        }




        /// <summary>
        /// Overload of Up and down animation loop, makes it look like it's bouncing!
        /// </summary>
        /// <param name="mv">
        /// Control you want to animate
        /// </param>
        /// <param name="topY">
        /// Top Y coordinates of how far up you want the control to go
        /// </param>
        /// <param name="bottomY">
        /// Bottom Y coordinates of how far up you want the control to go
        /// </param>
        public void UpDownLoopAnimation(Control mv, int topY, int bottomY)
        {
            // Guest mode text animation up and down loop
            if (mv.Top > topY && back == false)
            {
                mv.Top--;
            }
            if (mv.Top <= topY)
                back = true;
            if (back == true && mv.Top <= bottomY)
            {
                mv.Top++;
            }
            if (mv.Top >= bottomY)
                back = false;
        }




        /// <summary>
        /// Overload of Up and down animation loop, makes it look like it's bouncing!
        /// </summary>
        /// <param name="mv">
        /// Control you want to animate
        /// </param>
        /// <param name="topY">
        /// Top Y coordinates of how far up you want the control to go
        /// </param>
        /// <param name="bottomY">
        /// Bottom Y coordinates of how far up you want the control to go
        /// </param>
        public void UpDownLoopAnimation(Control mv, int space)
        {
            int topY = 0;
            int bottomY = 0;

            if (runonce)
            {
                topY = mv.Top - space;
                bottomY = mv.Top;
            }
            // Guest mode text animation up and down loop
            if (mv.Top > topY && back == false)
            {
                mv.Top--;
            }
            if (mv.Top <= topY)
                back = true;
            if (back == true && mv.Top <= bottomY)
            {
                mv.Top++;
            }
            if (mv.Top >= bottomY)
                back = false;
        }



        /// <summary>
        /// Drops the selected control until it is no longer visible in the form
        /// </summary>
        /// <param name="mv"></param>
        /// <param name="frm"></param>
        public void DropDownAnimation(Control mv, Form frm)
        {
            if (mv.Top < frm.Height)
                mv.Top += 4;
        }



        //public void OpenPanelAnimation()
        //{

        //}
    }
}
