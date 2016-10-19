using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            int m1 = 3;
            int m2 = 5;
            int sum = 0;

            for (int count = 1; count< 1000; count++)
            { 
                if ( (count % m1) == 0 || (count % m2) == 0)
                    {
                        sum+= count;
                    }
            }

            Console.Write(sum);
            Console.ReadLine();
        }
    }
}
