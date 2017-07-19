using System;
using System.Windows.Forms;

namespace HB.lab04.formApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MenuE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Howard Brown\nCS 1400\nLab 05");
        }

        private void InTextBox_Leave(object sender, EventArgs e)
        {
            const int DOUBLE = 2;
            int num = int.Parse(inTextBox.Text);
            int doubleNum = num * DOUBLE;
            string outStr = $"{doubleNum:D}";
            outTextBox.Text = outStr;
        }

    }
}
