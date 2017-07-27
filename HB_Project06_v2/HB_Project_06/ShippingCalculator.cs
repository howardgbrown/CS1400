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
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HB_Project_06
{
    class ShippingCalculator
    {
        // declare constants
        private const double STANDARD_BY_ITEM = 3.0;
        private const double STANDARD_BY_WEIGHT = 1.45;
        private const double STANDARD_SURCHARGE = 2.5;
        private const double EXPRESS_BY_ITEM = 4.0;
        private const double EXPRESS_BY_WEIGHT = 2.5;
        private const double EXPRESS_SURCHARGE = 5.0;
        private const double SAMEDAY_BY_ITEM = 5.5;
        private const double SAMEDAY_BY_WEIGHT = 3.0;
        private const double SAMEDAY_SURCHARGE = 8.0;
        private const int STANDARD = 0;
        private const int EXPRESS = 1;
        private const int SAMEDAY = 2;
        private const int BY_ITEM = 0;
        private const int BY_WEIGHT = 1;
        //declare variables
        private int method;
        private int category;
        private int items;
        private double weight;
        private bool surcharge;
        private double cost;

        // Name: ShippingCalculator
        // Purpose: Determines what category to use
        // Parameters: int m, int c, int i, bool s
        // Return: by item
        public ShippingCalculator(int m, int c, int i, bool s)
        {
            method = m;             //method = m
            category = c;           //category = c
            items = i;              //items = i
            weight = 0.0;           //weight = 0.0
            surcharge = s;          //weight = s
        }

        // Name: ShippingCalculator
        // Purpose: Determines what category to use
        // Parameters: int m, int c, double w, bool s
        // Return: by weight
        public ShippingCalculator(int m, int c, double w, bool s)
        {
            method = m;             //method = m
            category = c;           //category = c
            items = 0;              //items = 0
            weight = w;             //weight = w
            surcharge = s;          //surcharge = s
        }
        // Name: CalculateTotalCost
        // Purpose: Calculates how much shipping will cost
        // Parameters: none
        // Return: cost
        public double CalculateTotalCost()
        {
            cost = 0.0;
            if (method == STANDARD)
            {
                if (category == BY_ITEM)
                {
                    cost = STANDARD_BY_ITEM * items;
                }
                else
                {
                    cost = STANDARD_BY_WEIGHT * weight;
                }
                if (surcharge)
                {
                    cost += STANDARD_SURCHARGE;
                }
            }
            else if (method == EXPRESS)
            {
                if (category == BY_ITEM)
                {
                    cost = EXPRESS_BY_ITEM * items;
                }
                else
                {
                    cost = EXPRESS_BY_WEIGHT * weight;
                }
                if (surcharge)
                {
                    cost += EXPRESS_SURCHARGE;
                }
            }
            else
            {
                if (category == BY_ITEM)
                {
                    cost = SAMEDAY_BY_ITEM * items;
                }
                else
                {
                    cost = SAMEDAY_BY_WEIGHT * weight;
                }
                if (surcharge)
                {
                    cost += SAMEDAY_SURCHARGE;
                }
            }
            return cost;
        }
    }
}
