using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CALC
{

    public partial class CalcForm : Form
    {
        string path = Properties.Settings.Default.path;
        public CalcForm()
        {
            InitializeComponent();
        }
        

        private void FormCalc_Load(object sender, EventArgs e)
        {
            pathBox.Text = Properties.Settings.Default.path;
            string[] xzLines = System.IO.File.ReadAllLines(path);

            

            double xCenter = Convert.ToDouble(xzLines[0]);
            double zCenter = Convert.ToDouble(xzLines[1]);

            xBox.Text = Convert.ToString(xCenter);
            zBox.Text = Convert.ToString(zCenter);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = pathBox.Text;
            Properties.Settings.Default.path = path;
            string[] xzLines = System.IO.File.ReadAllLines(path);

            double xCenter = Convert.ToDouble(xzLines[0]);
            double zCenter = Convert.ToDouble(xzLines[1]);

            xBox.Text = Convert.ToString(xCenter);
            zBox.Text = Convert.ToString(zCenter);

            double xdist = Convert.ToDouble(xInput.Text) - xCenter;
            double zdist = Convert.ToDouble(zInput.Text) - zCenter;
            double angle = Convert.ToDouble(angleBox.Text);
            double rads = Math.PI * angle / 180.0;
            double cosAngle = Math.Cos(rads);
            double sinAngle = Math.Sin(rads);
            double preXout = (xdist * cosAngle) + (zdist * sinAngle);
            double preZout = (zdist * cosAngle) - (xdist * sinAngle);
            double xOut = Math.Round((xCenter + preXout),4);
            double zOut = Math.Round((zCenter + preZout),4);

            xOutput.Text = Convert.ToString(xOut);
            zOutput.Text = Convert.ToString(zOut);
            angleBox.Text = Convert.ToString(angle);

            Properties.Settings.Default.Save();          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void zOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
