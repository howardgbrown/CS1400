/* File Prolouge
   Name: Howard Brown
   Project: Lab 26
   Date: 9 August 2017

   I declare that the following source code was written soley by me or
   provided to me by the instructor.
   I understand that copying any source code, in whole or in part,
   constitutes cheating, and that I will receive a zero on this project
   if I am found in violation of this policy.
*/

using System;
using System.Windows.Forms;
using System.IO;

namespace HB_Lab26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Name: openToolStripMenuItem_Click
        // Purpose: Triggers an open file prompt
        // Parameters: none
        // Return: none
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "text files (*.txt)|*txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    StreamReader data = new StreamReader(myStream);
                    textBox.Text = data.ReadLine();
                }
            }
        }

        // Name: aboutToolStripMenuItem_Click
        // Purpose: Displays message box with project info upon clicking "about" text
        // Parameters: none
        // Return: none
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CS1400\nHoward Brown\nLab 26\n9 August 2017");
        }

        // Name: exitToolStripMenuItem_Click
        // Purpose: Closes the program upon clicking "exit" text
        // Parameters: none
        // Return: none
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
