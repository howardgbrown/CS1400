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
        private Random rand;

        public PairOfDice()
        {
            rand = new Random();
        }
       
        public void RollDice(ref int d1, ref int d2)
        {
            d1 = rand.Next(1, 7);
            d2 = rand.Next(1, 7);
        }
    }
}
