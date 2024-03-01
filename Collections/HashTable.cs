using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    internal class HashTable
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("Eid", 1010);
            ht.Add("Ename", "Scott");
            ht.Add("Job", "Manager");
            ht.Add("Salary", 25000.00);
            ht.Add("Mgrid", 1002);
            ht.Add("Phone", "1234567890");
            ht.Add("Email", "scott@gmail.com"); 
            ht.Add("Dname", "Sales");
            ht.Add("Location", "Mumbai");
            ht.Add("Did", 30);
            Console.WriteLine(ht["email"]);

            Console.WriteLine("Hello".GetHashCode());

            foreach(object key in ht.Keys)
            {
                Console.WriteLine(key + ":" + ht[key]);
            }

            Console.ReadLine();

        }

    }
}
 