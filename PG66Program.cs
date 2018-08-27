using System;



namespace PG66Program.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number.");
            string FirstNum = Console.ReadLine();
            int First = Convert.ToInt32(FirstNum);
            Console.WriteLine(First + " * 50 = " + First * 50);

            Console.WriteLine("Enter a number.");
            string SecondNum = Console.ReadLine();
            int Second = Convert.ToInt32(SecondNum);
            int SecondTotal = Second + 25;
            Console.WriteLine(Second + " + 25 = " + SecondTotal);

            Console.WriteLine("Enter a number.");
            String ThirdNum = Console.ReadLine();
            double Third = Convert.ToDouble(ThirdNum);
            double ThirdTotal = Third / 12.5;
            Console.WriteLine(Third + " / 12.5 = " + ThirdTotal);

            Console.WriteLine("Enter a number.");
            String FourthNum = Console.ReadLine();
            int Fourth = Convert.ToInt32(FourthNum);
            bool Compare = Fourth > 50;
            Console.WriteLine("Your number is greater than 50:" + Compare);

            Console.WriteLine("Enter a number.");
            String FifthNum = Console.ReadLine();
            int Fifth = Convert.ToInt32(FifthNum);
            int Remainder = Fifth % 7;
            Console.WriteLine("The remainder of your number divided by 7 is " + Remainder);

            Console.ReadLine();




        }
    }
}
