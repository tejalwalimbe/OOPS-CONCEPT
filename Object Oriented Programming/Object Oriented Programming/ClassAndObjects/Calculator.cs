using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming.ClassAndObjects
{
    class Calculator
    {
        
        public int a;
        public int b;
        public int result;

        public void add()
        {
            result = a + b;
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public void sub()
        {
            result = a - b;
            Console.WriteLine(result);
            Console.ReadLine();
        }

    }
}
    
