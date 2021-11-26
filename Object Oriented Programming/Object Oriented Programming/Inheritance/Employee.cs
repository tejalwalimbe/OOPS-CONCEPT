using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming.Inheritance
{
   public  class Employee
    {
        public void Billing()
        {
            Console.WriteLine("Employee is doing Billing");
            Console.ReadLine();
        }
    }

    public class Customer : Employee
    {
        public void BillSlip()
        {
            Console.WriteLine("Customer is paying the Bill");
            Console.ReadLine();
        }
    }
}
   