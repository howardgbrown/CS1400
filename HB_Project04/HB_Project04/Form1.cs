/* File Prolouge
   Name: Howard Brown
   Project: Project 4 with Extra Credit 
   Date: 14 July 2017

   I declare that the following source code was written soley by me.
   I understand that copying any source code, in whole or in part,
   constitutes cheating, and that I will receive a zero on this project
   if I am found in violation of this policy.
  
    */

using System;
using static System.Math;
using System.Windows.Forms;

namespace HB_Project04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Name: CalcOppositeSide
        // Purpose: Calculate the value of the opposite side of the triangle
        // Parameters: Side 1, Side 2 and Angle C
        // Return: Side c
        static double CalcOppositeSide(double side1, double side2, double angleC)
        {
            const double TWO = 2;
            const double ONE_EIGHTY = 180;
            double angleCRadians = angleC * PI / ONE_EIGHTY;
            double result = Sqrt(side1 * side1 + side2 * side2 - TWO * side1 * side2 * Cos(angleCRadians));

            return result;
        }
        
        // Name: CalcOppositeSide2  (extra credit)
        // Purpose: Calculate the value of the opposite side of the triangle
        // Parameters: Side 1_2, Side 2_2 and Angle B_2
        // Return: Side B_2
        static double CalcOppositeSide2(double side1_2, double side2_2, double angleB_2)
        {
            const double TWO_2 = 2;
            const double ONE_EIGHTY_2 = 180;
            double angleBRadians = angleB_2 * PI / ONE_EIGHTY_2;
            double result_2 = Sqrt(side1_2 * side1_2 + side2_2 * side2_2 - TWO_2 * side1_2 * side2_2 * Cos(angleBRadians));
            return result_2;
        }

        // Name: aboutToolStripMenuItem_Click
        // Purpose: Show the "about" menu
        // Parameters: None
        // Return: None
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CS 1400\nProject 4\nHoward Brown\n17 July 2017");
        }
        // Name: exitToolStripMenuItem_Click
        // Purpose: Exit out of the program
        // Parameters: None
        // Return: None
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        // Name: buttonCalc_Click
        // Purpose: Calculate the value of the opposite side of the triangle
        // Parameters: None
        // Return: None
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            double sideA = double.Parse(textBoxSideA.Text);
            double sideB = double.Parse(textBoxSideB.Text);
            double angleOfSideC = double.Parse(textBoxAngleC.Text);
            textBoxSideC.Text = CalcOppositeSide(sideA, sideB, angleOfSideC).ToString(".##");
            
        }
        // Name: buttonClear_Click
        // Purpose: Calculate the value of the opposite side of the triangle
        // Parameters: None
        // Return: None
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSideA.Clear();
            textBoxSideB.Clear();
            textBoxAngleC.Clear();
            textBoxSideC.Clear();
        }
        // Name: buttonCalc2_Click  (extra credit)
        // Purpose: Calculate the value of the opposite side of the triangle
        // Parameters: None
        // Return: None
        private void buttonCalc2_Click(object sender, EventArgs e)
        {
            double sideA2 = double.Parse(textBoxSideA2.Text);
            double sideC2 = double.Parse(textBoxSideC2.Text);
            double angleOfSideB2 = double.Parse(textBoxAngleB2.Text);
            textBoxSideB2.Text = CalcOppositeSide2(sideA2, sideC2, angleOfSideB2).ToString(".##");
        }
        // Name: buttonClear2_Click  (extra credit)
        // Purpose: Calculate the value of the opposite side of the triangle
        // Parameters: None
        // Return: None
        private void buttonClear2_Click(object sender, EventArgs e)
        {
            textBoxSideA2.Clear();
            textBoxSideC2.Clear();
            textBoxAngleB2.Clear();
            textBoxSideB2.Clear();
        }
    }
}
