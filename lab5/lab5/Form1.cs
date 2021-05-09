using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private int szer = 0, wys = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog2.FileName);
                szer = pictureBox1.Image.Width;
                wys = pictureBox1.Image.Height;
                pictureBox2.Image = new Bitmap(szer, wys);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Color k;
            int r, g, b;
            Bitmap b1 = (Bitmap)pictureBox1.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;

            double wartosc = trackBar1.Value;
            wartosc = wartosc / 255 + 1;

            for (int x = 0; x < szer; x++)
            {

                for (int y = 0; y < wys; y++)
                {
                    k = b1.GetPixel(x, y);
                    r = (int)(k.R * wartosc);
                    g = (int)(k.G * wartosc);
                    b = (int)(k.B * wartosc);
                    if (r > 255) r = 255;
                    if (g > 255) g = 255;
                    if (b > 255) b = 255;
                    k = Color.FromArgb(r, g, b);
                    b2.SetPixel(x, y, k);
                }

            }

            pictureBox2.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Color k;
            int r, g, b;
            Bitmap b1 = (Bitmap)pictureBox1.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;

            double wartosc = trackBar2.Value;
            wartosc = wartosc / 255;

            for (int x = 0; x < szer; x++)
            {

                for (int y = 0; y < wys; y++)
                {
                    k = b1.GetPixel(x, y);
                    r = (int)(k.R * wartosc);
                    g = (int)(k.G * wartosc);
                    b = (int)(k.B * wartosc);
                    k = Color.FromArgb(r, g, b);
                    b2.SetPixel(x, y, k);
                }

            }

            pictureBox2.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Color k;
            int r, g, b;
            Bitmap b1 = (Bitmap)pictureBox1.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;

            for (int x = 0; x < szer; x++)
            {

                for (int y = 0; y < wys; y++)
                {
                    k = b1.GetPixel(x, y);
                    r = 255 - k.R;
                    g = 255 - k.G;
                    b = 255 - k.B;
                    k = Color.FromArgb(r, g, b);
                    b2.SetPixel(x, y, k);
                }

            }

            pictureBox2.Refresh();
        }
    }
}
