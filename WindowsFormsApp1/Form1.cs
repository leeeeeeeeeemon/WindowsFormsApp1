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
            paper.DrawEllipse(pen, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox1.Text));

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            var paper = panel1.CreateGraphics();
            var pen = new Pen(Color.Aqua, 5);
            paper.DrawEllipse(pen, e.X, e.Y, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox1.Text));

        }
    }
}
