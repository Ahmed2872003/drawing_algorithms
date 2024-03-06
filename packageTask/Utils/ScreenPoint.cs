using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace packageTask.Utils
{
    internal class ScreenPoint
    {
        public float X;
        public float Y;   
        public ScreenPoint(float X, float Y) {
            this.X = X;
            this.Y = Y;
        }

        public PointF toUnit(Size screenSize) {
            float x = screenSize.Width / 2 + this.X;
            float y = screenSize.Height / 2  - this.Y;
            return new PointF(x, y);    
        }
    }
}
