using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB_Project09
{
    class BowlingTeam
    {
        private string[] bowlerNames;
        private int[] bowlerScores;
        private int totalScore;
        private int numberOfBowlers;

        private const int MAX = 10;
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

        public void GetHighScore(ref string name, ref int score)
        {
            int highest = 0;
            score = bowlerScores[0];
            for (int i = 1; i < numberOfBowlers; i++)
            {
                if (score < bowlerScores[i])
                {
                    highest = i;
                    score = bowlerScores[i];
                }
            }
            name = bowlerNames[highest];
        }

        public void GetLowScore(ref string name, ref int score)
        {
            int lowest = 0;
            score = bowlerScores[0];
            for (int i = 1; i < numberOfBowlers; i++)
            {
                if (score > bowlerScores[i])
                {
                    lowest = i;
                    score = bowlerScores[i];
                }
            }
            name = bowlerNames[lowest];
        }

        public int GetAverageScore()
        {
            return totalScore / numberOfBowlers;
        }
    }
}