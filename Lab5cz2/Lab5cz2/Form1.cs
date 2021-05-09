using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab5cz2
{

    public partial class Form1 : Form
    {
        int switchNumber;

        Bitmap Pic4;

        public Form1()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog Opfile = new OpenFileDialog();
            if (DialogResult.OK == Opfile.ShowDialog())
            {
                this.Pic1.Image = new Bitmap(Opfile.FileName);

                Bitmap Pic1 = new Bitmap(this.Pic1.Image);
            }
        }

        private void Open2_Click(object sender, EventArgs e)
        {
            OpenFileDialog Opfile = new OpenFileDialog();
            if (DialogResult.OK == Opfile.ShowDialog())
            {
                this.Pic2.Image = new Bitmap(Opfile.FileName);

                Bitmap Pic2 = new Bitmap(this.Pic2.Image);
            }
        }

        private void Mix_Click(object sender, EventArgs e)
        {
            switch (switchNumber)
            {
                case 1:
                    MessageBox.Show("suma");
                    Bitmap picture1 = new Bitmap(Pic1.Image);
                    Bitmap picture2 = new Bitmap(Pic2.Image);
                    Bitmap result = new Bitmap(Pic1.Image);

                    int w = 0, h = 0;
                    if (picture1.Width > picture2.Width)
                    {
                        w = picture2.Width;
                    }
                    else
                    {
                        w = picture1.Width;
                    }

                    if (picture1.Height > picture2.Height)
                    {
                        h = picture2.Height;
                    }
                    else
                    {
                        h = picture1.Height;
                    }

                    for (int y = 0; y < h; y++)
                    {
                        for (int x = 0; x < w; x++)
                        {
                            Color cA = picture1.GetPixel(x, y);
                            Color cB = picture2.GetPixel(x, y);

                            int r3 = cA.R + cB.R;
                            if (r3 > 255)
                            {
                                r3 = 255;
                            }
                            int g3 = cA.G + cB.G;
                            if (g3 > 255)
                            {
                                g3 = 255;
                            }
                            int b3 = cA.B + cB.B;
                            if (b3 > 255)
                            {
                                b3 = 255;
                            }


                            Color cC = Color.FromArgb((r3), (g3), (b3));
                            result.SetPixel(x, y, cC);
                        }
                    }

                    Pic3.Image = result;
                    break;


                case 2:
                    MessageBox.Show("Odejmowanie");
                    picture1 = new Bitmap(Pic1.Image);
                    picture2 = new Bitmap(Pic2.Image);
                    result = new Bitmap(Pic1.Image);

                    w = 0;
                    h = 0;

                    if (picture1.Width > picture2.Width)
                    {
                        w = picture2.Width;
                    }
                    else
                    {
                        w = picture1.Width;
                    }

                    if (picture1.Height > picture2.Height)
                    {
                        h = picture2.Height;
                    }
                    else
                    {
                        h = picture1.Height;
                    }

                    for (int y = 0; y < h; y++)
                    {
                        for (int x = 0; x < w; x++)
                        {
                            Color cA = picture1.GetPixel(x, y);
                            Color cB = picture2.GetPixel(x, y);

                            int r3 = cA.R - cB.R - 1;
                            if (r3 < 0)
                            {
                                r3 = 0;
                            }
                            int g3 = cA.G - cB.G - 1;
                            if (g3 < 0)
                            {
                                g3 = 0;
                            }
                            int b3 = cA.B - cB.B - 1;
                            if (b3 < 0)
                            {
                                b3 = 0;
                            }


                            Color cC = Color.FromArgb((r3), (g3), (b3));
                            result.SetPixel(x, y, cC);
                        }
                    }

                    Pic3.Image = result;
                    break;

                case 3:

                    MessageBox.Show("Roznica");
                    picture1 = new Bitmap(Pic1.Image);
                    picture2 = new Bitmap(Pic2.Image);
                    result = new Bitmap(Pic1.Image);


                    w = 0;
                    h = 0;

                    if (picture1.Width > picture2.Width)
                    {
                        w = picture2.Width;
                    }
                    else
                    {
                        w = picture1.Width;
                    }

                    if (picture1.Height > picture2.Height)
                    {
                        h = picture2.Height;
                    }
                    else
                    {
                        h = picture1.Height;
                    }

                    for (int y = 0; y < h; y++)
                    {
                        for (int x = 0; x < w; x++)
                        {
                            Color cA = picture1.GetPixel(x, y);
                            Color cB = picture2.GetPixel(x, y);

                            int r3 = Math.Abs(cA.R - cB.R);
                            if (r3 > 255)
                            {
                                r3 = 255;
                            }
                            int g3 = Math.Abs(cA.G - cB.G);
                            if (g3 > 255)
                            {
                                g3 = 255;
                            }
                            int b3 = Math.Abs(cA.B - cB.B);
                            if (b3 > 255)
                            {
                                b3 = 255;
                            }


                            Color cC = Color.FromArgb((r3), (g3), (b3));
                            result.SetPixel(x, y, cC);
                        }
                    }

                    Pic3.Image = result;
                    break;

                case 4:

                    MessageBox.Show("Mnozenie");
                    picture1 = new Bitmap(Pic1.Image);
                    picture2 = new Bitmap(Pic2.Image);
                    result = new Bitmap(Pic1.Image);


                    w = 0;
                    h = 0;

                    if (picture1.Width > picture2.Width)
                    {
                        w = picture2.Width;
                    }
                    else
                    {
                        w = picture1.Width;
                    }

                    if (picture1.Height > picture2.Height)
                    {
                        h = picture2.Height;
                    }
                    else
                    {
                        h = picture1.Height;
                    }

                    for (int y = 0; y < h; y++)
                    {
                        for (int x = 0; x < w; x++)
                        {
                            Color cA = picture1.GetPixel(x, y);
                            Color cB = picture2.GetPixel(x, y);

                            double r1 = (double)cA.R / 255;
                            double g1 = (double)cA.G / 255;
                            double b1 = (double)cA.B / 255;

                            double r2 = (double)cB.R / 255;
                            double g2 = (double)cB.G / 255;
                            double b2 = (double)cB.B / 255;

                            int r3 = (int)(r1 * r2 * 255);
                            int g3 = (int)(g1 * g2 * 255);
                            int b3 = (int)(b1 * b2 * 255);

                            Color cC = Color.FromArgb((r3), (g3), (b3));
                            result.SetPixel(x, y, cC);
                        }
                    }

                    Pic3.Image = result;
                    break;

                case 5:

                    MessageBox.Show("Mnozenie odwrotnosci");
                    picture1 = new Bitmap(Pic1.Image);
                    picture2 = new Bitmap(Pic2.Image);
                    result = new Bitmap(Pic1.Image);


                    w = 0;
                    h = 0;

                    if (picture1.Width > picture2.Width)
                    {
                        w = picture2.Width;
                    }
                    else
                    {
                        w = picture1.Width;
                    }

                    if (picture1.Height > picture2.Height)
                    {
                        h = picture2.Height;
                    }
                    else
                    {
                        h = picture1.Height;
                    }

                    for (int y = 0; y < h; y++)
                    {
                        for (int x = 0; x < w; x++)
                        {
                            Color cA = picture1.GetPixel(x, y);
                            Color cB = picture2.GetPixel(x, y);

                            double r1 = (double)cA.R / 255;
                            double g1 = (double)cA.G / 255;
                            double b1 = (double)cA.B / 255;

                            double r2 = (double)cB.R / 255;
                            double g2 = (double)cB.G / 255;
                            double b2 = (double)cB.B / 255;

                            int r3 = (int)((1 - (1 - r1) * (1 - r2)) * 255);
                            int g3 = (int)((1 - (1 - g1) * (1 - g2)) * 255);
                            int b3 = (int)((1 - (1 - b1) * (1 - b2)) * 255);

                            Color cC = Color.FromArgb((r3), (g3), (b3));
                            result.SetPixel(x, y, cC);
                        }
                    }

                    Pic3.Image = result;
                    break;


                case 6:

                    MessageBox.Show("Negacja");
                    picture1 = new Bitmap(Pic1.Image);
                    picture2 = new Bitmap(Pic2.Image);
                    result = new Bitmap(Pic1.Image);


                    w = 0;
                    h = 0;

                    if (picture1.Width > picture2.Width)
                    {
                        w = picture2.Width;
                    }
                    else
                    {
                        w = picture1.Width;
                    }

                    if (picture1.Height > picture2.Height)
                    {
                        h = picture2.Height;
                    }
                    else
                    {
                        h = picture1.Height;
                    }

                    for (int y = 0; y < h; y++)
                    {
                        for (int x = 0; x < w; x++)
                        {
                            Color cA = picture1.GetPixel(x, y);
                            Color cB = picture2.GetPixel(x, y);

                            double r1 = (double)cA.R / 255;
                            double g1 = (double)cA.G / 255;
                            double b1 = (double)cA.B / 255;

                            double r2 = (double)cB.R / 255;
                            double g2 = (double)cB.G / 255;
                            double b2 = (double)cB.B / 255;

                            int r3 = (int)((1 - Math.Abs(1 - r1 - r2)) * 255);
                            int g3 = (int)((1 - Math.Abs(1 - g1 - g2)) * 255);
                            int b3 = (int)((1 - Math.Abs(1 - b1 - b2)) * 255);

                            Color cC = Color.FromArgb((r3), (g3), (b3));
                            result.SetPixel(x, y, cC);
                        }
                    }

                    Pic3.Image = result;
                    break;

                case 7:

                    MessageBox.Show("Ciemniejsze");
                    picture1 = new Bitmap(Pic1.Image);
                    picture2 = new Bitmap(Pic2.Image);
                    result = new Bitmap(Pic1.Image);

                    w = 0;
                    h = 0;

                    if (picture1.Width > picture2.Width)
                    {
                        w = picture2.Width;
                    }
                    else
                    {
                        w = picture1.Width;
                    }

                    if (picture1.Height > picture2.Height)
                    {
                        h = picture2.Height;
                    }
                    else
                    {
                        h = picture1.Height;
                    }

                    for (int y = 0; y < h; y++)
                    {
                        for (int x = 0; x < w; x++)
                        {
                            Color cA = picture1.GetPixel(x, y);
                            Color cB = picture2.GetPixel(x, y);

                            int r1 = cA.R;
                            int g1 = cA.G;
                            int b1 = cA.B;

                            int r2 = cB.R;
                            int g2 = cB.G;
                            int b2 = cB.B;

                            int r3, g3, b3;
                            if (r1 < r2)
                            {
                                r3 = r1;
                            }
                            else
                            {
                                r3 = r2;
                            }
                            if (g1 < g2)
                            {
                                g3 = g1;
                            }
                            else
                            {
                                g3 = g2;
                            }
                            if (b1 < b2)
                            {
                                b3 = b1;
                            }
                            else
                            {
                                b3 = b2;
                            }

                            Color cC = Color.FromArgb((r3), (g3), (b3));
                            result.SetPixel(x, y, cC);
                        }
                    }

                    Pic3.Image = result;
                    break;

                case 8:

                    MessageBox.Show("Jasniejsze");
                    picture1 = new Bitmap(Pic1.Image);
                    picture2 = new Bitmap(Pic2.Image);
                    result = new Bitmap(Pic1.Image);

                    w = 0;
                    h = 0;

                    if (picture1.Width > picture2.Width)
                    {
                        w = picture2.Width;
                    }
                    else
                    {
                        w = picture1.Width;
                    }

                    if (picture1.Height > picture2.Height)
                    {
                        h = picture2.Height;
                    }
                    else
                    {
                        h = picture1.Height;
                    }

                    for (int y = 0; y < h; y++)
                    {
                        for (int x = 0; x < w; x++)
                        {
                            Color cA = picture1.GetPixel(x, y);
                            Color cB = picture2.GetPixel(x, y);

                            int r1 = cA.R;
                            int g1 = cA.G;
                            int b1 = cA.B;

                            int r2 = cB.R;
                            int g2 = cB.G;
                            int b2 = cB.B;

                            int r3, g3, b3;
                            if (r1 > r2)
                            {
                                r3 = r1;
                            }
                            else
                            {
                                r3 = r2;
                            }
                            if (g1 > g2)
                            {
                                g3 = g1;
                            }
                            else
                            {
                                g3 = g2;
                            }
                            if (b1 > b2)
                            {
                                b3 = b1;
                            }
                            else
                            {
                                b3 = b2;
                            }

                            Color cC = Color.FromArgb((r3), (g3), (b3));
                            result.SetPixel(x, y, cC);
                        }
                    }

                    Pic3.Image = result;
                    break;

                case 9:

                    MessageBox.Show("Wylaczenie");
                    picture1 = new Bitmap(Pic1.Image);
                    picture2 = new Bitmap(Pic2.Image);
                    result = new Bitmap(Pic1.Image);


                    w = 0;
                    h = 0;

                    if (picture1.Width > picture2.Width)
                    {
                        w = picture2.Width;
                    }
                    else
                    {
                        w = picture1.Width;
                    }

                    if (picture1.Height > picture2.Height)
                    {
                        h = picture2.Height;
                    }
                    else
                    {
                        h = picture1.Height;
                    }

                    for (int y = 0; y < h; y++)
                    {
                        for (int x = 0; x < w; x++)
                        {
                            Color cA = picture1.GetPixel(x, y);
                            Color cB = picture2.GetPixel(x, y);

                            double r1 = (double)cA.R / 255;
                            double g1 = (double)cA.G / 255;
                            double b1 = (double)cA.B / 255;

                            double r2 = (double)cB.R / 255;
                            double g2 = (double)cB.G / 255;
                            double b2 = (double)cB.B / 255;

                            int r3 = (int)((r1 + r2 - 2 * r1 * r2) * 255);
                            int g3 = (int)((g1 + g2 - 2 * g1 * g2) * 255);
                            int b3 = (int)((b1 + b2 - 2 * b1 * b2) * 255);

                            Color cC = Color.FromArgb((r3), (g3), (b3));
                            result.SetPixel(x, y, cC);
                        }
                    }

                    Pic3.Image = result;
                    break;


                case 10:

                    MessageBox.Show("Nakladka");
                    picture1 = new Bitmap(Pic1.Image);
                    picture2 = new Bitmap(Pic2.Image);
                    result = new Bitmap(Pic1.Image);

                    w = 0;
                    h = 0;

                    if (picture1.Width > picture2.Width)
                    {
                        w = picture2.Width;
                    }
                    else
                    {
                        w = picture1.Width;
                    }

                    if (picture1.Height > picture2.Height)
                    {
                        h = picture2.Height;
                    }
                    else
                    {
                        h = picture1.Height;
                    }

                    for (int y = 0; y < h; y++)
                    {
                        for (int x = 0; x < w; x++)
                        {
                            Color cA = picture1.GetPixel(x, y);
                            Color cB = picture2.GetPixel(x, y);

                            double r1 = (double)cA.R / 255;
                            double g1 = (double)cA.G / 255;
                            double b1 = (double)cA.B / 255;

                            double r2 = (double)cB.R / 255;
                            double g2 = (double)cB.G / 255;
                            double b2 = (double)cB.B / 255;

                            int r3, g3, b3;
                            if (r1 < 0.5)
                            {
                                r3 = (int)((2 * r1 * r2) * 255);
                            }
                            else
                            {
                                r3 = (int)((1 - 2 * (1 - r1) * (1 - r2)) * 255);
                            }
                            if (g1 < 0.5)
                            {
                                g3 = (int)((2 * g1 * g2) * 255);
                            }
                            else
                            {
                                g3 = (int)((1 - 2 * (1 - g1) * (1 - g2)) * 255);
                            }
                            if (b1 < 0.5)
                            {
                                b3 = (int)((2 * b1 * b2) * 255);
                            }
                            else
                            {
                                b3 = (int)((1 - 2 * (1 - b1) * (1 - b2)) * 255);
                            }

                            Color cC = Color.FromArgb((r3), (g3), (b3));
                            result.SetPixel(x, y, cC);
                        }
                    }

                    Pic3.Image = result;
                    break;

                case 11:
                    MessageBox.Show("Ostre swiatlo");
                    picture1 = new Bitmap(Pic1.Image);
                    picture2 = new Bitmap(Pic2.Image);
                    result = new Bitmap(Pic1.Image);

                    w = 0;
                    h = 0;

                    if (picture1.Width > picture2.Width)
                    {
                        w = picture2.Width;
                    }
                    else
                    {
                        w = picture1.Width;
                    }

                    if (picture1.Height > picture2.Height)
                    {
                        h = picture2.Height;
                    }
                    else
                    {
                        h = picture1.Height;
                    }

                    for (int y = 0; y < h; y++)
                    {
                        for (int x = 0; x < w; x++)
                        {
                            Color cA = picture1.GetPixel(x, y);
                            Color cB = picture2.GetPixel(x, y);

                            double r1 = (double)cA.R / 255;
                            double g1 = (double)cA.G / 255;
                            double b1 = (double)cA.B / 255;

                            double r2 = (double)cB.R / 255;
                            double g2 = (double)cB.G / 255;
                            double b2 = (double)cB.B / 255;

                            int r3, g3, b3;
                            if (r2 < 0.5)
                            {
                                r3 = (int)((2 * r1 * r2) * 255);
                            }
                            else
                            {
                                r3 = (int)((1 - 2 * (1 - r1) * (1 - r2)) * 255);
                            }
                            if (g2 < 0.5)
                            {
                                g3 = (int)((2 * g1 * g2) * 255);
                            }
                            else
                            {
                                g3 = (int)((1 - 2 * (1 - g1) * (1 - g2)) * 255);
                            }
                            if (b2 < 0.5)
                            {
                                b3 = (int)((2 * b1 * b2) * 255);
                            }
                            else
                            {
                                b3 = (int)((1 - 2 * (1 - b1) * (1 - b2)) * 255);
                            }


                            Color cC = Color.FromArgb((r3), (g3), (b3));
                            result.SetPixel(x, y, cC);
                        }
                    }

                    Pic3.Image = result;
                    break;

                case 12:
                    MessageBox.Show("Lagodne swiatlo");
                    picture1 = new Bitmap(Pic1.Image);
                    picture2 = new Bitmap(Pic2.Image);
                    result = new Bitmap(Pic1.Image);

                    w = 0;
                    h = 0;

                    if (picture1.Width > picture2.Width)
                    {
                        w = picture2.Width;
                    }
                    else
                    {
                        w = picture1.Width;
                    }

                    if (picture1.Height > picture2.Height)
                    {
                        h = picture2.Height;
                    }
                    else
                    {
                        h = picture1.Height;
                    }

                    for (int y = 0; y < h; y++)
                    {
                        for (int x = 0; x < w; x++)
                        {
                            Color cA = picture1.GetPixel(x, y);
                            Color cB = picture2.GetPixel(x, y);

                            double r1 = (double)cA.R / 255;
                            double g1 = (double)cA.G / 255;
                            double b1 = (double)cA.B / 255;

                            double r2 = (double)cB.R / 255;
                            double g2 = (double)cB.G / 255;
                            double b2 = (double)cB.B / 255;

                            int r3, g3, b3;
                            if (r2 < 0.5)
                            {
                                r3 = (int)((((2 * r1 * r2) + (r1 * r1) * (1 - 2 * r2))) * 255);
                            }
                            else
                            {
                                r3 = (int)(((Math.Sqrt(r1) * (2 * r2 - 1) + (2 * r1) * (1 - r2))) * 255);
                            }
                            if (g2 < 0.5)
                            {
                                g3 = (int)((((2 * g1 * g2) + (g1 * g1) * (1 - 2 * g2))) * 255);
                            }
                            else
                            {
                                g3 = (int)(((Math.Sqrt(g1) * (2 * g2 - 1) + (2 * g1) * (1 - g2))) * 255);
                            }
                            if (b2 < 0.5)
                            {
                                b3 = (int)((((2 * b1 * b2) + (b1 * b1) * (1 - 2 * b2))) * 255);
                            }
                            else
                            {
                                b3 = (int)(((Math.Sqrt(b1) * (2 * b2 - 1) + (2 * b1) * (1 - b2))) * 255);
                            }

                            Color cC = Color.FromArgb((r3), (g3), (b3));
                            result.SetPixel(x, y, cC);
                        }
                    }

                    Pic3.Image = result;
                    break;


                case 13:

                    MessageBox.Show("Rozcienczenie");
                    picture1 = new Bitmap(Pic1.Image);
                    picture2 = new Bitmap(Pic2.Image);
                    result = new Bitmap(Pic1.Image);


                    w = 0;
                    h = 0;

                    if (picture1.Width > picture2.Width)
                    {
                        w = picture2.Width;
                    }
                    else
                    {
                        w = picture1.Width;
                    }

                    if (picture1.Height > picture2.Height)
                    {
                        h = picture2.Height;
                    }
                    else
                    {
                        h = picture1.Height;
                    }

                    for (int y = 0; y < h; y++)
                    {
                        for (int x = 0; x < w; x++)
                        {
                            Color cA = picture1.GetPixel(x, y);
                            Color cB = picture2.GetPixel(x, y);

                            double r1 = (double)cA.R / 255;
                            double g1 = (double)cA.G / 255;
                            double b1 = (double)cA.B / 255;

                            double r2 = (double)cB.R / 255;
                            double g2 = (double)cB.G / 255;
                            double b2 = (double)cB.B / 255;

                            int r3 = (int)((r1 / (1 - r2)) * 255);
                            int g3 = (int)((g1 / (1 - g2)) * 255);
                            int b3 = (int)((b1 / (1 - b2)) * 255);

                            if (r3 > 255)
                            {
                                r3 = 255;
                            }
                            if (g3 > 255)
                            {
                                g3 = 255;
                            }
                            if (b3 > 255)
                            {
                                b3 = 255;
                            }

                            Color cC = Color.FromArgb((r3), (g3), (b3));
                            result.SetPixel(x, y, cC);
                        }
                    }

                    Pic3.Image = result;
                    break;

                case 14:

                    MessageBox.Show("Wypalenie");
                    picture1 = new Bitmap(Pic1.Image);
                    picture2 = new Bitmap(Pic2.Image);
                    result = new Bitmap(Pic1.Image);


                    w = 0;
                    h = 0;

                    if (picture1.Width > picture2.Width)
                    {
                        w = picture2.Width;
                    }
                    else
                    {
                        w = picture1.Width;
                    }

                    if (picture1.Height > picture2.Height)
                    {
                        h = picture2.Height;
                    }
                    else
                    {
                        h = picture1.Height;
                    }

                    for (int y = 0; y < h; y++)
                    {
                        for (int x = 0; x < w; x++)
                        {
                            Color cA = picture1.GetPixel(x, y);
                            Color cB = picture2.GetPixel(x, y);

                            double r1 = (double)cA.R / 255;
                            double g1 = (double)cA.G / 255;
                            double b1 = (double)cA.B / 255;

                            double r2 = (double)cB.R / 255;
                            double g2 = (double)cB.G / 255;
                            double b2 = (double)cB.B / 255;

                            int r3 = (int)((1 - (1 - r1) / r2) * 255);
                            int g3 = (int)((1 - (1 - g1) / g2) * 255);
                            int b3 = (int)((1 - (1 - b1) / b2) * 255);

                            if (r3 < 0)
                            {
                                r3 = 0;
                            }
                            if (g3 < 0)
                            {
                                g3 = 0;
                            }
                            if (b3 < 0)
                            {
                                b3 = 0;
                            }

                            Color cC = Color.FromArgb((r3), (g3), (b3));
                            result.SetPixel(x, y, cC);
                        }
                    }

                    Pic3.Image = result;
                    break;

                case 15:

                    MessageBox.Show("Reflect mode");
                    picture1 = new Bitmap(Pic1.Image);
                    picture2 = new Bitmap(Pic2.Image);
                    result = new Bitmap(Pic1.Image);


                    w = 0;
                    h = 0;

                    if (picture1.Width > picture2.Width)
                    {
                        w = picture2.Width;
                    }
                    else
                    {
                        w = picture1.Width;
                    }

                    if (picture1.Height > picture2.Height)
                    {
                        h = picture2.Height;
                    }
                    else
                    {
                        h = picture1.Height;
                    }

                    for (int y = 0; y < h; y++)
                    {
                        for (int x = 0; x < w; x++)
                        {
                            Color cA = picture1.GetPixel(x, y);
                            Color cB = picture2.GetPixel(x, y);

                            double r1 = (double)cA.R / 255;
                            double g1 = (double)cA.G / 255;
                            double b1 = (double)cA.B / 255;

                            double r2 = (double)cB.R / 255;
                            double g2 = (double)cB.G / 255;
                            double b2 = (double)cB.B / 255;

                            int r3 = (int)((r1 * r1 / (1 - r2)) * 255);
                            int g3 = (int)((g1 * g1 / (1 - g2)) * 255);
                            int b3 = (int)((b1 * b1 / (1 - b2)) * 255);

                            if (r3 > 255)
                            {
                                r3 = 255;
                            }
                            if (g3 > 255)
                            {
                                g3 = 255;
                            }
                            if (b3 > 255)
                            {
                                b3 = 255;
                            }

                            Color cC = Color.FromArgb((r3), (g3), (b3));
                            result.SetPixel(x, y, cC);
                        }
                    }

                    Pic3.Image = result;
                    break;
            }

        }

        private void Suma_CheckedChanged(object sender, EventArgs e)
        {
            switchNumber = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            switchNumber = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            switchNumber = 3;
        }

        private void Mnozenie_CheckedChanged(object sender, EventArgs e)
        {
            switchNumber = 4;
        }

        private void mnozenieOdwrotnosci_CheckedChanged(object sender, EventArgs e)
        {
            switchNumber = 5;
        }

        private void Negacja_CheckedChanged(object sender, EventArgs e)
        {
            switchNumber = 6;
        }

        private void Ciemniejsze_CheckedChanged(object sender, EventArgs e)
        {
            switchNumber = 7;
        }

        private void Jasniejsze_CheckedChanged(object sender, EventArgs e)
        {
            switchNumber = 8;
        }

        private void Wylaczenie_CheckedChanged(object sender, EventArgs e)
        {
            switchNumber = 9;
        }

        private void Nakladka_CheckedChanged(object sender, EventArgs e)
        {
            switchNumber = 10;
        }

        private void ostreSwiatlo_CheckedChanged(object sender, EventArgs e)
        {
            switchNumber = 11;
        }

        private void lagodneSwiatlo_CheckedChanged(object sender, EventArgs e)
        {
            switchNumber = 12;
        }

        private void Rozcienczenie_CheckedChanged(object sender, EventArgs e)
        {
            switchNumber = 13;
        }

        private void Wypalenie_CheckedChanged(object sender, EventArgs e)
        {
            switchNumber = 14;
        }

        private void reflectMode_CheckedChanged(object sender, EventArgs e)
        {
            switchNumber = 15;
        }

        private void Przezroczystosc_CheckedChanged(object sender, EventArgs e)
        {
            switchNumber = 15;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Bitmap picture1 = new Bitmap(Pic1.Image);
            Bitmap picture2 = new Bitmap(Pic2.Image);
            Bitmap result = new Bitmap(Pic1.Image);


            int w = 0;
            int h = 0;

            if (picture1.Width > picture2.Width)
            {
                w = picture2.Width;
            }
            else
            {
                w = picture1.Width;
            }

            if (picture1.Height > picture2.Height)
            {
                h = picture2.Height;
            }
            else
            {
                h = picture1.Height;
            }

            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    Color cA = picture1.GetPixel(x, y);
                    Color cB = picture2.GetPixel(x, y);

                    double r1 = (double)cA.R / 255;
                    double g1 = (double)cA.G / 255;
                    double b1 = (double)cA.B / 255;

                    double r2 = (double)cB.R / 255;
                    double g2 = (double)cB.G / 255;
                    double b2 = (double)cB.B / 255;

                    double r3 = ((1 - (double)(trackBar1.Value) / 10) * r2) + (((double)(trackBar1.Value) / 10) * r1);
                    double g3 = ((1 - (double)(trackBar1.Value) / 10) * g2) + (((double)(trackBar1.Value) / 10) * g1);
                    double b3 = ((1 - (double)(trackBar1.Value) / 10) * b2) + (((double)(trackBar1.Value) / 10) * b1);

                    r3 *= 255;
                    g3 *= 255;
                    b3 *= 255;


                    if (r3 > 255)
                    {
                        r3 = 255;
                    }
                    if (g3 > 255)
                    {
                        g3 = 255;
                    }
                    if (b3 > 255)
                    {
                        b3 = 255;
                    }

                    Color cC = Color.FromArgb(((int)r3), ((int)g3), ((int)b3));
                    result.SetPixel(x, y, cC);
                }
            }

            Pic3.Image = result;
        }

        private void Opaticity_Scroll(object sender, EventArgs e)
        {
            BrightnessContrast();
        }

        private void Contrast_Scroll(object sender, EventArgs e)
        {
            BrightnessContrast();
        }


        private void Open3_Click(object sender, EventArgs e)
        {
            OpenFileDialog Opfile = new OpenFileDialog();
            if (DialogResult.OK == Opfile.ShowDialog())
            {
                Pic4 = (Bitmap)Bitmap.FromFile(Opfile.FileName);
                Pic3.Image = Pic4;
            }
        }


        private void BrightnessContrast()
        {
            Bitmap bitmapEdited;

            bitmapEdited = (Bitmap)Pic4.Clone();

            for (int y = 0; y < Pic3.Image.Height; y++)
            {
                for (int x = 0; x < Pic3.Image.Width; x++)
                {

                    Color p = bitmapEdited.GetPixel(x, y);

                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    if (((Contrast.Value / 100) * r) + BrightnessBar.Value > 255)
                    {
                        r = 255;
                    }
                    else if (((Contrast.Value / 100) * r) + BrightnessBar.Value < 0)
                    {
                        r = 0;
                    }
                    else
                    {
                        r = ((Contrast.Value / 100) * r) + BrightnessBar.Value;
                    }
                    if (((Contrast.Value / 100) * g) + BrightnessBar.Value > 255)
                    {
                        g = 255;
                    }
                    else if (((Contrast.Value / 100) * g) + BrightnessBar.Value < 0)
                    {
                        g = 0;
                    }
                    else
                    {
                        g = ((Contrast.Value / 100) * g) + BrightnessBar.Value;
                    }
                    if (((Contrast.Value / 100) * b) + BrightnessBar.Value > 255)
                    {
                        b = 255;
                    }
                    else if (((Contrast.Value / 100) * b) + BrightnessBar.Value < 0)
                    {
                        b = 0;
                    }
                    else
                    {
                        b = ((Contrast.Value / 100) * b) + BrightnessBar.Value;
                    }
                    bitmapEdited.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            Pic3.Image = bitmapEdited;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            potegowa();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            potegowa();
        }

        private void potegowa()
        {
            Bitmap bitmapEdited;

            bitmapEdited = (Bitmap)Pic4.Clone();
            for (int y = 0; y < Pic3.Image.Height; y++)
            {
                for (int x = 0; x < Pic3.Image.Width; x++)
                {

                    Color p = bitmapEdited.GetPixel(x, y);


                    double r = (double)p.R / 255;
                    double g = (double)p.G / 255;
                    double b = (double)p.B / 255;

                    r = ((double)(trackBar3.Value) / 10) * (Math.Pow(r, ((double)(trackBar2.Value) / 10)));
                    g = ((double)(trackBar3.Value) / 10) * (Math.Pow(g, ((double)(trackBar2.Value) / 10)));
                    b = ((double)(trackBar3.Value) / 10) * (Math.Pow(b, ((double)(trackBar2.Value) / 10)));

                    r = r * 255;
                    g = g * 255;
                    b = b * 255;

                    if (r > 255)
                    {
                        r = 255;
                    }
                    if (r < 0)
                    {
                        r = 0;
                    }

                    if (g > 255)
                    {
                        g = 255;
                    }
                    if (g < 0)
                    {
                        g = 0;
                    }

                    if (b > 255)
                    {
                        b = 255;
                    }
                    if (b < 0)
                    {
                        b = 0;
                    }

                    bitmapEdited.SetPixel(x, y, Color.FromArgb((int)r, (int)g, (int)b));
                }
            }

            Pic3.Image = bitmapEdited;
        }

       

        
    }
}
