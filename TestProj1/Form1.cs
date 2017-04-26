using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProj1
{
    public partial class Form1 : Form
    {
        
        public class Circle{
            public int posx;
            public int posy;
            public int size;
            public Color color;
            public Circle(int posx, int posy, int size, Color color) {
                this.posx = posx;
                this.posy = posy;
                this.size = size;
                this.color = color;
            }
        }
        public List<Circle> Circles = new List<Circle>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = "X: " + e.X + " | Y:" + e.Y;
            Circles.Add(new Circle(e.X, e.Y, 25, Color.AliceBlue));
            drawCircles();
        }
        private void drawCircles() {
            Graphics g = base.CreateGraphics();
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height, g);
            foreach (Circle circle in Circles) {
                g.DrawEllipse(new Pen(circle.color), circle.posx, circle.posy, circle.size, circle.size);
            }

            pictureBox1.Image = bmp;
            g.DrawImage(bmp, 0, 0);

            pictureBox1.Refresh();
        }
    }
}
