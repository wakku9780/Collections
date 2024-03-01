using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine(al.Capacity);
            al.Add(100);
            
            Console.WriteLine(al.Capacity);
            al.Add(300);
            al.Add(400);
            al.Add(500);
            al.Add(600);
            al.Add(700);                      
            al.Add(800);
            Console.WriteLine(al.Capacity);

            foreach (int i in al)
            {
                Console.WriteLine(i+" ");
            }
            Console.WriteLine();
            al.Insert(3, 999);
            al.Insert(4, 1099);

            al.RemoveAt(1);
            Console.WriteLine(al.Capacity);

            foreach (int i in al)
            {
                Console.WriteLine(i + " ");
            }
            Console.ReadLine();
        }
    }
}
