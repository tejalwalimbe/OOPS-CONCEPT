using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming.Polymorphism
{
        public class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Animals are Eating");
                Console.ReadLine();
            }
        }
        public class Dog : Animal
        {
            public void Eat()
            {
                Console.WriteLine("Dog are Eating");
                Console.ReadLine();
            }
        }
    }



