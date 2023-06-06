using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightsOut.Classes.Game.Perspective_Rendering
{
    internal interface IGroundAndCeiling
    {
        //void RenderGroundOnMove();
        void StillOnGround(Control ground);
        void RenderPerspectiveForGroundAndCeiling(Control _column1);
        void ChangeGroundColor(Control ground, string depthFirst, string depthSecond);
    }
}
