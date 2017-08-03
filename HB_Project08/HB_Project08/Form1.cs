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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HB_Project08
{
    public partial class Form1 : Form
    {
        PairOfDice pd;
        const int BOXCARS = 6;
        const int SNAKEYES = 1;

        public Form1()
        {
            InitializeComponent();
            pd = new PairOfDice();
        }

        private void buttonRoll_Click(object sender, EventArgs e)
        {
            int die1 = 0;
            int die2 = 0;
            pd.RollDice(ref die1, ref die2);
            ShowDie(die1, textDie1);
            ShowDie(die2, textDie2);
            if(die1 == BOXCARS && die2 == BOXCARS)
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

        private void ShowDie(int dieValue, TextBox tb)
        {
            if (dieValue == 1)
            {
                tb.Text = "\r .";
            }
            else if (dieValue == 2)
            {
                tb.Text = "   .\r\n\r.";
            }
            else if (dieValue == 3)
            {
                tb.Text = " .\r .\r .";
            }
            else if (dieValue == 4)
            {
                tb.Text = ". .\r\r. .";
            }
            else if (dieValue == 5)
            {
                tb.Text = ". .\r .\r. .";
            }
            else
            {
                tb.Text = ". .\r. .\r. .";
            }
    }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CS 1400 - 602\nProject 08\nHoward Brown\n2 August 2017");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
