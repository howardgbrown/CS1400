/* File Prolouge
   Name: Howard Brown
   Project: Lab 15
   Date: 20 July 2017

   I declare that the following source code was written soley by me.
   I understand that copying any source code, in whole or in part,
   constitutes cheating, and that I will receive a zero on this project
   if I am found in violation of this policy.
  
 */

using System;

namespace HB_Lab15
{
    class Triangle
    {
        private double sideA;
        private double sideB;

        // Name: Triangle
        // Purpose: Store Side A and Side B as doubles
        // Parameters: double a, double b
        // Return: sideA as a double and sideB as a double
        public Triangle(double a, double b)
        {
            sideA = a;
            sideB = b;
        }
        // Name: CalcArea
        // Purpose: Calculates the Area of a triangle
        // Parameters: none
        // Return: Area of a Triangle 
        public double CalcArea()
        {
            const double HALF = 0.5;
            return HALF * sideA * sideB;
        }
        // Name: CalcHypotenuse
        // Purpose: Calculates the hypotenuse of a triangle
        // Parameters: done
        // Return: The hypotenuse of a triangle
        public double CalcHypotenuse()
        {
            return Math.Sqrt(sideA * sideA + sideB * sideB);
        }
        // Name: GetSideA
        // Purpose: Retrieves Side A
        // Parameters: 
        // Return: Side A of a Triangle
        public double GetSideA()
        {
            return sideA;
        }
        // Name: GetSideB
        // Purpose: Retrieves Side B
        // Parameters: 
        // Return: Side B of a Triangle
        public double GetSideB()
        {
            return sideB;
        }
    }
}
