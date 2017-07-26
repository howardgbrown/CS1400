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
        private ShippingRates sr;
        
        public Form1()
        {
            InitializeComponent();

        }

        public void MethodAndCategory()
        {
            sr.ShippingMethod = comboShipMeth.Text;
            sr.Category = comboBox1.Text;

        }
        private void radioYes_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioNo_CheckedChanged(object sender, EventArgs e)
        {

        }

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Name: button1_Click
        // Purpose: Displays the total cost of shipping
        // Parameters: none
        // Return: none
        private void button1_Click(object sender, EventArgs e)
        {

            string selectedYes = radioYes.Text;
            string selectedNo = radioNo.Text;
            sr.numItems = int.Parse(textBoxCategory.Text);

            //sr.numItems = numItems;


            string ShippingMethod = comboShipMeth.Text;
            string Category = comboBox1.Text;
            int numItems = int.Parse(textBoxCategory.Text);

            if (selectedYes == "Yes")
            {
                sr.SurchargeHaAk = 1;
            }
            else
            {
                sr.SurchargeHaAk = 0;
            }

            sr = new ShippingRates(ShippingMethod, Category);
            textShippingCost.Text = $"{sr.ShippingCost():C}";
        }

    }
}
