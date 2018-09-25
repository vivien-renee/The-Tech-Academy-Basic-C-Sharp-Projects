using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG115Program.cs
{
    class Program
    {
        static void Main(string[] args)
            
        {

            Compensation compensation = new Compensation();
            Console.WriteLine("How many hours have you worked this week?");
            int hoursWorked = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your base rate? You don't have to answer.");
            
            var payRateMain = Console.ReadLine();
            int payRate = string.IsNullOrEmpty(payRateMain) ? Convert.ToInt32(13) : Convert.ToInt32(payRateMain);


            int weeklyPay = compensation.payCheck(hoursWorked, payRate);
            int basePay = weeklyPay;

            Console.WriteLine("Your pay this week is $ " + basePay);
                    
            Console.ReadLine();

        }








    }
}
