using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG100Program.cs
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = { "Cat", "Dog", "Bear", "Moose" };


            Console.WriteLine("Pick an Index number, 0-3.");
            int indexPick = Convert.ToInt32(Console.ReadLine());
            bool rightNum = indexPick < stringArray.Length;

            do
            {
                switch (indexPick)
                {

                    case 0:
                        Console.WriteLine("Your Choice Is: " + stringArray[indexPick]);
                        rightNum = true;
                        break;


                    case 1:
                        Console.WriteLine("Your Choice Is: " + stringArray[indexPick]);
                        rightNum = true;
                        break;

                    case 2:
                        Console.WriteLine("Your Choice Is: " + stringArray[indexPick]);
                        rightNum = true;
                        break;

                    case 3:
                        Console.WriteLine("Your Choice Is: " + stringArray[indexPick]);
                        rightNum = true;
                        break;

                    default:
                        Console.WriteLine("I said pick a number between 0-3! try again!");
                        indexPick = Convert.ToInt32(Console.ReadLine());
                        break;
                }


            }
            while (!rightNum);


            int[] intArray = { 9, 7, 4, 12 };
            Console.WriteLine("Pick an index number, 0-3.");
            int indexPick1 = Convert.ToInt32(Console.ReadLine());
            bool rightNum1 = indexPick1 < intArray.Length;


            do

            {

                switch (indexPick1)
                {

                    case 0:
                        Console.WriteLine("You will get " + intArray[indexPick1] + " " + stringArray[indexPick] + "'s");
                        rightNum1 = true;
                        break;


                    case 1:
                        Console.WriteLine("You will get " + intArray[indexPick1] + " " + stringArray[indexPick] + "'s");
                        rightNum1 = true;
                        break;

                    case 2:
                        Console.WriteLine("You will get " + intArray[indexPick1] + " " + stringArray[indexPick] + "'s");
                        rightNum1 = true;
                        break;

                    case 3:
                        Console.WriteLine("You will get " + intArray[indexPick1] + " " + stringArray[indexPick] + "'s");
                        rightNum1 = true;
                        break;

                    default:
                        Console.WriteLine("I said pick a number between 0-3! try again!");
                        indexPick1 = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!rightNum1);


            List<string> stringList = new List<string>();
            stringList.Add("the first string.");
            stringList.Add("the second string.");
            stringList.Add("the third string.");
            stringList.Add("the fourth string.");


            Console.WriteLine("Pick and index number, 0-3");
            int stringPick = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You picked " + stringList[stringPick]);

            Console.ReadLine();
        }
    }
}
