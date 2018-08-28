using System;

namespace PG75Program.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age");
            string PersonAge = Console.ReadLine();
            int Age = Convert.ToInt32(PersonAge);

            Console.WriteLine("Have you ever had a DUI?");
            string DUIAnswer = Console.ReadLine();
            bool DUI = Convert.ToBoolean(DUIAnswer);
           
            Console.WriteLine("How many speeding tickets do you have?");
            string TicketNumber = Console.ReadLine();
            int Ticket = Convert.ToInt32(TicketNumber);

            bool Qualified = Age > 15 && DUI == false && Ticket < 4;

            Console.WriteLine("Qualified? " + Qualified);


            Console.ReadLine();
        }
    }
}
