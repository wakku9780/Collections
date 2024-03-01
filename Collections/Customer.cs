using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Customer
    {
        public int CustId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Balance { get; set; }

    }
    class TestCustomer
    {
        static void Main()
        {
            List<Customer> Customers = new List<Customer>();
            Customer c1 = new Customer
            {
                CustId = 101,
                Name = "Scott",
                City = "Hyd",
                Balance = 25000.00
            };
            Customer c2 = new Customer
            {
                CustId = 102,
                Name = "Jimmy",
                City = "Blr",
                Balance = 35000.00
            };
            Customer c3 = new Customer
            {
                CustId = 1013,
                Name = "Hashim",
                City = "MP",
                Balance = 45000.00
            };
            Customer c4 = new Customer
            {
                CustId = 1014,
                Name = "Shahid",
                City = "MP",
                Balance = 55000.00
            };

            Customers.Add(c1);
            Customers.Add(c2);
            Customers.Add(c3);
            Customers.Add(c4);
            //Customers.AddRange()-> we can add multiple items at a same time

            foreach(Customer obj in Customers)
            {
                Console.WriteLine(obj.CustId+" "+obj.Name+" "+obj.City+" "+obj.Balance);
            }

            Console.ReadLine();

        }
    }
}
 