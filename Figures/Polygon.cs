using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Polygon
    {

        public  static int CountCorners { get; set; } =  2;
        public int Radius { get; set; }
        public Polygon()
        {
            CountCorners++;
        }

        //Координты вершин многоугольника 
        public static IEnumerable<PointF> CornersCoordinates(PointF center, int radius, int corners)
        {

            var angle = Math.PI * 2 / corners;
            //Точки многоугольника
            var points = Enumerable.Range(0, corners)
                    .Select(i => PointF.Add(center, new SizeF((float)Math.Sin(i * angle) * radius, (float)Math.Cos(i * angle) * radius)));
           

            return points;
        }


        //рисуем любой правильный многоугольник, начиная с трегольника
        public void DrawRegularPolygon(PointF center, // Координаты центра окружности описанной окружности
             int corners, // Количество вершин
             int r, // Радиус
             Graphics graphics

           )
        {

            var angle = Math.PI * 2 / corners;

            var points = Enumerable.Range(0, corners)
                    .Select(i => PointF.Add(center, new SizeF((float)Math.Sin(i * angle) * r, (float)Math.Cos(i * angle) * r)));




            graphics.Clear(mainForm.FormBackColor);   //Очищаем форму
            graphics.DrawPolygon(Pens.Blue, CornersCoordinates(center, r, corners).ToArray());   //Рисуем многоугольник
                                                                                                         //  triangle.A = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        }
    }
}
