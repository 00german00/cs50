using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2_wed
{
    class Program
    {
        static void Main(string[] args)
        {
            // if i'm missing products throw an exception
            throw new ShippingException();
            throw new Exception("Booom");

            Console.ReadLine();
        }

        static void DivError (int x, int y)
        {
            try
            {
                if (x < 1 || y < 1)
                    throw new Exception("Boom");

                int z = x / y;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // here we are inheriting from the Exception class and creating our own exception type
        public class ShippingException: Exception
        {
            //constructor: a method that has the same name as the class and no input method so you can call it in you Main
            public ShippingException()
            {
            }
            
            // this allows the ShippingException to accept a message
            public ShippingException(string message): base(message)
            {
                
            }

        }

    }
}
