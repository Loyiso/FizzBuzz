using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Check if given numbers are divisible by a given number.";

            Console.WriteLine("Enter first number: ");

            var firstNumberKey = Console.ReadKey();
            int firstNumber = 0;

            if (char.IsDigit(firstNumberKey.KeyChar))
            {
                firstNumber = int.Parse(firstNumberKey.KeyChar.ToString());
            }
            else
            {
                throw new InvalidOperationException("First number must be a numeric value.");
            }

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Enter second number: ");

            var firstSecondKey = Console.ReadKey();
            int secondNumber = 0;

            if (char.IsDigit(firstSecondKey.KeyChar))
            {
                secondNumber = int.Parse(firstSecondKey.KeyChar.ToString());
            }
            else
            {
                throw new InvalidOperationException("Second number must be a numeric value.");
            }

            var isNumberDivisible = (firstNumber % secondNumber) == 0;

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine(isNumberDivisible ? "Yes" : "No");
             
            Console.ReadLine();
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        for (int i = 1; i <= 100; i++)
    //        {
    //            if (i % 3 == 0 && i % 5 == 0)
    //            {
    //                Console.WriteLine("FizzBuzz");
    //                continue;
    //            }

    //            if (i % 3 == 0)
    //            {
    //                Console.WriteLine("Fizz");
    //            }
    //            else if (i % 5 == 0)
    //            {
    //                Console.WriteLine("Buzz");
    //            }
    //            else
    //            {
    //                Console.WriteLine(i + Environment.NewLine);
    //            }
    //        }

    //        Console.ReadLine();
    //    }
    //}
}
