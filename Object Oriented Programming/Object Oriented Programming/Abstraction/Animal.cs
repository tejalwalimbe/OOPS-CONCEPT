using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming.Abstraction
{
       abstract class Animal
        {
            public abstract void animalSound();
            public void sleep()
            {
                Console.WriteLine("Animal needs to sleep");
                Console.ReadLine();
            }
        }

        class Cat : Animal
        {
            public override void animalSound()
            {
                Console.WriteLine("The Cat says: meao meao");
                Console.ReadLine();
            }
        }
    }




