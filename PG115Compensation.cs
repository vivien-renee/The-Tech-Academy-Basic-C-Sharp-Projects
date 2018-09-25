using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG115Program.cs
{
   public class Compensation
    {
        
        public int payCheck(int hoursWorked, int payRate)
        {

            int weeklyPay = hoursWorked * payRate;

            return weeklyPay;
        }

    }
}
