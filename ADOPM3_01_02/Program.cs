using System;

namespace ADOPM3_01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //In is a classic value type
            int x1 = 9;
            int x2 = 7;

            x1 = x2;
            x2 = 10;
            Console.WriteLine($"x1: {x1}, x2: {x2}");

            //Boxing the integer - it is now a reference type
            object ox1 = x1;
            object ox2 = x2;

            ox1 = ox2;
            ox2 = 10;
            Console.WriteLine($"ox1: {ox1}, ox2: {ox2}");

            //Unbox the ox1, ox2 (variables of reference type) back into value types
            int y1 = (int)ox1;           
            int y2 = (int)ox2;

            y1 = y2;
            y2 = 15;
            Console.WriteLine($"y1: {y1}, y2: {y2}");

            //Below part not part of the exercise
            //Unbox the ox1, ox2 (variables of reference type) and cast it into a float
            float z1 = (float)(int)ox1;
            float z2 = (float)(int)ox2;

            z1 = z2;
            z2 = 15F;
            Console.WriteLine($"z1: {z1}, z2: {z2}");
        }
    }

    //Exercise:
    //1.    Recreate the above code having x1 and x2 being of type public struct AStruct { public int iVal;}

}
