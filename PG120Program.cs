using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG120Program.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee();


            person.FirstName = new List<string>() { "Sample"  };
            person.LastName = new List<string>() { "Student" };
            person.SayName();

            Console.ReadLine();
        }
    }

}
