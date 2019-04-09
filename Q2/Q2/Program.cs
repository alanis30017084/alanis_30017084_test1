/*Name: Alanis Correa Kriener
        Question 2*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<< This program will display the sum total of 5 prices >>>\n");
            // Attempt to get to 2 decimal places
            double sum = 0.00D;
            // for loop to use an incrementing counter
            for (int i = 1; i <= 5; i++)
            {
                // Using counter to display item number
                Console.Write($"Please enter the price of item {i}: ");
                double price = double.Parse(Console.ReadLine());
                sum += price;
            }
            Console.WriteLine($"\nThe total price of these items is ${sum}");
            Console.ReadLine();
        }
    }
}
