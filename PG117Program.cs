using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG117Program.cs
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Pie pie = new Pie();
            //int myHalf;
            int myDesserts;
            




            Console.WriteLine("How many pies do we have?");
            int numberOfPies = Convert.ToInt32(Console.ReadLine());

            pie.MyShare(numberOfPies);




            myDesserts = pie.Desserts(numberOfPies);

            Console.WriteLine("I will eat " + myDesserts + " pies today");

            int value = Favorite.howMuch;

            Console.WriteLine("I love dessert " + value + "% of the time!");
            Console.ReadLine();

        }
    }
}
