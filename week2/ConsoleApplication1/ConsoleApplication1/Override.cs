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
            Student s = new Student();
            s.name = "John Matte";
            s.age = 66;
            s.hometown = "Charleston, SC";

            Student s2 = new Student();
            s2.name = "Matt Damon";
            s2.age = 12;
            s2.hometown = "Miami, FL";

            Student s3 = new Student();
            s3.name = "John Matte";
            s3.age = 66;
            s3.hometown = "Charleston, SC";

            Console.WriteLine(s.ToString());
            Console.WriteLine(s2.ToString());
            Console.WriteLine(s3.ToString());
            Console.WriteLine(s2.Equals(s));
            Console.WriteLine(s.Equals(s3));
            Console.ReadLine();           
        }
    }

    class Student
    {
        public string name { get; set; }
        public int age { get; set; }
        public string hometown { get; set; }

        public override string ToString()
        {
            string result = "";

            result += "Name: " + name;
            result += "\nAge: " + age;
            result += "\nHometown: " + hometown;
            result += "\n";

            return result;
        }

        public override bool Equals(object obj)
        {
            Student compare = obj as Student;
            if (compare != null)
            {
                if (compare.name == name && compare.age == age && compare.hometown == hometown)
                {
                    return true;
                }
                //return false;
            }
            return false;
        }

    }   

}
