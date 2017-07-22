/* File Prolouge
   Name: Howard Brown
   Project: Project 5
   Date: 21 July 2017

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

namespace HB_Project5
{
    class SalesInvoice
    {
        public int numItems;
        public double unitPrice;
        public const double STATE_TAX = 1.068;
        public const double LOCAL_TAX = 1.025;
        public double netPrice;
        public double totalPrice;

        // Name: SalesInvoice
        // Purpose: Stores items as int and price as double
        // Parameters: int items, double price
        // Return: totalPrice as a double
        public SalesInvoice(int items, double price)
        {
            numItems = items;
            unitPrice = price;
            netPrice = numItems * unitPrice;
            totalPrice = netPrice + StateSalesTax() + LocalSalesTax();
        }
        // Name: StateSalesTax
        // Purpose: Calculates the State Sales Tax
        // Parameters: none
        // Return: stateTax
        public double StateSalesTax()
        {
            double stateTax = (netPrice * STATE_TAX) - netPrice;
            return stateTax;
        }
        // Name: LocalSalesTax
        // Purpose: Calculates the Local Sales Tax
        // Parameters: none
        // Return: localTax
        public double LocalSalesTax()
        {
            double localTax = (netPrice * LOCAL_TAX) - netPrice;
            return localTax;
        }

    }
}
