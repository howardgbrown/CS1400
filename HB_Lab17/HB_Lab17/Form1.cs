/* File Prolouge
   Name: Howard Brown
   Project: Lab 17
   Date: 24 July 2017

   I declare that the following source code was written soley by me.
   I understand that copying any source code, in whole or in part,
   constitutes cheating, and that I will receive a zero on this project
   if I am found in violation of this policy.
  
*/

using System;
using System.Windows.Forms;

namespace HB_Lab17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Name: aboutToolStripMenuItem_Click
        // Purpose: Shows project info upon clicking "About"
        // Parameters: None
        // Return: None
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CS 1400\nLab 17\nHoward Brown\n24 July 2017");
        }
        // Name: exitToolStripMenuItem_Click
        // Purpose: Closes the program upon clicking "Exit"
        // Parameters: None
        // Return: None
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        // Name: radioSameDay_CheckedChange
        // Purpose: Shows if the radio button is checked
        // Parameters: None
        // Return: None
        private void radioSameDay_CheckedChanged(object sender, EventArgs e)
        {

        }
        // Name: radioExpress_CheckedChange
        // Purpose: Shows if the radio button is checked
        // Parameters: None
        // Return: None
        private void radioExpress_CheckedChanged(object sender, EventArgs e)
        {

        }
        // Name: radioStandard_CheckedChange
        // Purpose: Shows if the radio button is checked
        // Parameters: None
        // Return: None
        private void radioStandard_CheckedChanged(object sender, EventArgs e)
        {

        }
        // Name: selectButton_Click
        // Purpose: Opens Message Box displaying choice of shipping method
        // Parameters: None
        // Return: None
        private void selectButton_Click(object sender, EventArgs e)
        {
            string s1 = "Same Day Shipping selected";
            string s2 = "Express Shipping selected";
            string s3 = "Standard Shipping selected";

            if (radioSameDay.Checked)
                MessageBox.Show($"{s1}");
            else if (radioExpress.Checked)
                MessageBox.Show($"{s2}");
            else if (radioStandard.Checked)
                MessageBox.Show($"{s3}");
        }

    }
}
