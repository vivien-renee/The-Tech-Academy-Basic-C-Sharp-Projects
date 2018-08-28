using System;


namespace PG67Program.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1:");
            Console.WriteLine("Hourly Rate?");
            string HourlyRate1 = Console.ReadLine();
            int Rate1 = Convert.ToInt32(HourlyRate1);

            Console.WriteLine("Hours worked per week?");
            string HoursWorked1 = Console.ReadLine();
            int Worked1 = Convert.ToInt32(HoursWorked1);

            int Salary1 = Rate1 * Worked1 * 52;

            Console.WriteLine("Person 2:");
            Console.WriteLine("Hourly Rate?"); string
            HourlyRate2 = Console.ReadLine();
            int Rate2 = Convert.ToInt32(HourlyRate2);


            Console.WriteLine("Hours worked per week?");
            string HoursWorked2 = Console.ReadLine();
            int Worked2 = Convert.ToInt32(HoursWorked2);

            int Salary2 = Rate2 * Worked2 * 52;

            Console.WriteLine("Annual salary of Person 1: " + Salary1);

            Console.WriteLine("Annual salary of Person 2: " + Salary2);

            bool Compare = Salary1 > Salary2;

            Console.WriteLine("Does Person 1 make more money than Person2? " + Compare);

            Console.ReadLine();
        }
    }
}
