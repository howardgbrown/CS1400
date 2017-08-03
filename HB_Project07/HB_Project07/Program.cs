/* File Prolouge
   Name: Howard Brown
   Project: Project 7
   Date: 31 July 2017

   I declare that the following source code was written soley by me.
   I understand that copying any source code, in whole or in part,
   constitutes cheating, and that I will receive a zero on this project
   if I am found in violation of this policy.
*/
using System;


namespace HB_Project07
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare constant for Cages to equal 500
            const int CAGES = 500;

            // declare variables for month, adult rabbit pairs, baby rabbit pairs and total pairs
            int month = 1;
            int adults = 1;
            int babies = 0;
            int total = 1;
            
            // makes the background color white and the text blue
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;

            // write out "Table of rabbit population, in pairs."
            Console.WriteLine("Table of rabbit population, in pairs.\n");
            // write out Month - Adults - Babies - Total
            Console.WriteLine($"Month\tAdults\tBabies\tTotal");
            // write out the corresponding values for Month, Adults
            // Babies and Total.
            Console.WriteLine($"{month}\t{adults}\t{babies}\t{total}");

            // loop to verify the value of Total to test if there
            // are enough cages.
            // a = b, b = c, c = a + b
            //  increment months to add 1 month per line
            do
            {
                babies = adults;
                adults = total;
                total = adults + babies;
                month = ++month;

                Console.WriteLine($"{month}\t{adults}\t{babies}\t{total}");
                } while (total <= CAGES);
            
            // Write "You will run out of cages in the *month* month."
            Console.WriteLine($"\nYou will run out of cages in the {month} month.");
            Console.ReadKey(true);
        }
    }
}
