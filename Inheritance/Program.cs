using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.ID = 1;
            customer.FirstName = "Tugberk";
            customer.LastName = "Gungor";

            Person[] persons = new Person[3]
            {
                new Customer{ FirstName = "tugberk"}, new Person{ FirstName = "tuborg"}, new Student{ FirstName = "turboooo"}
            };

            foreach (Person p in persons) 
            {
                Console.WriteLine(p.FirstName);
            }

            Console.Read();
        }

        interface IPerson //bir class yalnizca tek bir class'i inherit alabilir. Ancak sinirsiz sayida interface'i inherit alabilir.
        {
        
        }

        class Person
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }

        class Customer:Person, IPerson //person icerisindeki propertiesleri miras aldi.
        {
            
        }

        class Student : Person
        {


        }

        class Person2
        {


        }
    }
}
