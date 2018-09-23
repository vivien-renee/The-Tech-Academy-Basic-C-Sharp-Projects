using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG114Program.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Compensation compensation = new Compensation();
            //#1
            //int weeklyPay = compensation.payCheck(hoursWorked: 12);
            //Console.WriteLine("Your pay this week is $" + weeklyPay);

            //#2
            //decimal hoursWorked = 12.0m;
            //int weeklyPay = compensation.payCheck(hoursWorked);
            //Console.WriteLine("Your pay this week is $" + weeklyPay);

            //#3
            //Console.WriteLine("How many hours did you work today?");
            
            string hoursWorked = Console.ReadLine();
            int weeklyPay = compensation.payCheck(hoursWorked);
            Console.WriteLine("Your pay this week is $" + weeklyPay);

            Console.ReadLine();
        }
    }
}
