using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bitmap_image_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int height = 500;
            int width = 500;
            int a, r, g, b = 255;
            Bitmap bmp = new Bitmap(height, width);
            Random rand = new Random();
            for (int i = 0; i <width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    a=rand.Next(255);
                    r = rand.Next(255);
                    g = rand.Next(251);
                    b = rand.Next(250);
                    bmp.SetPixel(i,j,Color.FromArgb(a,r,g,b));
                }
            }
            pictureBox1.Image = bmp;
            bmp.Save("RandomImage.png");

        }
    }
}
