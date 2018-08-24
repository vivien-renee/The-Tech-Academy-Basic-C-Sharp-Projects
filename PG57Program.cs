using System;


namespace ConsoleAppPG57
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            Console.WriteLine("What page number?");
            string PageNumber = Console.ReadLine();
            int PgNum = Convert.ToInt32(PageNumber);

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            string Help = Console.ReadLine();
            bool Hlp = Convert.ToBoolean(Help);

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string Experiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string Feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string Hours = Console.ReadLine();
            int HRS = Convert.ToInt32(Hours);


            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            Console.ReadLine();

        }
    }
}
