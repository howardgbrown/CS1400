/* File Prolouge
   Name: Howard Brown
   Project: Project 8
   Date: 2 August 2017

   I declare that the following source code was written soley by me.
   I understand that copying any source code, in whole or in part,
   constitutes cheating, and that I will receive a zero on this project
   if I am found in violation of this policy.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB_Project08
{
    class PairOfDice
    {
        // random number generator
        private Random rand;


        // Name: PairOfDice
        // Purpose: Random number generator
        // Parameters: none
        // Returns: Random number
        
        // Construct 
        // new random
        public PairOfDice()
        {
            rand = new Random();
        }


        // Name: RollDice
        // Purpose: Puts the random number in the Dice integer 
        // Parameters: dice 1 and dice 2 as int d1 and int d2
        // Returns: none

        // Method RollDice referencing both dice
        // dice1 random (1, 7) because it starts with 0
        // dice2 random
        public void RollDice(ref int d1, ref int d2)
        {
            d1 = rand.Next(1, 7);
            d2 = rand.Next(1, 7);
        }
    }
}
