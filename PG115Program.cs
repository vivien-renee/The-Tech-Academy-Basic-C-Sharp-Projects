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


            string payRateMain = Console.ReadLine();
            int weeklyPay;


            if
                (string.IsNullOrEmpty(payRateMain))

            {
                weeklyPay = compensation.payCheck(hoursWorked);


            }

            //int payRate = string.IsNullOrEmpty(payRateMain) ? Convert.ToInt32(compensation.payCheck(hoursWorked)) 
            //    : Convert.ToInt32(payRateMain);
            else

            {
                int payRate = Convert.ToInt32(payRateMain);
                weeklyPay = compensation.payCheck(hoursWorked, payRate);
            }






            Console.WriteLine("Your pay this week is $ " + weeklyPay);

            Console.ReadLine();

        }








    }
}
