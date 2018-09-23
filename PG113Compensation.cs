using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG113Program.cs
{
    public class Compensation
    {
        public int baseRate(int hoursWorked, int payRate)
        {

            int baseRatePay = hoursWorked * payRate;
      
            return baseRatePay;
        }
    }
}
