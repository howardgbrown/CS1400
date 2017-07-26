/* File Prolouge
   Name: Howard Brown
   Project: Project 6
   Date: 24 July 2017

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

namespace HB_Project06
{
    class ShippingRates
    {
        public const double sSBI = 3.00;
        public const double sSBW = 1.45;
        public const double eSBI = 4.00;
        public const double eSBW = 2.50;
        public const double sDBI = 5.50;
        public const double sDBW = 3.00;
        public const double SUR_CHARGE_S_S = 2.50;
        public const double SUR_CHARGE_E_S = 5.00;
        public const double SUR_CHARGE_S_D = 8.00;
        public const double SUR_CHARGE_NONE = 0.00;
        public string ShippingMethod;
        public string Category;
        public double lbs;
        public double surChargeAdd;
        public double rate;
        public int NumItems { get; set; }


        // Name: Shipping Rates
        // Purpose: Determines what rate to use
        // Parameters: Ship, Cat and DoCharge
        // Return: rate
        public ShippingRates(string Ship, string Cat, bool DoCharge)
        {
            ShippingMethod = Ship;
            Category = Cat;
            string s1 = "Standard";
            string s2 = "Express";
            string s3 = "Same Day";
            string c1 = "By Item";
            string c2 = "By Weight";

            if (Ship == s1 && Cat == c1)

            {
                rate = sSBI;
            }
            else if (Ship == s1 && Cat == c2)
            {
                rate = sSBW;
            }
 
            else if (Ship == s2 && Cat == c1)
            {
                rate = eSBI;
            }
            else if (Ship == s2 && Cat == c2)
            {
                rate = eSBW;
            }
            else if (Ship == s3 && Cat == c1)
            {
                rate = sDBI;
            }
            else if (Ship == s3 && Cat == c2)
            {
                rate = sDBW;
            }
            SurCharge(DoCharge);
        }
        // Name: SurCharge
        // Purpose: Determines what surcharge to add
        // Parameters: none
        // Return: none
        public void SurCharge(bool doCharge)
         {
             if (doCharge)
             {
                if (rate == sSBI)
                {
                    surChargeAdd = SUR_CHARGE_S_S;
                }
                else if (rate == eSBI)
                {
                    surChargeAdd = SUR_CHARGE_E_S;
                }
                else if (rate == sDBI)
                {
                    surChargeAdd = SUR_CHARGE_S_D;
                }
                else
                {
                    surChargeAdd = SUR_CHARGE_NONE;
                }
            }

         }
        
        // Name: ShippingCost
        // Purpose: Calculate the total Shipping Cost
        // Parameters:none
        // Return: Total shipping cost
        public double ShippingCost()
        {
            double subTotalCost = rate * NumItems;
            double totalCost = subTotalCost + surChargeAdd;
            return totalCost;

        }    
            

    }
}
