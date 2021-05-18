using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            var paper = panel1.CreateGraphics();
            var pen = new Pen(Color.Aqua, 5);
            paper.DrawEllipse(pen, Convert.ToInt32(circleX.Text), Convert.ToInt32(circleY.Text), Convert.ToInt32(circleRadius.Text), Convert.ToInt32(circleRadius.Text));

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            var paper = panel1.CreateGraphics();
            var pen = new Pen(Color.Aqua, 5);
            paper.DrawEllipse(pen, e.X, e.Y, Convert.ToInt32(circleRadius.Text), Convert.ToInt32(circleRadius.Text));

        }

        private void LineCheck_CheckedChanged(object sender, EventArgs e)
        {
            CircleCheck.Checked = false;
            TriangleCheck.Checked = false;
            rectangleCheck.Checked = false;
        }

        private void lineDrawButton_Click(object sender, EventArgs e)
        {
            var paper = panel1.CreateGraphics();
            var pen = new Pen(Color.Aqua, 5);
            paper.DrawLine(pen, Convert.ToInt32(LineX.Text), Convert.ToInt32(LineY.Text), Convert.ToInt32(LineX2.Text), Convert.ToInt32(LineY2.Text));
        }

        private void TriangleButton_Click(object sender, EventArgs e)
        {
            var paper = panel1.CreateGraphics();
            var pen = new Pen(Color.Aqua, 5);
            paper.DrawLine(pen, Convert.ToInt32(triangleX.Text), Convert.ToInt32(triangleY.Text), Convert.ToInt32(triangleX2.Text), Convert.ToInt32(triangleY2.Text));
            paper.DrawLine(pen, Convert.ToInt32(triangleX2.Text), Convert.ToInt32(triangleY2.Text), Convert.ToInt32(triangleX3.Text), Convert.ToInt32(triangleY3.Text));
            paper.DrawLine(pen, Convert.ToInt32(triangleX3.Text), Convert.ToInt32(triangleY3.Text), Convert.ToInt32(triangleX.Text), Convert.ToInt32(triangleY.Text));
        }

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            var paper = panel1.CreateGraphics();
            var pen = new Pen(Color.Aqua, 5);
            paper.DrawRectangle(pen, Convert.ToInt32(rectangleX.Text), Convert.ToInt32(rectangleY.Text), Convert.ToInt32(rectangleWidth.Text), Convert.ToInt32(rectangleHeight.Text));
        }

        private void CircleCheck_CheckedChanged(object sender, EventArgs e)
        {
            LineCheck.Checked = false;
            TriangleCheck.Checked = false;
            rectangleCheck.Checked = false;
        }

        private void TriangleCheck_CheckedChanged(object sender, EventArgs e)
        {
            CircleCheck.Checked = false;
            LineCheck.Checked = false;
            rectangleCheck.Checked = false;
        }

        private void rectangleCheck_CheckedChanged(object sender, EventArgs e)
        {
            CircleCheck.Checked = false;
            TriangleCheck.Checked = false;
            LineCheck.Checked = false;
            
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
    public class Figure
    {
        protected int x;
        protected int y;

        public Figure(int newX, int newY)
        {
            x = newX;
            y = newY;
        }

        public virtual void Draw()
        { }

        public override string ToString()
        {
            return base.ToString() + $";X={x};Y={y};";
        }
    }

    public class Line : Figure
    {
        protected int x2;
        protected int y2;

        public Line(int newX, int newY, int newX2, int newY2) : base(newX, newY)
        {
            x2 = newX2;
            y2 = newY2;
        }

        public override void Draw()
        {
            // Draw line
        }

        public override string ToString()
        {
            return base.ToString() + $"X2={x2};Y2={y2};";
        }
    }

    public class Circle : Figure
    {
        protected int r;

        public Circle(int newX, int newY, int newR) : base(newX, newY)
        {
            r = newR;
        }

        public override void Draw()
        {
            // Draw Circle
            paper.DrawEllipse(pen, x, y, r);
        }

        public override string ToString()
        {
            return base.ToString() + $"R={r}";
        }
    }
}
