using System;
using System.Collections.Generic;

namespace Understanding_Constants
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constant vairables exmaples
            const int a = 42;

            // From the Value Type section example
            int a_time = 20;
            DateTime dt = new DateTime(2024, 11, 10);

            Console.WriteLine(dt);

            // More examples inside the same "Value Type: Section
            int a_value_Type = 20;
            int b_Value_Type = a_value_Type;    // b is 20
            a_value_Type = 42;

            // From the "REference Types" Section
            int[] a_reference_type = new int[10];
            string s_reference_type = "Sample";
            object o_reference_type = new List<int>();

            int[] a1 = new int[] { 42, 43 };
            int[] a2 = a1;      // a2 is {42, 43}
            a1[0] = 0;         // a1 is {0,43}, a2 is {0, 43}

            // From the Boxing and Unboxing section
            int a_example = 42;
            object o_example = a;       // boxing
            o_example = 43;
            int b_example = (int)o_example; // unboxing
            
        }
    }
}
