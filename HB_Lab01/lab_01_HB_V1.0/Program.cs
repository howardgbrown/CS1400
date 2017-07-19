// File Prologue
// Name: Howard Brown
// Project: lab01
// Date: 27 June 2017


// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System;
using static System.Console;

namespace lab_01
{
    static class Program
    {
        static void Main()
        {
            // This program displays my student information
            string name = "Howard Brown";
            string course = "CNS 1400";
            string section = "602";
            string project = "Lab One";

            // This code displays the strings on the console
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Course: {0}", course);
            Console.WriteLine("Section: {0}", section);
            Console.WriteLine("Project: {0}", project);

            Console.WriteLine("Press any key to continue");
            // The instructions say to have Console.Readline() as the last statement
            // but when I use Console.Readline() instead of Console.Readkey(true) it 
            // types whatever key I use except for the Enter key.
            // The enter key is the only key that will close the program.
            // I looked it up on MSDN and understand that ReadKey means it will 
            // accept the key stroke to end the function, but Readline will only use
            // the enter key.
            Console.ReadKey(true);

        }// End Main
    } // End Class Program
} // End Namespace

//Question #1: The term used to refer to the code that you write, using the C# programming language is 
//(c) The source code


//Question #2: The file extension on the executable file is 
// (b) .exe

