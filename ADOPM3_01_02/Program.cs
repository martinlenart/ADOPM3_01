using System;

namespace ADOPM3_01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 9;
            object obj = x;             // Box the int
            int y = (int)obj;           // Unbox the int

            object obj1 = 15;           // 15 is inferred to be of type int
            long x2 = (long)(int)obj1;  // Explicit casting needed

            object obj2 = 15L;          // 15 is explicit to be of type long
            long x3 = (long)obj1;       // Explicit casting 

            object obj3 = 3.5;          // 3.5 is inferred to be of type double
            int y1 = (int)(double)obj3;

            //Explain
            int i1 = 123;
            object o1 = i1;

            int i2 = (int)o1;
            object o2 = o1;
            o1 = 4;
            //Console.WriteLine(i1); // ?
            //Console.WriteLine(i2); // ?
            //Console.WriteLine(o1); // ?
            //Console.WriteLine(o2); // ?

            var m1 = new { k = 123 };
            object p1 = m1;
            var m2 = m1;
            object p2 = p1;
            m1 = new { k = 4 };
            //Console.WriteLine(m1); // ?
            //Console.WriteLine(m2); // ?
            //Console.WriteLine(p1); // ?
            //Console.WriteLine(p2); // ?
        }
    }

    //Exercise:
    //1.    Discuss in the group and explain the printout in the Explain section
    //2.    Create boxing and unboxing using tuples
}
