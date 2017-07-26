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
using System.Windows.Forms;

namespace HB_Project06
{
    public partial class Form1 : Form
    {
        private ShippingRates sr;
        
        public Form1()
        {
            InitializeComponent();

        }
        // Name: radioYes_CheckedChanged
        // Purpose: Add surcharge
        // Parameters:none
        // Return: none
        private void radioYes_CheckedChanged(object sender, EventArgs e)
        {

        }
        // Name: radioNo_CheckedChanged
        // Purpose: Do not add surcharge
        // Parameters:none
        // Return: none
        private void radioNo_CheckedChanged(object sender, EventArgs e)
        {

        }
        // Name: comboShipMeth_SelectedIndexChanged
        // Purpose: Selects Shipping Method from drop down
        // Parameters:none
        // Return: none
        private void comboShipMeth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // Name: aboutToolStripMenuItem_Click_1
        // Purpose: Shows message box with project info upon clicking "About"
        // Parameters: none
        // Return: none
        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("CS 1400\nProject 06\nHoward Brown\n24 July 2017");
        }

        // Name: exitToolStripMenuItem_Click_1
        // Purpose: Closes program upon clicking "Exit"
        // Parameters: none
        // Return: none
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        // Name: comboBox1_SelectedIndexChanged
        // Purpose: Selects by item or by weight from drop down
        // Parameters: none
        // Return: none
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Name: button1_Click
        // Purpose: Displays the total cost of shipping
        // Parameters: none
        // Return: none
        private void button1_Click(object sender, EventArgs e)
        {
            string shippingMethod = comboShipMeth.Text;
            string category = comboBox1.Text;
            int numItems = int.Parse(textBoxCategory.Text);
            bool doCharge = radioYes.Checked;
            sr = new ShippingRates(shippingMethod, category, doCharge);

            sr.NumItems = numItems;
            
            textShippingCost.Text = $"{sr.ShippingCost():C}";

        }

    }
}
