using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            
            Console.WriteLine();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer cstm = new Customer();
            cstm.ID = 1;
            cstm.city = "istanbul";
            cstm.fn = "tugberk";
            cstm.ln = "gungor";


            Console.Read();
        }

        class CustomerManager 
        {
            public void Add()
            {
                Console.WriteLine("Customer Added.");
            }
            public void Update()
            {
                Console.WriteLine("Customer Updated.");
            }
        }
 

    }
}
