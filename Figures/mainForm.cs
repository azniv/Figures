using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    public partial class mainForm : Form
    {
        
        PointF click;
        Graphics graphics;
        Polygon polygon;
        Rectangle rectangle;
        Circle circle;
        Square square;
        Triangle triangle;
        public static Color FormBackColor { get; set; }
        public mainForm()
        {
            InitializeComponent();
            graphics = CreateGraphics();
          
            
        }

        private void mainForm_MouseClick(object sender, MouseEventArgs e)
        {
            click = e.Location;
            polygon = new Polygon() { Radius = 100 };
            rectangle = new Rectangle(200, 100);
            circle = new Circle(100);
            square = new Square(100);
            triangle = new Triangle();
            if (RbPolygon.Checked)
            {
                polygon.DrawRegularPolygon(click,Polygon.CountCorners, polygon.Radius,graphics);
            }
            if (RbReactangle.Checked)
            {
                rectangle.DrawRectangle(click, graphics);
            }
            if (RbCircle.Checked)
            {
                circle.DrawCircle(click,graphics);
            }
            if (RbSquare.Checked)
            {
                square.DrawSquare(click, graphics);
            }
            if (RbTriangle.Checked)
            {
                triangle.DrawTriangle(click, graphics);
            }
        }

        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (Polygon.CountCorners > 2)
            {
                graphics.Clear(this.BackColor);
                Polygon.CountCorners = 2;
            }
            else
            {
                MessageBox.Show("На поле нет фигур для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            FormBackColor = this.BackColor;
        }

        private void инструкцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1) При нажатии курсором по области окна,в месте нажатия рисуется фигура." +
               "\n 2)Если выбран режим Многоульник, то при нажатии на форму, рисуется правильный многоугольник и при каждом клике увеличивается количество углов." +
               "\n3)При выборе других режимов, рисуется выбранная фигура."+
               " \n4)Кнопка Delete удаляет все размещеныые фигуры.");
        }
    }
}
