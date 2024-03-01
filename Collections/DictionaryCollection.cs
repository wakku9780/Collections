﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class DictionaryCollection
    {
        static void Main()
        {
            Dictionary<string , object> dt = new Dictionary<string , object>();
            dt.Add("Eid", 1010);
            dt.Add("Ename", "Scott");
            dt.Add("Job", "Manager");
            dt.Add("Salary", 25000.00);
            dt.Add("Mgrid", 1002);
            dt.Add("Phone", "1234567890");
            dt.Add("Email", "scott@gmail.com");
            dt.Add("Dname", "Sales");
            dt.Add("Location", "Mumbai");
            dt.Add("Did", 30);

            foreach(string key in dt.Keys)
            {
                Console.WriteLine(key+ ":" + dt[key]);
            }
            Console.ReadLine();
        }
    }
}
