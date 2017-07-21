/* File Prolouge
   Name: Howard Brown
   Project: Lab 15
   Date: 20 July 2017

   I declare that the following source code was written soley by me.
   I understand that copying any source code, in whole or in part,
   constitutes cheating, and that I will receive a zero on this project
   if I am found in violation of this policy.
  
    */

using System;
using System.Windows.Forms;

namespace HB_Lab15
{
    public partial class Form1 : Form
    {
        private Triangle t;
        public Form1()
        {
            InitializeComponent();
        }
        // Name: butonCalculate_Click
        // Purpose: Adds the values to the text boxes
        // Parameters: none
        // Return: none
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double sideA = double.Parse(textBoxSideA.Text);
            double sideB = double.Parse(textBoxSideB.Text);
            t = new Triangle(sideA, sideB);
            textBoxHypotenuse.Text = $"{t.CalcHypotenuse():F2}";
            textBoxArea.Text = $"{t.CalcArea():F2}";
        }
        // Name: buttonClear_Click
        // Purpose: Clears the form
        // Parameters: none
        // Return: none
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSideA.Clear();
            textBoxSideB.Clear();
            textBoxHypotenuse.Clear();
            textBoxArea.Clear();
        }
        // Name: aboutToolStripMenuItem_Click
        // Purpose: Displays a message box with Assignment information upon clicking "About"
        // Parameters: none
        // Return: none
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CS1400\nLab 15\nHoward Brown\n20 July 2017");
        }
        // Name: exitToolStripMenuItem_Click
        // Purpose: Closes the program
        // Parameters: none
        // Return: none
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
