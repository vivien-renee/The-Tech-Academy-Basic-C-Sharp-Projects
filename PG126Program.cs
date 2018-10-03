using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG126Program.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee();
            person.firstName = "Sample";
            person.lastName = "Student";
            person.SayName();

            IQuittable quittable = new Employee();
            quittable.Quit();

            Console.ReadLine();
        }

        public abstract class Person
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public abstract void SayName();
        }

        public class Employee : Person, IQuittable
        {
            public override void SayName()
            {
                Console.WriteLine("Name: " + firstName + " " + lastName);
            }
            public void Quit()
            {
                Console.WriteLine("I Quit.");
            }
        }

        interface IQuittable
        {
            void Quit();
        }




    }
    
}
