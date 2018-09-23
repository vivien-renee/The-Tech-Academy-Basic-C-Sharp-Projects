using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG113Program.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            Compensation compensation = new Compensation();
            Console.WriteLine("How many hours have you worked this week?");
            //this section determines the base pay
            int hoursWorked = Convert.ToInt32(Console.ReadLine());
            int payRate = 6;
            Console.WriteLine("Your pay per hour is: $" + payRate);
             

            int baseRatePay = compensation.baseRate(hoursWorked, payRate); //baseRate is the name of the method, 
            //baseRatePay is what is returned in the method
            int basePay = baseRatePay; //basepay is the name of the variable for the main program 
            //while baseRate is used for the compensation page
            Console.WriteLine("Your pay this week is $ " + basePay);









            Console.ReadLine();
        }
    }
}
