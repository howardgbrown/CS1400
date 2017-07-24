/* File Prolouge
   Name: Howard Brown
   Project: Project 6
   Date: 24 July 2017

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

namespace HB_Project06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("CS 1400\nProject 06\nHoward Brown\n24 July 2017");
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
