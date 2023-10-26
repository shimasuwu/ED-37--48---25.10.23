using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo();

            ICustomerDal[] cusomerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(), //[0]
                new OracleCustomerDal() // [1]
            };

            foreach (var item in cusomerDals)
            {
                item.Add();
            }

            Console.Read();
        }

        private static void Demo()
        {
            CustomerManager cm = new CustomerManager();
            cm.Add(new SqlServerCustomerDal());


            CustomerManager cm2 = new CustomerManager();
            cm2.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager pm = new PersonManager();

            Customer customer = new Customer()
            {
                ID = 1,
                FirstName = "tugberk",
                LastName = "gungor",
                Address = "istanbul"
            };

            pm.Add(new Customer { ID = 1, FirstName = "Tugberk", LastName = "Gungor", Address = "Istanbul" });

            Console.ReadLine();
        }
    }
    interface IPerson
    {
        int ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }

    class Customer : IPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

    }

    class PersonManager
    {
        public void Add(IPerson customer) 
        {
            Console.WriteLine(customer.FirstName);

        }
    }
}
