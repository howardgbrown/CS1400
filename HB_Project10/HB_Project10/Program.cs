using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HB_Project10
{
    class Program
    {
        const int SPLIT = 2;
        static void Main(string[] args)
        {
            string response, name;
            int score;
            string[] respArray = new string[SPLIT];
            BowlingTeam bt = new BowlingTeam();
            Write("Enter name and score of first bowler, Enter to Quit: ");
            response = ReadLine();
            while (response != "")
            {
                respArray = response.Split();
                name = respArray[0];
                score = int.Parse(respArray[1]);
                bt.EnterScore(name, score);
                Write("Enter name and score of next bowler, Enter to Quit: ");
                response = ReadLine();
            }
            bt.SortScores();
            int bowlers = bt.GetNumberOfBowlers();
            WriteLine("\nName\tScore\n--------------------");
            for (int i = 0; i < bowlers; i++)
            {
                WriteLine(bt.GetScore(i));
            }
            WriteLine($"\nThe average score is {bt.GetAverageScore():F2}");
            ReadKey(true);
        }
    }
}
