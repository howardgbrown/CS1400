using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
using static System.Environment;

namespace HB_Project11
{
    class Program
    {
        const int SPLIT = 2;
        // welcome message
        // prompts to get the file
        static void Main(string[] args)
        {
            WriteLine("Welcome to the Resistor Testing Program\n");
            Write("Enter the name of the file containing the voltages: ");
            string fileName = ReadLine();
            StreamReader input = new StreamReader(GetFolderPath(SpecialFolder.Personal) + "\\" + fileName);
            string[] respArray = new string[SPLIT];
            // create resistor test
            ResistorTest rt;
            // declare variables
            double resistance, power, voltage;
            string response = input.ReadLine();
            // check the file
            if (response != null)
            {
                respArray = response.Split();
                resistance = double.Parse(respArray[0]);
                power = double.Parse(respArray[1]);
                // create reference variable
                rt = new ResistorTest(resistance, power);
                response = input.ReadLine();
                // loop to check for null
                // if not parse the double
                while (response != null)
                {
                    voltage = double.Parse(response);
                    rt.EnterVoltage(voltage);
                    response = input.ReadLine();
                }
                // close the file so that it can be read by others
                // or be over ridden if need be
                input.Close();

                // write results of the test
                WriteLine("\nTest Results\nRes#\tDissipation\tPassed\n-------------------------------------");
                int numResistors = rt.GetNumberOfResistors();
                for (int i = 0; i < numResistors; i++)
                {
                    WriteLine($"{i + 1}\t{rt.CalcPower(i):F2}\t\t{rt.Test(i)}");
                }
                ReadKey(true);
            }
        }
    }
}
