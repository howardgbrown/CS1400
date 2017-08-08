using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB_Project11
{
    class ResistorTest
    {
        private int MAX = 50;
        private double[] resistorVoltages;
        private int numberOfResistors;
        private double powerRating;
        private double resistanceRating;

        public ResistorTest(double resistance, double power)
        {
            powerRating = power;
            resistanceRating = resistance;
            resistorVoltages = new double[MAX];
            numberOfResistors = 0;
        }

        public int GetNumberOfResistors()
        {
            return numberOfResistors;
        }

        public void EnterVoltage(double voltage)
        {
            if (numberOfResistors < MAX)
            {
                resistorVoltages[numberOfResistors] = voltage;
                numberOfResistors++;
            }
        }
        // Purpose: Calculates the power rating of a resisitor
        public double CalcPower(int index)
        {
            double voltage = resistorVoltages[index];
            return voltage * voltage / resistanceRating;
        }
        // Purpose: Tests the resistor by calculating the power of resistor
        // and comparing with other resistor
        // Parameters: index
        // Returns: yes or no
        public string Test(int index)
        {
            double power = CalcPower(index);
            if (power < powerRating)
            {
                return "no";
            }
            else
            {
                return "yes";
            }
        }
    }
}
