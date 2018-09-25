using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG113Program.cs
{
    class  Compensation
    {

        
        public void PayCheckCalculation (int hoursWorked,  int payRate)
        {

            int baseRatePay = hoursWorked * payRate;

            
            Console.WriteLine("Your pay per hour is: $" + payRate);


        }
    }
}
