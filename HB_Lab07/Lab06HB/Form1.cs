// File Prologue
// Name: Howard Brown
// Project: Lab07
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
        // Name: ezxitToolStripMenuItem
        // Purpose: By clicking on the word exit, it will close
        // the program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        // Name: aboutToolStripMenuItem
        // Purpose: Clicking on the word About displays a message
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


            // Variables
            const int INCHES_PER_FOOT = 12; // const int INCHES_PER_FOOT = 12
            const int FEET_PER_MILE = 5280; // const int FEET_PER_MILE = 5280
            int diameter;                   // int diameter
            double circumference;           // double circumference
            double turnsPerMile;            // double turnsPerMile
            
            // Input
            diameter = int.Parse(DiameterBox.Text); // Parse input from textbox as an int
            //
            // Process
            circumference = diameter * Math.PI / INCHES_PER_FOOT; // Calculate circumference as diameter * PI / INCHES_PER_FOOT
            turnsPerMile = FEET_PER_MILE / circumference; // Calulate turns as FEET_PER_MILE / circumference
            //
            // Output 
            textBox2.Text = $"{turnsPerMile:F0}"; // Output turns in textbox as whole number



        }
        // Name: ClearButton_Click
        // By clicking on this it will clear the text boxes and move the
        // cursor to the first box
        private void ClearButton_Click(object sender, EventArgs e)
        {
            DiameterBox.Clear();           // Clear First textbox
            textBox2.Clear();              // Clear second textbox
            DiameterBox.Focus();           // Move cursor to first text
        }
    }
}
