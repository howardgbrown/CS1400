/* File Prolouge
   Name: Howard Brown
   Project: Lab 13
   Date: 19 July 2017

   I declare that the following source code was written soley by me.
   I understand that copying any source code, in whole or in part,
   constitutes cheating, and that I will receive a zero on this project
   if I am found in violation of this policy.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace HB_Lab13
{
    class TokenMachine
    {
        // Variables
        private int numQuarters;
        private int numTokens;
        private const int HUNDRED = 100;

        // Input Methods

        // Name: TokenMachine (constructor)
        // Purpose: 
        // Parameters: None
        // Return: None
        public TokenMachine()
        {
            Reset();
        }
        // Name: Reset
        // Purpose: Reset the machine
        // Parameters: None
        // Return: None
        public void Reset()
        {
            numQuarters = 0;
            numTokens = HUNDRED;
        }

        // Process method
        // Name: PurchaseToken
        // Purpose: Exchange 1 quarter for 1 token
        // Parameters: None
        // Return: None
        public void PurchaseToken()
        {
            if (numTokens > 0)
            {
                numTokens--;
                numQuarters++;
            }
        }

        // Output methods
        // Name: GetNumQuarters
        // Purpose: Gets the number of quarters in the machine
        // Parameters: None
        // Return: numQuarters
        public int GetNumQuarters()
        {
            return numQuarters;
        }

        // Name: GetNumTokens
        // Purpose: Gets the number of tokens left in the machine
        // Parameters: None
        // Return: numTokens
        public int GetNumTokens()
        {
            return numTokens;
        }
    }
}
