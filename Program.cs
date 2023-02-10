using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number :");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Operator :");
            string operand = Console.ReadLine();

            Console.WriteLine("Enter the second number :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (operand == "+")
            {
                Console.WriteLine(num1 + num2);
            }

            else if (operand == "-")
            {
                Console.WriteLine(num1 - num2);
            }

            else if(operand == "*")
            {
                Console.WriteLine(num1 * num2);
            }

            else if(operand == "/")
            {
                Console.WriteLine(num1 / num2);
            }

            else
            {
                Console.WriteLine("Sorry, you entered a wrong operator !");
            }

            Console.ReadLine(); 
        }
    }
}
