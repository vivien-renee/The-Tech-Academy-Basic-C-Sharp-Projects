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
            int myDesserts;

            Console.WriteLine("How many pies do we have?");
            int numberOfPies = Convert.ToInt32(Console.ReadLine());
            pie.MyShare(numberOfPies);

            Console.WriteLine("How many cakes do we have?");
            int numberOfCakes = Convert.ToInt32(Console.ReadLine());
            pie.MyShare(numberOfPies, numberOfCakes);

            

            pie.Desserts(out myDesserts);
            Console.WriteLine("I was hoping to get " + myDesserts + " desserts today.");
            int howMuch;
            howMuch = Favorite.dessertLove();


            Console.WriteLine("I love dessert " + howMuch + "% of the time!");
            Console.ReadLine();

        }
    }


    public class Pie
    {
        public void MyShare(int numberOfPies)

        {
            int myHalf = numberOfPies / 2;
            Console.WriteLine("That means I get " + myHalf);
        }

        public void MyShare(int numberOfPies, int numberOfCakes)

        {
            int myHalfs = (numberOfPies + numberOfCakes) / 2;
            Console.WriteLine("That means I get " + myHalfs + " desserts!");
        }



        public void Desserts(out int myDesserts)

        {
            myDesserts = 22;
        }

    }


    public static class Favorite

    {
        

        public static int dessertLove()

        {
            int howMuch = 100;

            return howMuch;

        }
    }


    


}

