using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer: ");
            int num = int.Parse(Console.ReadLine());

            MTable(num);
            Console.ReadLine();
        }

        //calculate multiplication table based on a given int
        static void MTable(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int j;
                for (j = 1; j <= n; j++)
                {
                    Console.Write((i + 1) * j + "\t");
                }

                j = 1;
                Console.Write("\n");
            }
        }
    }
}
