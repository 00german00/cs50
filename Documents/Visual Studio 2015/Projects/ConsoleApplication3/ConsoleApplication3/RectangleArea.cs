using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {            
            int x = Area(2,3);
            Console.WriteLine(x);
            Console.ReadLine();

        }

        //calculate the area of a rectangle
        static int Area (int x, int y)
        {
            return (x * y);
        }

    }
}
