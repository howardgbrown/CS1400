using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HB_Project09
{
    class Program
    {
        const int TWO = 2;
        static void Main(string[] args)
        {
            BowlingTeam bt = new BowlingTeam();
            string response;
            int score = 0;
            string name = "";

            string[] respArray = new string[TWO];

            Write("Enter the name of the first bowler and their score. Enter to Quit: ");
            response = ReadLine();
            while(response != "")
            {
                respArray = response.Split();
                name = respArray[0];
                score = int.Parse(respArray[1]);
                bt.EnterScore(name, score);
                Write("Enter the name of the next bowler and their score. Enter to Quit: ");
                response = ReadLine();
            }

            bt.GetHighScore(ref name, ref score);
            WriteLine($"Congratulations {name}, your score of {score} was the highest score.");

            bt.GetLowScore(ref name, ref score);
            WriteLine($"Sorry {name}, your score of {score} was the lowest score.");

            WriteLine($"The average score was {bt.GetAverageScore()}.");
            ReadKey(true);

        }
    }
}
