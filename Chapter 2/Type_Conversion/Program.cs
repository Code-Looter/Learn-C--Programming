using System;

namespace Type_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {

        } // Main Method


        public void Implicit_Type_Conversion()
        {
            // Frist Example
            int i = 10;
            float f = i;
            long l = 7195467872;
            double d = l;

            // Second example
            string s = "example";
            object o = s;
        } // Implicit_Type_Conversion method


        public void Explicit_Type_Conversion()
        {
            // First Example

            double d = 12.34;
            int i = (int)d;

            // Second Example

            string s = "example";
            object o = s;          // implicit conversion
            string r = (string)o;  // explicit conversion
        } // Explicit_Type_Conversion method

        public void User_Defined_Type_Conversions()
        {
            // First Example
            /* public readonly struct fancyint
{
    private readonly int value;
    public fancyint(int value)
    {
        this.value = value;
    }
    public static implicit operator int(fancyint v) => v.value;
    public static explicit operator fancyint(int v) => new fancyint(v);
    public override string ToString() => $"{value}";
}*/

            // Second Example
            /*fancyint a = new fancyint(42);
int i = a;                 // implicit conversion
fancyint b = (fancyint)i;  // explicit conversion
             * 
             */

            // Third Exmaple
            DateTime dt1 = DateTime.Parse("2019.08.31");
            DateTime.TryParse("2019.08.31", out DateTime dt2);
            int i1 = int.Parse("42");          // successful, i1 = 42
            int i2 = int.Parse("42.15");       // error, throws exception
            int.TryParse("42.15", out int i3); // error, returns false, 
                                               // i3 = 0
        } // User_Defined_Type_Conversion
    }

}
 