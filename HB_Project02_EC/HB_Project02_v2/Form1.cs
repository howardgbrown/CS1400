//File Prologue
//Name: Howard Brown
//Project: Project #2
//Date: 719/2017
//All of the source code included in this program was written by
//me or provided to me by my instructor.

using System;
using System.Windows.Forms;

namespace HB_Project02_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Name: aboutToolStripMenuItem
        // Process: Clicking on the text "About" will open up
        // a message with my information
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Project #2\n Howard Brown\n July 10, 2017");
        }
        // Name: exitToolStripMenuItem
        // Process: Clicking the text "Exit" will close the program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }
        // Name: splitButton_Click
        // Process: Clicking on the button will calculate the program
        private void splitButton_Click(object sender, EventArgs e)
        {
            const double CAPTAIN_SHARE = .12;
            const double MATE_SHARE = .08;
            const int CELEBRATION = 3;
            const int NON_CREW = 2;
            int pirates = int.Parse(piratesTextBox.Text);
            int coins = int.Parse(coinsTextBox.Text);
            int celebration = (pirates - NON_CREW) * CELEBRATION;
            coins -= celebration;
            int captain = (int)(coins * CAPTAIN_SHARE);
            coins -= captain;
            int mate = (int)(coins * MATE_SHARE);
            coins -= mate;
            int crew = coins / pirates;
            captain += crew;
            mate += crew;
            int fund = coins % pirates;
            jacksTextBox.Text = $"{captain}";
            matesTextBox.Text = $"{mate}";
            crewTextBox.Text = $"{crew}";
            fundTextBox.Text = $"{fund}";
            int celebrationCost = celebration;
            celebrationTextBox.Text = $"{celebrationCost}";
            int audit;
            int crewTotal = (pirates - NON_CREW) * crew;
            crewTotalTextBox.Text = $"{crewTotal}";
            audit = celebrationCost + captain + mate + crewTotal + fund;
            textBox1.Text = $"{audit}";
        }
    }
}
