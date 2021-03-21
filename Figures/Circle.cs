using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Figures
{
    public class Circle
    {
        public float  Diametr { get; set; }
        
        public Circle()
        {

        }
        public Circle(float diametr)
        {
            Diametr = diametr;
        }
        public void DrawCircle(PointF coordinates, Graphics graphics)
        {
            graphics.DrawEllipse(Pens.Red, coordinates.X, coordinates.Y, Diametr,Diametr);
        }
    }
}
