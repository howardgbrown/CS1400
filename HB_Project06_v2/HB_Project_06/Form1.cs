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

namespace HB_Project_06
{
    public partial class Form1 : Form
    {
        private ShippingCalculator sc;
        public Form1()
        {
            InitializeComponent();
        }

        // Name: buttonCalculate_Click
        // Purpose: Displays the shipping total cost
        // Parameters: none
        // Return: none
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int method = comboMethod.SelectedIndex;             //int method = comboMethod.SelectedIndex
            int category = comboCategory.SelectedIndex;         //int category = comboCategory.SelectedIndex
            double weight;                                      //double weight
            int items;                                          //int items
            if (category == 0)                                  //if (category == 0)
            {
                items = int.Parse(textQuantity.Text);           // items = textBox1
                sc = new ShippingCalculator(method, category, items, radioYes.Checked);  // sc = new ShippingCalculator 
            }
            else                                                // else
            {
                weight = double.Parse(textQuantity.Text);       //weight = textBox1
                sc = new ShippingCalculator(method, category, weight, radioYes.Checked);  // sc = new ShippingCalculator
            }
            labelForTotal.Text = $"{sc.CalculateTotalCost():C}";    //
        }

        // Name: comboCategory_SelectedIndexChanged
        // Purpose: Selects which text will read in the label depending on the Category selection
        // Parameters: none
        // Return: none
        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int category = comboCategory.SelectedIndex;     //category = comboCategory.SelectedIndex
            if (category == 0)                              //if (cateogry == 0)
            {                                   
                LabelAppearing.Text = "Number of Items";    //LabelAppearing.Text = "Number of Items" 
            }                      
            else if (category == 1)                         //else if (category == 1
            {
                LabelAppearing.Text = "Weight in Lbs";      //LabelAppearing.Text = "Weight of items"
            }
            
         }

        // Name: buttonReset_Click
        // Purpose: Resets the form to the default values
        // Parameters: none
        // Return: none
        private void buttonReset_Click(object sender, EventArgs e)
        {
            comboMethod.Text = string.Empty;        //comboMethod.Text = string.Empty
            comboCategory.Text = string.Empty;      //comboCategory.Text = string.Empty
            textQuantity.Text = string.Empty;       //textQuantity.Text = string.Empty
            labelForTotal.Text = "$0.00";           //labelForTotal.Text = "0"
            radioNo.Checked = false;                //radioNo.Checked = false
            radioYes.Checked = false;               //radioYes.Checked = false
        }

        // Name: aboutToolStripMenuItem_Click
        // Purpose: Displays message box with info of project upon clicking "About" in File menu
        // Parameters: none
        // Return: none
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CS 1400\nProject 6\nHoward Brown\n24 July 2017");
        }

        // Name: exitToolStripMenuItem_Click
        // Purpose: Closes the program upon clicking "Exit" in File menu
        // Parameters: none
        // Return: none
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
