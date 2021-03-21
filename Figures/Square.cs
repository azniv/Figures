using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Square
    {
        public float Side { get; set; }
       

        Pen pen = new Pen(Color.Green);

        public Square()
        {

        }
        public Square(float side)
        {
            Side = side;
        
        }
        public void DrawSquare(PointF coordinates, Graphics graphics)
        {
            graphics.DrawRectangle(pen, coordinates.X, coordinates.Y, Side, Side );
           // graphics.FillRectangle(Brushes.Blue, coordinates.X, coordinates.Y, Side, Side);  //Рисуем заполненный прямоугольник
        }
    }
}
