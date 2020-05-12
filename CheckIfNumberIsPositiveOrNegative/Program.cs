using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfNumberIsPositiveOrNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            //CHECKING WHETHER A NUMBER IS POSITIVE OR NEGATIVE OR ZERO

            int n;
            Console.WriteLine("Enter a Number");
            n = int.Parse(Console.ReadLine());
            if (n >= 0)
            {
                if (n == 0)
                {
                    Console.WriteLine("Enterde Number is Zero");
                }
                else
                {
                    Console.Write(n + " is positive Number");
                }
            }
            else
            {
                Console.WriteLine(n + "is Negatige Number");
            }
            Console.ReadLine();
        }
    }
}

