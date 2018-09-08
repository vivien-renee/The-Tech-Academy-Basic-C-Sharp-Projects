using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                //Can also add a personalized message
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
                //Example of a custom message
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               
            }
            finally
            //finally runs no matter what, if there is a catch or not. adding the console.readline ensures that the error message is seen
            {
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
