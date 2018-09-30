using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG117Program.cs
{
    public class Pie
    {
        public void MyShare(int numberOfPies)

        {
            int myHalf = numberOfPies / 2;
            Console.WriteLine("That means I get " + myHalf);



        }

        public void MyShare(decimal numberOfPies)

        {
            int myHalf = Convert.ToInt32(numberOfPies) / 2;
            Console.WriteLine("That means I get " + myHalf);



        }

        public int Desserts (int numberOfPies)

        {
            int myDesserts = numberOfPies / 2;


            return myDesserts;


        }


       

    }
}
