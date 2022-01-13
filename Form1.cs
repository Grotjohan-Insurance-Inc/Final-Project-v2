using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtGridLocation.Text = "Insert a Pixel Size to see it's size on the Grid!";
            txtGridLocation.ForeColor = Color.Gray;
            txtOutput.Text = "Insert a Pixel Size to see the Aspect Ratio!";
            txtOutput.ForeColor = Color.Gray;
        }
        
        public void AspectRatioCalculator()
        {

            double dNumber1 = Convert.ToDouble(txtNumber1.Text);
            double dNumber2 = Convert.ToDouble(txtNumber2.Text);
            double dGCF = 0;
            double dMin = Math.Min(dNumber1, dNumber2);
            double dNumber3 = 0;
            double dNumber4 = 0;
            double dNumber5 = 0;
            double dNumber6 = 0;
            for (int i = 0; i <= dMin; i++)
            {
                if ((dNumber1 % i == 0) && (dNumber2 % i == 0) && (i > 0))
                {
                    dGCF = i;
                }

            }
            dNumber3 = dNumber1 / dGCF;
            dNumber4 = dNumber2 / dGCF;
            txtOutput.Text = dNumber3 + ":" + dNumber4;
            dNumber5 = dNumber1 / 3;
            dNumber6 = dNumber2 / 3;

            txtOutput.ForeColor = Color.Black;

            txtGridSize.Text = dNumber5 + ":" + dNumber6;

            pictureBox1.BackColor = Color.DarkGray;
            pictureBox2.BackColor = Color.DarkGray;
            pictureBox3.BackColor = Color.DarkGray;
            pictureBox4.BackColor = Color.DarkGray;
            pictureBox5.BackColor = Color.DarkGray;
            pictureBox6.BackColor = Color.DarkGray;
            pictureBox7.BackColor = Color.DarkGray;
            pictureBox8.BackColor = Color.DarkGray;
            pictureBox9.BackColor = Color.DarkGray;

            Size RuleOfThirdsGraph = new Size((int)dNumber5, (int) dNumber6);
            pictureBox1.Size = RuleOfThirdsGraph;
            pictureBox2.Size = RuleOfThirdsGraph;
            pictureBox3.Size = RuleOfThirdsGraph;
            pictureBox4.Size = RuleOfThirdsGraph;
            pictureBox5.Size = RuleOfThirdsGraph;
            pictureBox6.Size = RuleOfThirdsGraph;
            pictureBox7.Size = RuleOfThirdsGraph;
            pictureBox8.Size = RuleOfThirdsGraph;
            pictureBox9.Size = RuleOfThirdsGraph;

            txtGridSize.Text = "This Pixel Size is " + dNumber5 + ":" + dNumber6 + ".";
        }

        public void GridPixelCalculator()
        {
            txtGridLocation.ForeColor = Color.Black;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            AspectRatioCalculator();
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            GridPixelCalculator();
            txtGridLocation.Text = "This is the grid (1,1)";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GridPixelCalculator();
            txtGridLocation.Text = "This is the grid (2,1)";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GridPixelCalculator();
            txtGridLocation.Text = "This is the grid (3,1)";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            GridPixelCalculator();
            txtGridLocation.Text = "This is the grid (1,2)";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            GridPixelCalculator();
            txtGridLocation.Text = "This is the grid (2,2)";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GridPixelCalculator();
            txtGridLocation.Text = "This is the grid (3,2)";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            GridPixelCalculator();
            txtGridLocation.Text = "This is the grid (1,3)";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            GridPixelCalculator();
            txtGridLocation.Text = "This is the grid (2,3)";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            GridPixelCalculator();
            txtGridLocation.Text = "This is the grid (3,3)";
        }
    }
}
