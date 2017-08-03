/* File Prolouge
   Name: Howard Brown
   Project: Project 8
   Date: 2 August 2017

   I declare that the following source code was written soley by me.
   I understand that copying any source code, in whole or in part,
   constitutes cheating, and that I will receive a zero on this project
   if I am found in violation of this policy.
*/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace HB_Project08
{
    public partial class Form1 : Form
    {

        // declare variables
        // constants for 6 and 1
        PairOfDice pd;
        const int BOXCARS = 6;
        const int SNAKEYES = 1;

        public Form1()
        {
            InitializeComponent();

            // initialize new PairOfDice from class
            // use pd
            pd = new PairOfDice();
        }

        // Name: buttonRoll_Click
        // Purpose: Click event to start the dice roll
        // Parameters: none
        // Returns: none

        private void buttonRoll_Click(object sender, EventArgs e)
        {
            // variables dice1 and dice 2
            // set initial values to 0

            int die1 = 0;
            int die2 = 0;
            pd.RollDice(ref die1, ref die2);
            ShowDie(die1, pictureDie1);
            ShowDie(die2, pictureDie2);

            // if else if else statement
            // to set label for Boxcars and Snakeeyes
            if (die1 == BOXCARS && die2 == BOXCARS)
            {
                labelMessage.Text = "You rolled Boxcars!";
            }
            else if(die1 == SNAKEYES && die2 == SNAKEYES)
            {
                labelMessage.Text = "You rolled Snakeyes!";
            }
            else
            {
                labelMessage.Text = ($"You rolled {die1} and {die2}.");
            }
        }

        // Name: ShowDie
        // Purpose: hold if statement to display the dice upon the roll
        // Parameters: value of dice and image of dice as int dieValue and PictureBox pb
        // Returns: none

        // if else if else statements to assign images to the dice value
        private void ShowDie(int dieValue, PictureBox pb)
        {
            if (dieValue == 1)
            {
                pb.Image = Image.FromFile("C:/Users/Howard Brown/Desktop/HB_Project08/HB_Project08/Resources/die1.bmp");
            }
            else if (dieValue == 2)
            {
                pb.Image = Image.FromFile("C:/Users/Howard Brown/Desktop/HB_Project08/HB_Project08/Resources/die2.bmp");
            }
            else if (dieValue == 3)
            {
                pb.Image = Image.FromFile("C:/Users/Howard Brown/Desktop/HB_Project08/HB_Project08/Resources/die3.bmp");
            }
            else if (dieValue == 4)
            {
                pb.Image = Image.FromFile("C:/Users/Howard Brown/Desktop/HB_Project08/HB_Project08/Resources/die4.bmp");
            }
            else if (dieValue == 5)
            {
                pb.Image = Image.FromFile("C:/Users/Howard Brown/Desktop/HB_Project08/HB_Project08/Resources/die5.bmp");
            }
            else
            {
                pb.Image = Image.FromFile("C:/Users/Howard Brown/Desktop/HB_Project08/HB_Project08/Resources/die6.bmp");
            }
        }

        // Name: aboutToolStripMenuItem_Click
        // Purpose: Shows a message box with project information upon clicking "About" text 
        // Parameters: none
        // Returns: none
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CS 1400 - 602/nProject 08/nHoward Brown/n2 August 2017");
        }

        // Name: exitToolStripMenuItem_Click
        // Purpose: Exits the program upon clicking "Exit" text 
        // Parameters: none
        // Returns: none
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
