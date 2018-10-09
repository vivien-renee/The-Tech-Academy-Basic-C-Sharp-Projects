using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG129
{
    public class Employee : Person
    {
        public int ID { get; set; }
        public /*override*/ void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName + " ID # " + ID);
        }

        public static bool operator ==(Employee employee, Person person)
        {
            if (employee.ID == employee.ID)
                return true;
            else
                return false;
        }

        public static bool operator !=(Employee employee, Person person)
        {
            if (employee.ID != employee.ID)
                return true;
            else
                return false;
        }

    }
}