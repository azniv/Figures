using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Figures
{
    public  class Rectangle
    {
        public float Width { get; set; }
        public float Height { get; set; }

        Pen pen = new Pen(Color.AliceBlue);
        
        public Rectangle()
        {

        }
        public Rectangle(float width, float height)
        {
            Width = width;
            Height = height;
        }
        public void DrawRectangle(PointF coordinates, Graphics graphics )
        {
            graphics.FillRectangle(Brushes.Blue, coordinates.X, coordinates.Y, Width, Height);  //Рисуем заполненный прямоугольник
        }
    }
}
