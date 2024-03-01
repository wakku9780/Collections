using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Student:IComparable<Student>
    {
        public int Sid { get; set; }
        public string Name { get; set; }
        public int Class {  get; set; }
        public float Marks {  get; set; }

        public int CompareTo(Student other)
        {
            if (this.Sid > other.Sid) return 1;
            else if (this.Sid < other.Sid) return -1;
            else return 0; 
        }
    }
    class CompareStudents : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Marks < y.Marks) return -1;
            else if (x.Marks > y.Marks) return 1;
            else return 0;
        }
    }
    class TestStudent
    {
        public static int  CompareNames(Student S1, Student S2)
        {
           return  S1.Name.CompareTo(S2.Name);                                            
        }
        static void Main()
        {
            Student s1 = new Student                      
            { 
              Sid = 103,
              Name = "Ajay",
              Class = 10,
              Marks = 575.00f 
            };

            Student s2 = new Student
            {
                Sid = 104,
                Name = "Avinash",
                Class = 10,
                Marks = 585.00f
            };

            Student s3 = new Student
            {
                Sid = 105,
                Name = "waqar",
                Class = 10,
                Marks = 550.00f
            };

            Student s4 = new Student
            {
                Sid = 106,
                Name = "Shahid",
                Class = 10,
                Marks = 595.00f
            };

            Student s5 = new Student
            {
                Sid = 107,
                Name = "Azeem",
                Class = 10,
                Marks = 585.00f
            };

            Student s6 = new Student
            {
                Sid = 108,
                Name = "Abdul",
                Class = 10,
                Marks = 589.00f
            };

            List<Student> Students = new List<Student>() { s1,s2,s3,s4,s5,s6};
            //CompareStudents obj = new CompareStudents();
            //Students.Sort(obj);
            // Students.Reverse(); 

            // Students.Sort(1, 4, obj);
            Comparison<Student> obj = new Comparison<Student>(CompareNames);

            Students.Sort(obj);            

            foreach(Student S in Students)
            {
                Console.WriteLine(S.Sid + " " + S.Name + " " + S.Class + " " + S.Marks);


            }
        }
                          
    }
}
