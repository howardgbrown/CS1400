// File Prolouge
// Name: Howard Brown
// Project: Lab 3
// Date: 28 June 2017


//I either wrote this myself or goto it from my instructor
//obtaining code from any other source is cheating for which I will receive a zero.

using System;


namespace HBlab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, my name is Hal. ");
            // Varibles
            string userName;
            int userAge;
            double userWealth;

            // Input 
            Console.Write("What is your name? ");
            userName = Console.ReadLine();

            Console.Write($"Hello {userName}, how old are you? ");
            userAge = int.Parse(Console.ReadLine());

            Console.Write($"At {userAge} years old, how much money do you have, {userName}? $");
            userWealth = double.Parse(Console.ReadLine());

            // Process
            userAge = userAge + 1;

            // Output

            Console.WriteLine($"Thank you {userName}, you're almost {userAge} years old, ");
            Console.WriteLine($"and you have {userWealth:C}.");
            Console.WriteLine("Press any key to continue.");

            Console.ReadKey(true);
        }
    }
}
