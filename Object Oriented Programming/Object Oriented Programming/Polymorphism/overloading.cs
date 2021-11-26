using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming.Polymorphism
{
        public class overloading
        {
            public void Add(int a, int b)
            {
                Console.WriteLine(a + b);
                Console.ReadLine();
            }
            public void Add(float a, float b)
            {
                Console.WriteLine(a + b);
                Console.ReadLine();
            }
        }
    }


