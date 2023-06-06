using System.Windows.Forms;

namespace LightsOut.Classes
{
    internal abstract class BaseClassGameObject
    {
        public int movementspeed;
        public int numOfEntities;

        public abstract void Movement(Control form1, bool forward, bool backward, int diffX, int diffY);
    }
}
