using System;

namespace Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            // First examples
            Nullable<int> a;
            Nullable<int> b = null;
            Nullable<int> c = 42;

            /* 
             * you can also right the preceding code like this:
             * int? a;
             * int? b = null;
             * int> c = 42;
             */

            if (c.HasValue)
                Console.WriteLine(c.Value);     // Remember, if the if statement has only one line, you can foget about the
                                                // curly braces
            

        }
    }
}
