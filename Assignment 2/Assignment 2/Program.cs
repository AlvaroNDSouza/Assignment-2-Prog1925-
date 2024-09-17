using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alvaro Noronha, Assignment 2
           // Name of the project: Coding flowchart
          // Purpose: Making sure I understand the flowchart as well as the tools to code one such as if and if elses, variables and converting variabless.
         

            Console.WriteLine("Welcome to PROG1925 Assignment");
            string lastName;
            string firstName;
            int age;
            double payment;
            double result;
            double hst;
            

            Console.WriteLine("Please enter your Last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Please enter your First name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Please enter your Age:");
            bool validAge = int.TryParse(Console.ReadLine(), out age); // Error handling. " If the user do not input number it will print a error message"
            if (!validAge)
            {
                Console.WriteLine("Invalid age. Please try again.");
                return;
            }


            if (age <= 20)
            {
                //Must pay 37.00 + Tax
                payment = 37.00;
                hst = payment * 0.13;
                result = hst + payment;
                Console.WriteLine($"Your first name is : {firstName} and your last name is:{lastName}\n the payment (tax included) is :  {result.ToString("C")}");
            }
            else if (age > 20 && age < 30) 
            {
                //Must pay  50.00 + Tax
                payment = 50.00;
                hst = payment * 0.13;
                result = hst + payment;
                Console.WriteLine($"Your first name is : {firstName} and your last name is:{lastName}\n the payment (tax included) is :  {result.ToString("C")}");
            }
            else if (age >= 30 && age < 60)
            {
                //Must pay 53.00 + Tax
                payment = 53.00;
                hst = payment * 0.13;
                result = hst + payment;
                Console.WriteLine($"Your first name is : {firstName} and your last name is:{lastName}\n the payment (tax included) is :  {result.ToString("C")}");
            }
            else if (age >= 60)
            {
                //Must pay 0 + Tax
                payment = 0;
                hst = payment * 0.13;
                result = hst + payment;
                Console.WriteLine($"Your first name is : {firstName} and your last name is:{lastName}\n the payment (tax included) is :  {result.ToString("C")}");
            }
            else
            {
                //None of the above
                Console.WriteLine("Please Try again");
            }
           
        }
    }
}
