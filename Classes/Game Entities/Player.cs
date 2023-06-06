using LightsOut.Classes.Game;
using System.Windows.Forms;

namespace LightsOut.Classes
{
    internal class Player : BaseClassGameObject
    {
        Control player;
        public Player(Control player)
        {
            movementspeed = 5;
            numOfEntities = 1;
            this.player = player;
        }
        public bool CheckCollisionWithEntity(Form form, string type)
        {
            bool result = true;
            foreach (Control enemy in form.Controls)
            {
                if (enemy.AccessibleDescription == type) // enemy or key
                {
                    result = (player.Bounds.IntersectsWith(enemy.Bounds));
                    return result;
                }
            }
            return result;
        }
        public override void Movement(Control form1, bool forward, bool backward, int diffX, int diffY)
        {
            foreach (Control ground in form1.Controls)
            {
                if (ground.AccessibleName == "ground")
                {
                    if (player.Bounds.IntersectsWith(ground.Bounds))
                    {
                        int speed = 5;
                        if (forward && (0 < diffY)) // collider facing up/forward
                            foreach (Control c in form1.Controls)
                                if (c.AccessibleName == player.AccessibleName)
                                    c.Top -= speed;


                        if (forward && (0 > diffY))
                            foreach (Control c in form1.Controls)
                                if (c.AccessibleName == player.AccessibleName)
                                    c.Top += speed;


                        if (forward && (0 < diffX))
                            foreach (Control c in form1.Controls)
                                if (c.AccessibleName == player.AccessibleName)
                                    c.Left += speed;


                        if (forward && (0 > diffX))
                            foreach (Control c in form1.Controls)
                                if (c.AccessibleName == player.AccessibleName)
                                    c.Left -= speed;


                        if (backward && (0 < diffY)) // collider facing up/forward
                            foreach (Control c in form1.Controls)
                                if (c.AccessibleName == player.AccessibleName)
                                    c.Top += speed;


                        if (backward && (0 > diffY))
                            foreach (Control c in form1.Controls)
                                if (c.AccessibleName == player.AccessibleName)
                                    c.Top -= speed;


                        if (backward && (0 < diffX))
                            foreach (Control c in form1.Controls)
                                if (c.AccessibleName == player.AccessibleName)
                                    c.Left -= speed;


                        if (backward && (0 > diffX))
                            foreach (Control c in form1.Controls)
                                if (c.AccessibleName == player.AccessibleName)
                                    c.Left += speed;
                    }
                }
            }
        }
    }
}
