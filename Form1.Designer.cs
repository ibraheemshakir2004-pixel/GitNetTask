namespace GitNetUzdevums
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.GroupBox groupBox1 = new System.Windows.Forms.GroupBox();
            System.Windows.Forms.Button btnDraw = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // GroupBox
            groupBox1.Text = "Ibraheem Shakir";
            groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            groupBox1.ForeColor = System.Drawing.Color.FromArgb(33, 97, 140);
            groupBox1.Location = new System.Drawing.Point(20, 20);
            groupBox1.Size = new System.Drawing.Size(200, 80);

            // Button
            btnDraw.Text = "DrawCircle";
            btnDraw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnDraw.BackColor = System.Drawing.Color.FromArgb(33, 97, 140);
            btnDraw.ForeColor = System.Drawing.Color.White;
            btnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDraw.FlatAppearance.BorderSize = 0;
            btnDraw.Location = new System.Drawing.Point(10, 30);
            btnDraw.Size = new System.Drawing.Size(120, 30);
            btnDraw.Click += new System.EventHandler(this.BtnDraw_Click);

            groupBox1.Controls.Add(btnDraw);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.ClientSize = new System.Drawing.Size(500, 420);
            this.Controls.Add(groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GitNetTask - Ibraheem Shakir";
            this.ResumeLayout(false);
        }
    }
}
