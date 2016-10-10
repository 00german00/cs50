using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of rectangle: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter width of rectangle: ");
            int b = int.Parse(Console.ReadLine());

            int x = Area(a , b);
            Console.WriteLine(x);
            Console.ReadLine();
        }

        //calculate the area of a rectangle
        static int Area(int x, int y)
        {
            return (x * y);
        }
    }
}
