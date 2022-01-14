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
            // I wrote these as the first thing when executed because I wanted to purely for aesthetic purposes inside the box
            InitializeComponent();
            txtOutput.Text = "Insert a Pixel Size to see the Aspect Ratio!";
            txtOutput.ForeColor = Color.Gray;
        }
        //This is my method in which when I press my buttons, both for uploading an image or just standalone calculating the aspect ratio
        public void AspectRatioCalculator()
        {
            //Here I converted my text boxes to doubles because it was easier to use them in regards to using math
            double dNumber1 = Convert.ToDouble(txtNumber1.Text);
            double dNumber2 = Convert.ToDouble(txtNumber2.Text);
            //Declared my Greatest common factor here and set it to 0
            double dGCF = 0;
            //Used the math formula to calculate the minimum for the two numbers which will be used in our for loop to tell the loop to stop when the variable
            //Is less than the minimum to avoid infinity
            double dMin = Math.Min(dNumber1, dNumber2);
            //Declared my aspect ratio numbers which are stringed to show the aspect ratio in the output text box
            double dAspectRatio1 = 0;
            double dAspectRatio2 = 0;
            //This is the reduced aspect ratio which is shown to the viewer at a reduced scale so the can visualize the photo
            double dReducedAspectRatio1 = 0;
            double dReducedAspectRatio2 = 0;
            //This for loop loops everytime there until the variable is less than or equal to the Minimum
            for (int i = 0; i <= dMin; i++)
            {
                // This if statement only works if both numbers are perfectly divisible and i is greater than 0
                if ((dNumber1 % i == 0) && (dNumber2 % i == 0) && (i > 0))
                {
                    //Obviously this gives us our answer of the GCF
                    dGCF = i;
                }

            }
            //From here the Aspect Ratio is the original number divided by the GCF
            dAspectRatio1 = dNumber1 / dGCF;
            dAspectRatio2 = dNumber2 / dGCF;
            //And thus you string it here
            txtOutput.Text = dAspectRatio1 + ":" + dAspectRatio2;
            //The reeduces Aspect Ratio is the users original numbers divided by 3 so that it doesnt explode the image on the
            //Window and can actually be viewable to get a visual of, hence the 0.3 scale.
            dReducedAspectRatio1 = dNumber1 / 3;
            dReducedAspectRatio2 = dNumber2 / 3;
            //This is again for aesthetic purposes to change the colour back to black so it's not grey when presented the answer
            txtOutput.ForeColor = Color.Black;
            //And strings over to the textbox
            txtGridSize.Text = dReducedAspectRatio1 + ":" + dReducedAspectRatio2;
            //This creates the box as dark grey if no image is selected
            pictureBox1.BackColor = Color.DarkGray;
            //And makes the picture box the reduced size
            Size RuleOfThirdsGraph = new Size((int)dReducedAspectRatio1, (int)dReducedAspectRatio2);
            pictureBox1.Size = RuleOfThirdsGraph;
            //Then outputs this
            txtGridSize.Text = "The Scaled Down Size shown is " + dReducedAspectRatio1 + ":" + dReducedAspectRatio2 + ".";
        }
        //when the button is pressed it then calls back to the Aspect Ratio Calculator Method because I need the same math for this button
        //with no image...
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            AspectRatioCalculator();
        }
        //and this button with an image
        private void btnUpload_Click(object sender, EventArgs e)
        {
            AspectRatioCalculator();
            //This line of code I learned through a course I took for C# which allows the user to upload a JPG or PNG to display their image in that aspect ratio
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPG|*.jpg|PNG|*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Bitmap.FromFile(openFileDialog.FileName);
            }
        }
    }
}
