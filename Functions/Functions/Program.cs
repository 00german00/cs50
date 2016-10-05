using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        static void Main(params int[] args)
        {
            //int[] array;
            Console.WriteLine(Max(args));
            Console.WriteLine(Min(args));
            Console.WriteLine(Average(args));
            Console.ReadLine();
        }

        //calculate Max num in the array
        static int Max(params int[] numbers)
        {
            int max = 0;

            foreach (var num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
                else { }
            }

            return max;
        }

        //calculate Max num in the array
        static int Min(params int[] numbers)
        {
            int min = 0;

            foreach (int num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
                else { }
            }

            return min;
        }

        //calculate Average num in the array
        static float Average(int[] numbers)
        {
            int sum = 0;
            int count = 0;

            foreach (int num in numbers)
            {
                sum += num;
                count++;
            }

            return (sum / count);
        }

    }
}
