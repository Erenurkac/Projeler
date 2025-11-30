using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number_Check
{
    internal class Program
    {
        static void Main()
        {
            int a, i, c = 0;

            Console.WriteLine("Enter a number to check if it is prime:");
            a = int.Parse(Console.ReadLine());

            for (i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    c++;
                }
            }

            if (c == 2)
            {
                Console.WriteLine("{0} is a prime number", a);
            }
            else
            {
                Console.WriteLine("{0} is not a prime number", a);
            }
        }
    }
}
