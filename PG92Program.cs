using System;


namespace PG92Program.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("Please enter pagage weight");
            int Weight = Convert.ToInt32(Console.ReadLine());

            if (Weight > 50)
                {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                }

            else 
                {

                Console.WriteLine("Please enter package width.");
                int Width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter package height.");
                int Height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter package length.");
                int Length = Convert.ToInt32(Console.ReadLine());

                int Dimenstions = Width + Height + Length;


                    if (Dimenstions > 50)
                    {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    }

                    else
                    { 
                int Quote = (Dimenstions * Weight) / 100;

                Console.WriteLine("Your estimated total for shipping is $" + Quote);
                    }
                }
        
            Console.ReadLine();
        }
    }
}
