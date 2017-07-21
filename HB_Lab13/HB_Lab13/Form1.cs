/* File Prolouge
   Name: Howard Brown
   Project: Lab 13
   Date: 19 July 2017

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
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HB_Lab13
{
    public partial class Form1 : Form
    {
        private TokenMachine tm;
        public Form1()
        {
            InitializeComponent();
            tm = new TokenMachine();
            DisplayValues();
        }
        // Name: DisplayValues
        // Purpose: Displays the current number of Quarters and Tokens in the machine
        // Parameters: None
        // Return: Number of Quarters in text box and number of Tokens in text box
        public void DisplayValues()
        {
            textBoxQuarters.Text = $"{tm.GetNumQuarters():D}";
            textBoxTokens.Text = $"{tm.GetNumTokens():D}";
        }
        // Name: buttonPurchase_Click
        // Purpose: Exchanges 1 quarter for 1 token
        // Parameters: None
        // Return: None
        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            tm.PurchaseToken();
            DisplayValues();
        }
        // Name: buttonReset_Click
        // Purpose: Resets the values of Quarters and Tokens to the default values
        // Parameters: None
        // Return: None
        private void buttonReset_Click(object sender, EventArgs e)
        {
            tm.Reset();
            DisplayValues();
            buttonPurchase.Focus();
        }
    }
}
