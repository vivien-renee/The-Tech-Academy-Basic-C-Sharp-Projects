using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG111Program.cs
{
   public class Compensation
    {



        public int baseRate(int hoursWorked)
        {

            int baseRatePay = hoursWorked * 6;
            return baseRatePay;
        }



        public int overTime(int OThoursWorked)
        {

            int overTimeRate = OThoursWorked * 2;
            return overTimeRate;
        }




        public int Bonus(int yearsWorked)
        {

            int BonusRate = yearsWorked * 100;
            return BonusRate;
        }



    }
}





