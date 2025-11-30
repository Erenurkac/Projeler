using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main()
        {
            int number1, number2;
            char operation;
            int result;
            Console.Write("Enter first number:");
          number1=  int.Parse(Console.ReadLine());
            Console.Write("Enter second number"); 
            number2= int.Parse(Console.ReadLine());
            Console.Write("Choose the operator +,-,*,/");
            operation = Console.ReadLine();
            switch (operation)
            {
                case '+':result = number1 + number2;
                 
                      Console.WriteLine(result);
                    break;
                case '-':
                    result = number1 - number2;

                    Console.WriteLine(result);
                    break;
                case '*':
                    result = number1 * number2;

                    Console.WriteLine(result);
                    break;
                case '/':
                    result = number1 / number2;

                    Console.WriteLine(result);
                    break;
            }
        }
    }
}
