using System;


namespace PG94
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Pick a number");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            bool RightNum = Num1 == 7;

            while (!RightNum)
            {
                switch (Num1)
                {
                    case 1:
                        Console.WriteLine("Wrong!");
                        Console.WriteLine("Pick a number");
                        Num1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Wrong!");
                        Console.WriteLine("Pick a number");
                        Num1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("Right!");
                        RightNum = true;
                        break;
                    default:
                        Console.WriteLine("You're bad at this!");
                        Console.WriteLine("Pick a number");
                        Num1 = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }


            Console.WriteLine("Time For Round 2!");
            Console.WriteLine("Pick a number!");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            bool RightNum2 = Num2 == 6;
            do
            {
                switch (Num2)
                {
                    case 1:
                        Console.WriteLine("Wrong!");
                        Console.WriteLine("Pick a number");
                        Num2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Wrong!");
                        Console.WriteLine("Pick a number");
                        Num2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("Right! Game over!");
                        RightNum2 = true;
                        break;
                    default:
                        Console.WriteLine("You're bad at this!");
                        Console.WriteLine("Pick a number");
                        Num2 = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }

            while (!RightNum2);



            Console.ReadLine();
        }
    }
}
