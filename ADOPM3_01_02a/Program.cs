using System;

namespace ADOPM3_01_02a
{
    class Program
    {
        public struct AStruct { public int iVal; }
        static void Main(string[] args)
        {
            //In is a classic value type
            AStruct x1 = new AStruct { iVal = 9 };
            AStruct x2 = new AStruct { iVal = 7 };

            x1 = x2;
            x2 = new AStruct { iVal = 10 };
            Console.WriteLine($"x1: {x1.iVal}, x2: {x2.iVal}");


            //Boxing the integer - it is now a reference type
            object ox1 = x1;
            object ox2 = x2;

            ox2 = new AStruct { iVal = 20 };
            ox1 = ox2;

            Console.WriteLine($"ox1: {((AStruct)ox1).iVal}, ox2: {((AStruct)ox2).iVal}");


            //Unbox the ox1, ox2 (variables of reference type) back into value types
            AStruct y1 = (AStruct)ox1;
            AStruct y2 = (AStruct)ox2;

            y1 = y2;
            y2 = new AStruct { iVal = 15 };
            Console.WriteLine($"y1: {y1.iVal}, y2: {y2.iVal}");

            /*
            //Below part not part of the exercise
            //Unbox the ox1, ox2 (variables of reference type) and cast it into a float
            float z1 = (float)(int)ox1;
            float z2 = (float)(int)ox2;

            z1 = z2;
            z2 = 15F;
            Console.WriteLine($"z1: {z1}, z2: {z2}");
            */
        }
    }

    //Exercise:
    //1.    Recreate the above code having x1 and x2 being of type public struct AStruct { public int iVal;}

}
