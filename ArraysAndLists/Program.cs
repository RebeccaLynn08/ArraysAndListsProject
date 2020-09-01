using System;
using System.Collections.Generic;
using System.Globalization;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(numbers);


            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            List<int> Evens = new List<int>();
            List<int> Odds = new List<int>();


            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach (var nums in numbers)
            {
                if (nums % 2 == 0)
                {
                    Evens.Add(nums);
                }
                else
                {
                    Odds.Add(nums);
                }

            }
            
                /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            foreach (var nums in Evens)
            {
                Console.WriteLine(nums);
            }
            foreach (var nums in Odds)
            {
                Console.WriteLine(nums);
            }

        }


    }
}
