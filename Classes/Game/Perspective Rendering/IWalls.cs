using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LightsOut.Classes
{
    internal interface IWalls
    {
        Color ApplySelectedTheme(string selectedTheme, int index);
        bool CollidingWithWalls(Control collider);
    }

}
