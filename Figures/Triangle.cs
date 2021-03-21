using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AreaOfFigures;

namespace Figures
{
    public class Triangle 
    {
        
        public float  A { get; set; }
        public float B { get; set; }
        public float  C { get; set; }
     
        //Рисуем прямоугольный треугольник 
        public void DrawTriangle(PointF coordinates,Graphics graphics)
        {
            graphics.DrawLine(Pens.Black, coordinates.X, coordinates.Y , coordinates.X+100,coordinates.Y);
            graphics.DrawLine(Pens.Black, coordinates.X, coordinates.Y, coordinates.X + 100, coordinates.Y-100);
            graphics.DrawLine(Pens.Black, coordinates.X+100, coordinates.Y, coordinates.X+100, coordinates.Y-100);
        }

        
    }
}
