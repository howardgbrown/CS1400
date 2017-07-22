/* File Prolouge
   Name: Howard Brown
   Project: Project 5
   Date: 21 July 2017

   I declare that the following source code was written soley by me.
   I understand that copying any source code, in whole or in part,
   constitutes cheating, and that I will receive a zero on this project
   if I am found in violation of this policy.
  
    */

using System;
using System.Windows.Forms;

namespace HB_Project5
{
    public partial class Form1 : Form
    {
        private SalesInvoice si;
        public Form1()
        {
            InitializeComponent();
        }
        // Name: aboutToolStripMenuItem_Click
        // Purpose: Displays a message box with Assignment information upon clicking "About"
        // Parameters: none
        // Return: none
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CS1400\nHoward Brown\nProject 5\n 21 July 2017");
        }
        // Name: exitToolStripMenuItem_Click
        // Purpose: Closes the program
        // Parameters: none
        // Return: none
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        // Name: buyButton_Click
        // Purpose: Displays Message Box with Invoice
        // Parameters: none
        // Return: none
        private void buyButton_Click(object sender, EventArgs e)
        {
            int numItems = int.Parse(numItemsBox.Text);
            double unitPrice = double.Parse(unitPriceBox.Text);
            si = new SalesInvoice(numItems, unitPrice);
            string s1 = string.Format("Quantity: {0:d} units\n", si.numItems);
            string s2 = string.Format("Unit Price: {0:c} each\n----------------------\n", si.unitPrice);
            string s3 = string.Format("Net Price: {0:c}\n", si.netPrice);
            string s4 = string.Format("State Sales Tax: {0:c}\n", si.StateSalesTax());
            string s5 = string.Format("Local Sales Tax: {0:c}\n", si.LocalSalesTax());
            string s6 = string.Format("Please pay: {0:c}\n", si.totalPrice);
            MessageBox.Show(s1 +s2 +s3 + s4 + s5 + s6);
        }
        // Name: clearButton_Click
        // Purpose: Clears the text boxes
        // Parameters: none
        // Return: none
        private void clearButton_Click(object sender, EventArgs e)
        {
            numItemsBox.Clear();
            unitPriceBox.Clear();
        }
        // Name: closeButton_Click
        // Purpose: Closes the program
        // Parameters: none
        // Return: none
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
