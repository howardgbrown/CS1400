using System;
using static System.Console;

namespace HB_Lab19
{
    class Program
    {
        static void Main(string[] args)
        {
            // constants
            const int BOX = 6;
            const int EYE = 1;
            // random number generator
            Random randomNum = new Random();
            // variable
            string answer;

            // just some flair
            WriteLine(" ****************************************");
            WriteLine(" *                                      *");
            WriteLine(" *    Welcome to Howard's Dice Game!    *");
            WriteLine(" *                                      *");
            WriteLine(" ****************************************\n");



            // do loop asking "Would you like to roll the dice?"
            // while the answer is not "y" or "n"

            do
            {
                Write(" Would you like to roll the dice? y or n? ");
                answer = (ReadLine());

                // if answer is "n"
                // end program
                if (answer == "n")
                {
                    Write(" Press any key to end the program.");
                    ReadKey(true);
                    return;
                }
                // if answer is not "y" or "n"
                // "This is not a valid response. Try again"
                if (!(answer == "y" || answer == "n"))
                {
                    WriteLine(" That is not a valid response. Try again.");
                }

            } while (answer != "y" && answer != "n");



            // do loop while the answer is "y"
            do
            {
                // for loop
                // while the answer is not "y" or "n"
                // random number generator
                // random number generator
                for (int i = 0; i < 2; i++)
                {
                    int die1 = randomNum.Next(1, 7);
                    int die2 = randomNum.Next(1, 7);

                    // if statement dice1 and dice2 = const boxcar
                    // "You rolled Box cars"
                    if (die1 == BOX && die2 == BOX)
                    {
                        WriteLine($" You rolled Box Cars! {die1} and {die2}");
                    }

                    // else if statement dice1 and dice2 = constant snake eyes
                    // "You roll snake eyes"
                    else if (die1 == EYE && die2 == EYE)
                    {
                        WriteLine($" You rolled Snake Eyes! {die1} and {die2}");
                    }

                    // else statement
                    // "You rolled dice1 and dice2"
                    else
                    {
                        WriteLine($" You rolled {die1:D} and {die2:D}.");
                    }
                }
                // do loop while the answer is not "y" or "n"
                // Would you like to roll again?
                // Method ReadLine will get the answer
                do
                {
                    Write("Would you like to roll again? ");
                    answer = (ReadLine());

                    if (!(answer == "y" || answer == "n"))
                    {
                        WriteLine(" That is not a valid response. Try again.");
                    }

                } while (answer != "y" && answer != "n");

                // if statement answer is no
                // Press any key to end
                if (answer == "n")
                {
                    WriteLine(" Thanks for playing.");
                    WriteLine(" Press any key to end the program.");
                    ReadKey(true);
                }
            } while (answer == "y");
        }
    }
}