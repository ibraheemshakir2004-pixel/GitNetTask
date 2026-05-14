using System;
using System.Drawing;
using System.Windows.Forms;

namespace GitNetUzdevums
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnDraw_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);

            Pen pen = new Pen(Color.FromArgb(33, 97, 140), 3);
            SolidBrush brush = new SolidBrush(Color.FromArgb(120, 52, 152, 219));

            int cx = (pictureBox1.Width / 2) - 100;
            int cy = (pictureBox1.Height / 2) - 100;

            g.FillEllipse(brush, cx, cy, 200, 200);
            g.DrawEllipse(pen, cx, cy, 200, 200);

            Font font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SolidBrush textBrush = new SolidBrush(Color.White);
            g.DrawString("Anaf", font, textBrush, cx + 60, cy + 85);

            pen.Dispose();
            brush.Dispose();
            font.Dispose();
            textBrush.Dispose();
            g.Dispose();
        }
        private void BtnGraph_Click(object sender, EventArgs e)
        {
            double scale = 60;
            int xc = pictureBox1.Width / 2;
            int yc = pictureBox1.Height / 2;
            double step = 0.005;
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            Pen axisPen = new Pen(Color.Gray, 1);
            g.DrawLine(axisPen, 0, yc, pictureBox1.Width, yc);
            g.DrawLine(axisPen, xc, 0, xc, pictureBox1.Height);
            Font labelFont = new Font("Segoe UI", 8F);
            g.DrawString("x", labelFont, Brushes.Gray, pictureBox1.Width - 15, yc + 5);
            g.DrawString("y", labelFont, Brushes.Gray, xc + 5, 5);
            Pen curvePen = new Pen(Color.FromArgb(39, 174, 96), 2);
            double x = -Math.PI * 2;
            while (x <= Math.PI * 2)
            {
                double y = Math.Cos(x);
                int xe = (int)(xc + scale * x);
                int ye = (int)(yc - scale * y);
                g.DrawEllipse(curvePen, xe, ye, 1, 1);
                x += step;
            }
            Font funcFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            g.DrawString("y = cos(x)", funcFont, new SolidBrush(Color.FromArgb(39, 174, 96)), 10, 10);

            axisPen.Dispose();
            curvePen.Dispose();
            labelFont.Dispose();
            funcFont.Dispose();
            g.Dispose();
        }
    }
}
