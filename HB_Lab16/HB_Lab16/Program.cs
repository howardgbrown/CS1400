/* File Prolouge
   Name: Howard Brown
   Project: Lab 16
   Date: 24 July 2017

   I declare that the following source code was written soley
   by me or provided to me by the instructor.
   I understand that copying any source code, in whole or in part,
   constitutes cheating, and that I will receive a zero on this project
   if I am found in violation of this policy.
*/

using System;

class Program
{
    static void Main()
    {
        const string SAT = "Saturday";
        const string SUN = "Sunday";
        const string YES = "Yes";

        string today;
        string freezing;

        Console.Write("Please enter a day of the week, e.g. Tuesday: ");
        today = Console.ReadLine();

        if (today != SUN && today != SAT)

        {
            Console.Write("Is it freezing today? ");
            freezing = Console.ReadLine();

            if (freezing != YES)
                Console.WriteLine("You have to go to work today...");

            else if (freezing == YES)
                Console.WriteLine("Go to work and dress warmly.");
        }

        else
        { Console.Write("Yay! No work today!"); }

        Console.ReadLine();

    }
}
/*
    (1)  TRUE
    (2)  FALSE  
 */
