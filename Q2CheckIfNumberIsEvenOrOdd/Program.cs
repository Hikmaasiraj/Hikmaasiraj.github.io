using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2CheckIfNumberIsEvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            //  CHECK IF NUMBER IS EVEN OR ODD
            int num;
            Console.WriteLine("Enter your Number");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is an Even Integer");
            }
            else
            {
                Console.WriteLine(num + " is an Odd Integer");
            }
            Console.ReadLine();
        }
    }
}
