using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class VneshniyVid : Form
    {
        public VneshniyVid(string tWidth, string tHeight)
        {
            InitializeComponent();
            nWidth = Convert.ToInt32(tWidth);
            nHeight = Convert.ToInt32(tHeight);
        }
        int nWidth;
        int nHeight;
        bool status;
        bool load;
        bool load1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                load = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(openFileDialog1.FileName);
                load1 = true;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            status = true;

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            status = false;
        }
        int ncx = 0, ncy = 0;
        int nlx = 0, nly = 0;
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true && load == true)
            {
                int dx = e.X - nlx;
                int dy = e.Y - nly;
                ncx += dx;
                ncy += dy;
                nlx = e.X;
                nly = e.Y;

                pictureBox1.Size = new Size(ncx, ncy);

            }
        }
        int lx = 0, ly = 0;
        int cx = 0, cy = 0;

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            status = true;
            lx = e.X;
            ly = e.Y;
        }


        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            status = false;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == true && load1 == true)
            {
                int dx = e.X - lx;
                int dy = e.Y - ly;
                cx += dx;
                cy += dy;
                lx = e.X;
                ly = e.Y;
                pictureBox2.SetBounds(cx, cy, pictureBox2.Width, pictureBox2.Height);
                this.Invalidate();
            }
        }
    }
}
