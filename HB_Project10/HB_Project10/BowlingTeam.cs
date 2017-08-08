using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB_Project10
{
    class BowlingTeam
    {
        private int MAX = 10;
        private string[] bowlerNames;
        private int[] bowlerScores;
        private int totalScore;
        private int numberOfBowlers;

        public BowlingTeam()
        {
            bowlerNames = new string[MAX];
            bowlerScores = new int[MAX];
            totalScore = 0;
            numberOfBowlers = 0;
        }

        public void EnterScore(string name, int score)
        {
            bowlerNames[numberOfBowlers] = name;
            bowlerScores[numberOfBowlers] = score;
            totalScore += score;
            numberOfBowlers++;
        }

        public void SortScores()
        {
            bool swap = true;
            while (swap)
            {
                swap = false;
                for (int i = 0; i < numberOfBowlers - 1; i++)
                {
                    if (bowlerScores[i] < bowlerScores[i + 1])
                    {
                        SwapScores(i, i + 1);
                        swap = true;
                    }
                }
            }
        }

        private void SwapScores(int n, int m)
        {
            int score = bowlerScores[n];
            bowlerScores[n] = bowlerScores[m];
            bowlerScores[m] = score;

            string name = bowlerNames[n];
            bowlerNames[n] = bowlerNames[m];
            bowlerNames[m] = name;
        }

        public string GetScore(int n)
        {
            const int PERFECT_SCORE = 300;
            string result = $"{bowlerNames[n]}\t{bowlerScores[n]:D}";
            if (bowlerScores[n] == PERFECT_SCORE)
            {
                result += "\tPERFECT GAME!!!";
            }
            return result;
        }

        public double GetAverageScore()
        {
            return (double)(totalScore / numberOfBowlers);
        }

        public int GetNumberOfBowlers()
        {
            return numberOfBowlers;
        }
    }
}
