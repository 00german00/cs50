using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Height = 6;
            r.Width = 5;

            Shape s = new Rectangle();
            Shape s2 = new Circle();

            Vehicle bmw = new Sedan();
            bmw.Make = "bmw";
            bmw.Type = "sedan";
            bmw.PrintProperties();

            Convertible conv = new Convertible();
            conv.Type = "convertible";
            conv.Year = 1995;
            conv.Make = "Ford";
            conv.PrintProperties();

            Pickup ford = new Pickup();
            ford.Make = "Ford";
            ford.Model = "F150";
            ford.Year = 2015;
            ford.Rims = 18;
            ford.PrintProperties();

            Do(r);

            Console.ReadLine();
        }


        static void Do(Shape shape)
        {
            Console.WriteLine(shape.GetArea());
        }

        abstract class Shape
        {
            public string Type { get; set; }

            public abstract double GetArea();
        }

        class Rectangle : Shape
        {
            public int Height { get; set; }
            public int Width { get; set; }

            public override double GetArea()
            {
                return Height * Width;
            }
        }

        class Circle : Shape
        {
            public int Radius { get; set; }

            public override double GetArea()
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }

        abstract class Vehicle
        {
            public string Make { get; set; }
            public string Type { get; set; }

            public abstract void PrintProperties();             
        }

        class Sedan : Vehicle
        {
            public string Model { get; set; }
            public int Rims { get; set; }
            public bool Convertible { get; set; }
            public int Year { get; set; }

            public override void PrintProperties()
            {
                Console.WriteLine(Model);
                Console.WriteLine(Rims);
                Console.WriteLine(Year);
                Console.WriteLine(Convertible);

            }
        }

        class Pickup : Vehicle
        {
            public string Model { get; set; }
            public int Rims { get; set; }
            public int Year { get; set; }

            public override void PrintProperties()
            {
                Console.WriteLine(Model);
                Console.WriteLine(Rims);
                Console.WriteLine(Year);
            }
        }

        class Convertible : Vehicle
        {
            public string Model { get; set; }
            public int Year { get; set; }

            public override void PrintProperties()
            {
                Console.WriteLine(Model);
                Console.WriteLine(Year);
            }
        }
    }
}
