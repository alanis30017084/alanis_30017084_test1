/*Name: Alanis Correa Kriener
  Question 1*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<< Program to find the result of base^exponent >>>");

            // Obtaining base as a double
            Console.Write("Please enter the value for the base: ");
            double num1 = double.Parse(Console.ReadLine());

            // Obtaining exponent as an integer
            Console.Write("Please enter the value for the exponent: ");
            int num2 = int.Parse(Console.ReadLine());
            double sum = 1;

            // Using for loop with built in counter to raise num1 by the exponent
            for (int i=num2; i>0; i--)
            {
                // Simplification of 'sum = sum + num1' to get total
                sum *= num1;
            }
            Console.WriteLine($"\n{num1}^{num2} = {sum}");
            Console.ReadLine();
        }
    }
}
