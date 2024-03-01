using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Generics2<T>
    {
        public void Add(T a,T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1+d2);
        }

        public void Sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }

        public void Mul(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1*d2);
        }

        public void Div(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 /  d2);
        }
        static void Main()
        {
            Generics2<int> obj = new Generics2<int>();
            obj.Add(10, 20);
            obj.Add(20, 30);
            obj.Div(40, 20);
            obj.Mul(2, 4);
            obj.Sub(50, 10);  

            Console.ReadLine();

        }

    }
}
