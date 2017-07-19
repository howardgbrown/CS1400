// File Prolouge
// Name: Howard Brown
// Project: Project 01
// Date: 28 June 2017


//I either wrote this myself or goto it from my instructor
//obtaining code from any other source is cheating for which I will receive a zero.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HB_Project_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Howard Brown\nCS 1400\nProject 1");
        }
        // Name: amountBox_Leave
        // Purpose: This will make so that when the user tabs out of
        // the box it will calulate the next fields
        private void amountBox_Leave(object sender, EventArgs e)
        {
            const double BAD = 1.1;
            const double GOOD = 1.15;
            const double GREAT = 1.2;
            double amount = double.Parse(amountBox.Text);
            double poorService = amount * BAD;
            double avgService = amount * GOOD;
            double exelService = amount * GREAT;
            string outStr1 = $"{poorService:C}";
            string outStr2 = $"{avgService:C}";
            string outStr3 = $"{exelService:C}";
            poorServiceBox.Text = outStr1;
            averageServiceBox.Text = outStr2;
            excellentServiceBox.Text = outStr3;

            // I tried to clean it up and make it show it had less variables.
            // The code below is the result. It runs the same, just looks
            // cleaner.

            //const double BAD = 1.1;
            //const double GOOD = 1.15;
            //const double GREAT = 1.2;
            //double amount = double.Parse(amountBox.Text);
            //string outStr1 = $"{amount * BAD:C}";
            //string outStr2 = $"{amount * GOOD:C}";
            //string outStr3 = $"{amount * GREAT:C}";
            //poorServiceBox.Text = outStr1;
            //averageServiceBox.Text = outStr2;
            //excellentServiceBox.Text = outStr3;

            // Then I refactored it and use method extract to make it
            // even cleaner. Again, it runs the same but is much less code.

            //const double BAD = 1.1;
            //const double GOOD = 1.15;
            //const double GREAT = 1.2;
            //double amount = double.Parse(amountBox.Text);
            //poorServiceBox.Text = CalulatePoorServiceTip(amount);
            //averageServiceBox.Text = CalulateGoodServiceTip(amount);
            //excellentServiceBox.Text = CalulateGreatServiceTip(amount);
        }
    }
}
