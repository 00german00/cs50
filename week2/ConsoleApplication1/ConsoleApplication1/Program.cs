using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie m = new Movie();
            m.Title = "Gone in 60s";
            m.Genre = "Action";

            Movie m2 = new Movie();
            m2.Title = "Gone in 30s";
            m2.Genre = "Romance";

            Movie m3 = new Movie();
            m3.Title = "Gone in 60s";
            m3.Genre = "Action";

            Console.WriteLine(m2 == m);
            Console.WriteLine(m2.Equals(m2));
            Console.WriteLine(m2.Equals(m3));
            Console.ReadLine();           
        }
    }


    class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }

        public override string ToString()
        {
            string result = "";

            result += "Title:" + Title;
            result += "\nGenre: " + Genre;

            return result;
        }


        public override bool Equals(object obj)
        {
            // left value of as is what we want to cast and right is what we want to cast it to, and it returns a bool
            Movie second = obj as Movie;
            if (second != null)
            {
                if (second.Title == Title && second.Genre == Genre)
                    {
                        return true;
                    }                
            }
            return false;
        }
    }


    class Shape
    {
        public string Type { get; set; }
               
    }

    class Circle: Shape
    {

    }
}
