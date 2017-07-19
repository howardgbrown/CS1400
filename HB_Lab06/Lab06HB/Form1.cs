// File Prologue
// Name: Howard Brown
// Project: Lab06
// Date: 7/5/2017

// I either wrote this myself or got it from my instructor
// obtaining code from any other source is cheating for which I will receive a zero.

using System;
using System.Windows.Forms;

namespace Lab06HB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // Name: exitToolShipMenuItem
        // Purpose: Clicking the word exit will close the program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        // Name: aboutToolStripMenuItem
        // Purpose: Clicking the word about will open a message
        // with information about this assignment
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Howard Brown\nCS 1400\nLab 06");
        }

        
        // Name: DiameterBox_Leave
        // Purpose: This will make it so that when the user tabs it will move the
        // cursor to the next box and add the calculation to the second
        // text box
        private void DiameterBox_Leave(object sender, EventArgs e)
        {

            // text Diameter   event = Leave
            // text turns per mile
            // button Clear   event = Click
            //
            // Variables
            // const int INCHES_PER_FOOT = 12
            // const int FEET_PER_MILE = 5280
            // int diameter
            // double circumference
            // double turnsPerMile
            //
            // Input
            // Parse input from textbox as an int
            //
            // Process
            // Calculate circumference as diameter * PI / INCHES_PER_FOOT
            // Calulate turns as FEET_PER_MILE / circumference
            //
            // Output 
            // Output turns in textbox as whole number



        }
        // Name ClearButton_Click
        // By clicking on this it will clear the text boxes and move the
        // cursor to the first box
        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear First textbox
            // Clear second textbox
            // Move cursor to first text
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
