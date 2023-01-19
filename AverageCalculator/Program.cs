using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageCalculator
{
    class AverageCalculator
    {
        public static void Main(string[] args)
        {
            double[] numbers = new double[50]; // İf you wanna change the total number you change the number "50" on your left
            double total = 0;
            double highest = double.MinValue;
            double lowest = double.MaxValue;

            Console.WriteLine("Enter the 50 numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Number {0}: ", i + 1);
                numbers[i] = double.Parse(Console.ReadLine());


                total += numbers[i];


                if (numbers[i] > highest)
                {
                    highest = numbers[i];
                }


                if (numbers[i] < lowest)
                {
                    lowest = numbers[i];
                }
            }


            double average = total / numbers.Length;


            Console.WriteLine("Average: {0:F}", average);
            Console.WriteLine("Highest: {0:F}", highest);
            Console.WriteLine("Lowest: {0:F}", lowest);
        }
    }
}