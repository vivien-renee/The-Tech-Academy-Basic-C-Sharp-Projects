using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PG97Program.cs
{
    class Program
    {
        static void Main()
        {
            string String1 = "String 1 " ;
            string String2 = "String 2 ";
            string String3 = "String 3 ";
            Console.WriteLine(String1 + String2 + String3);

            String1 = String1.ToUpper();
            Console.WriteLine("Uppercase" + String1);

            StringBuilder sb = new StringBuilder();

             
            sb.Append("There once was a cat from a tree. ");
            sb.Append("The cat was orange, but hated oranges. ");
            sb.Append("This cat from a tree would stay up all night practicing his singing, which rather annoyed his neighbors, the Owls. ");
            sb.Append("Eventually the Owls put up a craigslist ad which stated that the cat was up for adoption. ");
            sb.Append("The very next day the Owls received three phone calls about the cat, but only one was actually interested in bringing the cat home. ");
            sb.Append("The cat liked his new home, and the Owls could now binge their Netflix shows without an annoying neighboor singing at the top of his lungs.");
            sb.Append("THE END.");





            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
