using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG106Program.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                List<int> numList = new List<int>() { 20, 30, 40, 50, 60 };
                Console.WriteLine("Pick a number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numList.Count; i++)

                {
                    int div1 = numList[i] / num1;
                    //Error when divided by zero System.DivideByZeroException: 'Attempted to divide by zero.'
                    Console.WriteLine(div1);
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            
            {
                Console.ReadLine();
            }




            Console.ReadLine();
        }
    }
}
