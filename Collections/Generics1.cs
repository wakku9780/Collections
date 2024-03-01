using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Generics1
    {
        public bool Compare<T>(T a,T b) 
        {
            if (a.Equals(b)) return true;
            return false;
        }
        
        static void Main()
        {
            Generics1 obj = new Generics1();
            bool result = obj.Compare<float>(10.45f, 20.75f);
            Console.WriteLine(result);

            bool result1 = obj.Compare<int >(10, 10);
            Console.WriteLine(result1);

            result = obj.Compare(10.5, 20.5);
            Console.WriteLine(result);
            Console.ReadLine();  
        }
    }
}
