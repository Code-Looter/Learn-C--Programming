using System;
using System.Collections;

namespace DataTypes_And_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
             // Instructions: In order to see data type value.
             // You must write Console.Writeline(datatype);
             // line is an example of the above.
            #region DataTypes
            int dec = 32;
            int hex = 0x2A;
            int bin = 0b_0010_1010;

            var a = 42.99;
            float b = 19.50f;
            System.Double c = -1.23;

            // decimal type
            decimal a_decimal = 42.99m;
            var b_decimal = 12.45;
            System.Decimal c_decimal = 100.75M;

            // char type
            char a_char = 'A';
            char b_char = '\x0065';
            char c_char = '\u15FE';

            // string type
            string string1;                       // unitialized
            string string2 = null;                // initialized with null
            string string3 = String.Empty;        // empty string
            string string4 = "hello world";       // initialized with text
            var string5 = "hello world";
            System.String string6 = "hello world";
            char[] letters = { 'h', 'e', 'l', 'l', 'o' };
            string s7 = new string(letters); // from an array of chars


            #endregion

            Console.WriteLine(string4);
        }
    }
}
