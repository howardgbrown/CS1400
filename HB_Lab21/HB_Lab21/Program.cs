/* File Prolouge
   Name: Howard Brown
   Project: Lab 21
   Date: 8 August 2017

   I declare that the following source code was written soley by me or
   provided to me by the instructor.
   I understand that copying any source code, in whole or in part,
   constitutes cheating, and that I will receive a zero on this project
   if I am found in violation of this policy.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB_Lab21
{
    class Program
    {
        // some  class level constants
        const int HALVES = 50;
        const int QUARTERS = 25;
        const int DIMES = 10;
        const int NICKELS = 5;
        const int PENNIES = 1;

        static void Main()
        {
            int money;  // the value we want to count change for

            Console.WriteLine("I will make change for you.");
            Console.Write("Enter in an amount between 1 and 99: ");
            money = int.Parse(Console.ReadLine());

            Console.WriteLine("For {0} you get:", money);

            Console.WriteLine("{0} halves", ComputeChange(ref money, HALVES));
            Console.WriteLine("{0} quarters", ComputeChange(ref money, QUARTERS));
            Console.WriteLine("{0} dimes", ComputeChange(ref money, DIMES));
            Console.WriteLine("{0} nickels", ComputeChange(ref money, NICKELS));
            Console.WriteLine("{0} pennies\n", ComputeChange(ref money, PENNIES));
            Console.ReadLine();
        }

        // Name: ComputeChange
        // Purpose: determine change given back by coin value
        // Parameters: ref int changeValue, int coinValue
        // Return: coinValue
        static int ComputeChange(ref int changeValue, int coinValue)
        {
            //calculate halves
            if (coinValue == HALVES)
            {
                coinValue = changeValue / HALVES;
                //new value after halves
                changeValue = changeValue - (coinValue * HALVES);
            }
            //calculate quarters
            else if (coinValue == QUARTERS)
            {
                coinValue = changeValue / QUARTERS;
                //new value after quarters
                changeValue = changeValue - (coinValue * QUARTERS);
            }

            //calculate dimes
            else if (coinValue == DIMES)
            {
                coinValue = changeValue / DIMES;
                //new value after dimes
                changeValue = changeValue - (coinValue * DIMES);
            }
            //calculate nickels
            else if (coinValue == NICKELS)
            {
                coinValue = changeValue / NICKELS;
                //new value after nickels
                changeValue = changeValue - (coinValue * NICKELS);
            }
            //calculate pennies
            else
            {
                coinValue = changeValue / PENNIES;
            }
            //return coinValue
            return coinValue;
        }
    }
}