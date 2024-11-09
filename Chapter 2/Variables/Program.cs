using System;
using System.Collections;
using System.Collections.Generic;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            bool f;
            char ch = 'x';
            int a, b = 20, c = 42;
            a = -1;
            f = true;
            Program ScopeFunction = new Program();  // This program makes the ScopeUnderstanding() function readable.

            // Implicity-typed variable example
            var a_var = 10;

            // Understanding the scope and lifetime of variables
            ScopeFunction.ScopeUnderstanding();

            
        }



        public void ScopeUnderstanding()
        {
            // This is an example of scope. IT will throw a compiler error.
            int a = 5;
            for(int i = 1; i <10; i++)
            {
                char a = 'w';   // Compiler error

                if(i%2 == 0)
                {
                    Console.WriteLine(i + a);   // a is within the scope of Main
                }
            }

            i = 20; //  i is out of scope
        }
    }
}
