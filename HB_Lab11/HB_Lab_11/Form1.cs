/* File Prolouge
   Name: Howard Brown
   Project: Lab 11
   Date: 14 July 2017
 */
using System;
using System.Windows.Forms;
using static System.Math;

namespace HB_Lab_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
           Name: CalcHypotenuse
           Purpose: Calculates the hypotenuse of a right triangle
           Parameters: Side1 and Side2
           Return: Side3
        */
        static double CalcHypotenuse(double side1, double side2)
        {
            double hypotenuse = Sqrt(Pow(side1, 2) + Pow(side2, 2));
            return hypotenuse;

        }

        /* Name: aboutToolStripMenuItem_Click
         Purpose: Show the "About" menu
         Parameters: None
         Return: None
         */
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CS 1400\nHoward Brown\nLab 11\n14 July 2017");
        }
        /* Name: exitToolStripMenuItem_Click
        Purpose: Exit out of the program
        Parameters: None
        Return: None
        */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {

            textBoxC.Text = CalcHypotenuse();

        }
    }
}
