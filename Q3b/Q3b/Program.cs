/*Name: Alanis Correa Kriener
        Question 3b*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try to solve the following algebraic equation:\n2(x - 3) + x = 12\n");

            // Variable 'guess' declared and obtained
            Console.Write("Please enter your guess for the value of x: ");
            int guess = int.Parse(Console.ReadLine());

            // Solution x = 6 initialized
            int x = 6;

            // Using if/else statement to check for correct answer
            if (guess == x)
            {
                Console.WriteLine("Your guess is correct.");
            }
            else
            {
                Console.WriteLine("Sorry that guess was incorrect.");
            }
            Console.ReadLine();
            
            /*
            Workings for equation.
            2(x - 3) + x = 12
            2x - 6 + x = 12
            3x - 6 = 12
            3x = 18
            x = 6
            */

        }
    }
}
