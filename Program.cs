using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace Assignemnt4
{

    class Program
    {
        static void Main(string[] args)
        {

            //Person person = new Person(); 

            Customer customer = new Customer();
            Emp emp = new Emp();
            Student student = new Student();
 

            Person[] people = { customer, emp, student }; //Polymorphism

            foreach (Person persons in people)
            {
                persons.DoSomeWork();
            }

            Console.ReadLine();

        }
        class Customer : Person   //Inheritance
        {

            public int CustomerID { get; set; }

            public string ShippingAddress { get; set; }
            public override void DoSomeWork()
            {
                Console.WriteLine("This person is going to make an order.");
            }

        }

        class Emp : Person
        {
            public string department { get; set; }

            public double salary { get; set; }

            public override void DoSomeWork()
            {
                Console.WriteLine("The employee is going to fulfill the customer's order.");
            }
        }

        class Student : Person
        {

            public int Rollnumber { get; set; }

            public string studyingClass { get; set; }

            public override void DoSomeWork()
            {
                Console.WriteLine("The student is going to study.");
            }
        }

        abstract class Person  //Abstraction
        {

            public string Address { get; set; } 
            
            public int age { get; set; }
            
            public string city { get; set; }
            
            public string Name { get; set; }
            
            public abstract void DoSomeWork();
            

                //Console.WriteLine("This person is going to do some work.");


            interface Interface1 
                
            {
                
            public void DoSomeWork();
                
            }
            
        }
    }
}
