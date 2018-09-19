using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG111Program.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            Compensation compensation = new Compensation();
            Console.WriteLine("How many non over time hours have you worked this week?");
            //this section determines the base pay
            int hoursWorked = Convert.ToInt32(Console.ReadLine());
            int baseRatePay = compensation.baseRate(hoursWorked); //baseRate is the name of the method, baseRatePay is what is returned in the method
            int basePay = baseRatePay; //basepay is the name of the variable for the main program while baseRate is used for the compensation page
            Console.WriteLine("Your base pay this week is $ " + basePay);


            Console.WriteLine("How many hours of overtime have you worked this week?");
            //this section determines the OT pay
            int OThoursWorked = Convert.ToInt32(Console.ReadLine());
            int overTimeRate = compensation.overTime(OThoursWorked); //int what's being returned in other class = other class.name of method in other class (user input);
            int OTPay = overTimeRate;
            
            int basicPay = basePay + OTPay;


            Console.WriteLine("Your base pay plus overtime this week is $ " + basicPay);


            
            Console.WriteLine("How many years have you worked for the company?");
            int yearsWorked = Convert.ToInt32(Console.ReadLine());
            int bonusRate = compensation.Bonus(yearsWorked);
            int bonusPay =  bonusRate;
            int totalPay = basePay + OTPay + bonusPay;

            Console.WriteLine("Your total pay this week is $ " + totalPay);


            Console.ReadLine();

        }

        
    }
}
