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
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);

            Pen pen = new Pen(Color.FromArgb(33, 97, 140), 3);
            SolidBrush brush = new SolidBrush(Color.FromArgb(120, 52, 152, 219));

            g.FillEllipse(brush, 150, 150, 200, 200);
            g.DrawEllipse(pen, 150, 150, 200, 200);

            Font font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SolidBrush textBrush = new SolidBrush(Color.White);
            g.DrawString("Ibraheem", font, textBrush, 185, 235);

            pen.Dispose();
            brush.Dispose();
            font.Dispose();
            textBrush.Dispose();
            g.Dispose();
        }
    }
}
