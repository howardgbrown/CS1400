// File Prolouge
// Name: Howard Brown
// Project: Lab 09
// Date: 12 July 2017

using System;
using static System.Console;
using static System.Math;

namespace HB_lab_09
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TWO = 2; //const int TWO = 2
            double radius, areaSquare, areaCircle; // variables double radius, areaSquare, areaCicle
            Write("What is the radius of the circles? "); // Write "what is the radius?"
            radius = double.Parse(ReadLine()); // input
            areaSquare = Pow(TWO*radius, TWO); // areaSquare = (radius + radius) * (radius + radius)
            areaCircle = PI * Pow(radius, TWO);// areaCircle = PI * (radius + radius)
            WriteLine($"The area of the square is: {areaSquare:F2}"); // output the area of the square
            WriteLine($"The are of the circle is: {areaCircle:F2}"); // output the area of the circle
            WriteLine($"The difference is: {areaSquare - areaCircle:F2}"); // output the difference
            ReadKey(true); // readKey to end

        }
    }
}
