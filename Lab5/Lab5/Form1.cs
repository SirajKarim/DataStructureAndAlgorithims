using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[] x = new double[15];
        double[] y = new double[15];
        void method()
        {
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = i;
            }
            for (int i = 0; i < x.Length; i++)
            {
                x[i]=(Math.Pow(y[i],2));
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            method();
            chart1.Series["Series1"].Points.DataBindXY(x,y);

        }
    }
}
