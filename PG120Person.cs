using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG120Program.cs
{
   public class Person
    {
        
        public List<string> FirstName{ get; set; } //These are the properties
        public List<string> LastName { get; set; }
        

        public void SayName() //This is the method name
        {
           

            foreach (string FName in FirstName)
                foreach (string LName in LastName)
                {
                Console.WriteLine("Name: "  + FName + " " + LName);
                
            }
        }
            
    }
}
