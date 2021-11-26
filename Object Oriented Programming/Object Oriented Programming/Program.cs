using System;
using Object_Oriented_Programming.Abstraction;
using Object_Oriented_Programming.ClassAndObjects;
using Object_Oriented_Programming.Encapsulation;
using Object_Oriented_Programming.Inheritance;
using Object_Oriented_Programming.Polymorphism;


namespace Object_Oriented_Programming
{

    class Program
    {
        static void Main(string[] args)
        {
            //Class--Calculator

            Console.WriteLine("========================================================================================================================");
            Console.WriteLine(" \t   \t   \t  ================== Welcome To Opps Concept ===============");
            Console.WriteLine("\n");
            Console.WriteLine(" \t   \t   \t  -------------------- Class and Object --------------------");
            Calculator cal = new Calculator();
            cal.a = 45;
            cal.b = 30;
            Console.Write("Addition of 2 integer Number : ");
            cal.add();
            Console.Write("Subtraction of 2 integer Number : ");
            cal.sub();
            Console.WriteLine("========================================================================================================================");

            //Class--Employee (Inheritance)
            Console.WriteLine("\n");
            Console.WriteLine(" \t   \t   \t  ---------------------- Inheritance ----------------------");
            Console.WriteLine("\n");
            Customer c = new Customer();
            Console.Write("Base Class-Employee : ");
            c.Billing();
            Console.Write("Child Class-Customer : ");
            c.BillSlip();
            Console.WriteLine("========================================================================================================================");

            //Class--overloading (Polymorphism)
            Console.WriteLine("\n");
            Console.WriteLine(" \t   \t   \t  ---------------------- Polymorphism ----------------------");
            Console.WriteLine("\n");
            Console.WriteLine(" \t   \t   \t  ---------------------- Overloading -----------------------");
            overloading o = new overloading();
            Console.Write("Addition of 2 integer Number : ");
            o.Add(4, 6);
            Console.Write("Addition of 2 Float Number : ");
            o.Add(5.5f, 7.2f);

            //Class--overriding (Polymorphism)
            Console.WriteLine(" \t   \t   \t  ==========================================================");
            Console.WriteLine("\n");
            Console.WriteLine(" \t   \t   \t  ---------------------- Overriding ------------------------");
            Dog dog = new Dog();
            dog.Eat();
            Console.WriteLine("========================================================================================================================");

            //Class-- overriding (Abstraction)
            Console.WriteLine("\n");
            Console.WriteLine(" \t   \t   \t  ---------------------- Abstraction ------------------------");
            Cat cat = new Cat();
            cat.animalSound();
            cat.sleep();
            Console.WriteLine("========================================================================================================================");

            //Class-- Student(Abstraction)
            Console.WriteLine("\n");
            Console.WriteLine(" \t   \t   \t  ---------------------- Encapsulation ------------------------");
            Student st = new Student();
            st.FirstName = "Tejal";
            st.LastName = "Walimbe";
            Console.Write("FirstName : ");
            Console.WriteLine(st.FirstName);
            Console.ReadLine();
            Console.Write("LastName : ");
            Console.WriteLine(st.LastName);
            Console.ReadLine();
            Console.WriteLine("========================================================================================================================");
        }

    }
}
