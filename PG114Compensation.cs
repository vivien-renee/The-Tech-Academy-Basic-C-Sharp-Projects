using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG114Program.cs
{
   public class Compensation
    {
        //public int payCheck(int hoursWorked)
        //{
        //    int weeklyPay = hoursWorked * 6;
        //    return weeklyPay;
        //}

        //public int payCheck(decimal hoursWorked)
        //{
        //    int weeklyPay = Decimal.ToInt32(hoursWorked) * 6;
        //    return weeklyPay;
        //}

        public int payCheck(string hoursWorked)
        {
            int weeklyPay =Convert.ToInt32(hoursWorked) * 6;
            return weeklyPay;
        }



    }
}
