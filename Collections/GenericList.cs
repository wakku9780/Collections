using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class GenericList
    {
        static void Main()
        {
            List<int> li = new List<int>();
            li.Add(1);
            li.Add(2);
            li.Add(3);
            li.Add(4);
            li.Add(5);
            li.Add(6);   
            
            for(int i=0;i<li.Count;i++)
            {
                Console.WriteLine(li[i] + " ");
            }
            li.Insert(3, 999);

            li.RemoveAt(1);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
