/* File Prolouge
   Name: Howard Brown
   Project: Project 03
   Date: 12 July 2017
 */

using System;
using System.Windows.Forms;

namespace HB_Project_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Name: aboutToolStripMenuItem_Click
         Purpose: Show the "About" menu
         Parameters: None
         Return: None
         */
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CS 1400\nProject 03\nHoward Brown\n12 July 2017");
        }
        /* Name: exitToolStripMenuItem_Click
        Purpose: Exit out of the program
        Parameters: None
        Return: None
        */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
          /* Name: buttonCalculate_Click
            Purpose: Execute the Program
            Parameters: None
            Return: Calculation of "New Arrival Time"
             */
        private void buttonCalculate_Click(object sender, EventArgs e)
        {

            const int MINUTES_PER_HOUR = 60;
            const double ARRIVAL_INCREASE = 1.25;
            const int HUNDRED = 100;
            int startTime = int.Parse(textStart.Text);          
            int endTime = int.Parse(textEnd.Text);
            int startHours = startTime / HUNDRED;
            int startMinutes = startTime % HUNDRED + startHours * MINUTES_PER_HOUR;
            int endHours = endTime / HUNDRED;
            int endMinutes = endTime % HUNDRED + endHours * MINUTES_PER_HOUR;
            int oldTravelTime = endMinutes - startMinutes;
            int newTravelTime = (int)(oldTravelTime * ARRIVAL_INCREASE);
            int newArrivalMinutes = startMinutes + newTravelTime;
            int newArrivalHours = newArrivalMinutes / MINUTES_PER_HOUR;
                newArrivalMinutes = newArrivalMinutes % MINUTES_PER_HOUR;
            textNewArrival.Text = $"{newArrivalHours:d2}{newArrivalMinutes:d2}";



        }
    }
}
