// File Prologue
// Name: Howard Brown
// Project: Lab 2
// Date: 27 June 2017

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying
// source code from any other source constitues cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

// Question #1: The type of application you select in Visual Studio, when creating a GUI application is 
  //  (d) a Windows Forms application

// Question #2: The text that appears in a Label is stored in 
  // (a) the Text propery of the Label
   
  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_02_HB_V1._0
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
