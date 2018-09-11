using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG103Program.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            //#1
            //string[] animals = { "Dog", "Cat", "Rat", "Moose" };

            //Console.WriteLine("What would you like to say to the zoo animals? ");

            //string added = Console.ReadLine();

            //for (int i = 0; i < animals.Length; i++)
            //{

            //    Console.WriteLine(added + animals[i]);
            //}


            //#2

            //int loopy = 0;
            //while (loopy < 10)
            //{
            //    Console.WriteLine("This is the loop that never ends!");
            //}

            //#3

            //int loopy = 0;
            //while (loopy < 10)
            //{
            //    Console.WriteLine("The count is: " + loopy);
            //    loopy++;
            //}

            //#4

            //int count = 0;
            //while (count < 20)
            //{
            //    Console.WriteLine("The count is: " + count);
            //    count++;
            //}

            //#5

            //int count = 0;
            //while (count <= 20)
            //{
            //    Console.WriteLine("The count is: " + count);
            //    count++;
            //}

            //#6, 7, 8

            //List<string> animals = new List<string>() { "Dog", "Cat", "Bear", "Moose", "Rat" };
            //int k = 0;
            //int j = animals.Count - 1;
            //Console.WriteLine("Pick an animal");
            //string animalPick = Console.ReadLine();

            //for (int i = 0; i < animals.Count; i++)
            //{
            //    if (animals[i] == animalPick)
            //    {
            //        Console.WriteLine("You picked: " + animalPick);

            //    }

            //    else if (animals[i] != animalPick && (j > k))
            //    { k++; }
            //    else
            //    {
            //        Console.WriteLine(animalPick + " is not an option");
            //    }


            //}


            //#9, 10

            
            //List<string> days = new List<string>() {"Sunday", "Monday", "Tuesday", "Wednesday",
            //    "Thursday", "Friday", "Satruday", "Sunday"};
            //int k = 0;
            //int j = days.Count - 1;
            //Console.WriteLine("Pick an day of the week");
            //string dayPick = Console.ReadLine();

            //for (int i = 0; i < days.Count; i++)
            //{
            //    if (days[i] == dayPick)
            //    {
            //        Console.WriteLine(i);

            //    }

            //    else if (days[i] != dayPick && (j > k))
            //    { k++; }
            //    else
            //    {
            //        Console.WriteLine(dayPick + " is not an option");
            //    }


            //}


            //#11

            List<string> days = new List<string>() {"Sunday", "Monday", "Tuesday", "Wednesday",
                "Thursday", "Friday", "Satruday", "Sunday"};
            int k = 0;
            int j = days.Count - 1;
            Console.WriteLine("Pick an day of the week");
            string dayPick = Console.ReadLine();

            for (int i = 0; i < days.Count; i++)
            {
                if (days[i] == dayPick)
                {
                    Console.WriteLine(dayPick + " is on the list");

                }

                else if (days[i] != dayPick && (j > k))
                { k++; }
                else
                {
                    Console.WriteLine(dayPick + " is not on the list");
                }


            }


            Console.ReadLine();
        }
    }
}
