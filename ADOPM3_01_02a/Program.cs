using System;

namespace ADOPM3_01_02a
{
    class Program
    {
        public struct AStruct { public int iVal; }
        static void Main(string[] args)
        {
            //AStruct is a complex value type
            AStruct x1 = new AStruct { iVal = 9 };
            AStruct x2 = new AStruct { iVal = 7 };

            x1 = x2;
            x2.iVal = 10;
            Console.WriteLine($"x1: {x1.iVal}, x2: {x2.iVal}");

            //Boxing the AStruct - it is now of reference type object
            object ox1 = x1;
            object ox2 = x2;

            ox1 = ox2;
            Console.WriteLine($"ox1: {((AStruct)(ox1)).iVal }, ox2: {((AStruct)(ox2)).iVal}");

            //Implicit unboxing makes it appear as a value type.
            //==> that is why I cannot change content ox2
            //((AStruct)(ox2)).iVal = 20; //compiler error

            //==> but I can create a new instance of ox2
            ox2 = new AStruct { iVal = 20 };
            Console.WriteLine($"ox1: {((AStruct)(ox1)).iVal }, ox2: {((AStruct)(ox2)).iVal}");

            //Unbox the ox1, ox2 (variables of reference type) back into value types
            AStruct y1 = (AStruct)ox1;
            AStruct y2 = (AStruct)ox2;

            y1 = y2;
            y2.iVal = 15;
            Console.WriteLine($"y1: {y1.iVal}, y2: {y2.iVal}");
        }
    }
}
