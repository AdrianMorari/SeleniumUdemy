﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] entries = new int[11];
            int cntOfInvalidEntries = 0;
            int numberOutsideRange = 0;

            PrimeArray(entries);
            cntOfInvalidEntries = GetValues(entries,ref numberOutsideRange);
            DisplayResults(entries, cntOfInvalidEntries, numberOutsideRange);
            Console.ReadKey();
        }

        public static void PrimeArray(int[] entries)
        {
            //initialize array with 0
            for (int i = 0; i < 11; i++)
            {
                entries[i] = 0;
            }
        }

        public static int GetValues(int[] entries, ref int numberOutsideRange)
        {
            int inValue;
            string stringInput;
            bool moreInput = true;
            int cntInvalidEntries = 0;

            Console.Clear();
            while (moreInput)
            {
                Console.Write("\nInput any number between 0 and 10 (-1 to stop): ");
                stringInput = Console.ReadLine();

                //Tests to make sure an integer is entered
                while(int.TryParse(stringInput, out inValue) == false)
                {
                    Console.Write("\nInvalid data type -" +
                        " value must be numeric between 0 and 100 (-1 to stop): ");
                    stringInput = Console.ReadLine();
                    cntInvalidEntries++;
                }
                if (inValue == -1)
                {
                    moreInput = false;
                }
                else if (inValue < -1 || inValue > 10)
                {
                    Console.Write("Invalid number - must be between 0 and 10 - (-1 to stop): ");
                    numberOutsideRange++;
                }
                else
                    entries[inValue]++; //Uses array as an accumulator - adds one at the input value's loca
            }
            return cntInvalidEntries;
        }

        public static void DisplayResults(int[] entries, int cntOfInvalidEntries, int numberOutsideRange)
        {
            int cntOfValidEntries = 0;
            Console.Clear();
            Console.WriteLine("\tInputData App\n");
            Console.WriteLine("{0, -12}{1, -6}", "InputValue", "Count");

            for (int x = 0; x < 11; x++)
            {
                if(entries[x] != 0)
                {
                    cntOfValidEntries += entries[x];
                    Console.WriteLine("{0, 5}{1, 10}", x, entries[x]);
                }
            }
            Console.WriteLine("\nNumber of Valid Entries: {0}", cntOfValidEntries);
            Console.WriteLine("\nNumber of Values Entered Outside Acceptable Range: {0}", numberOutsideRange);
            Console.WriteLine("\nNumber of Non-numeric Values Entered: {0}",cntOfInvalidEntries);
            Console.WriteLine("\nTotal Number of Inputs: {0}", cntOfInvalidEntries + cntOfValidEntries + numberOutsideRange);
        }
    }
}
