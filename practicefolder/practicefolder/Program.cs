using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicefolder
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ng = new Random();

            int a = ng.Next(1, 11);
            int b = ng.Next(1, 11);
            Console.WriteLine("What is" + a + "times" + b + "?");
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == a * b)
            {
                Console.WriteLine("Well done, your answer is correct!");
            } else
            {

            }
            int responesIndex = ng.Next(1, 4);
            switch (responesIndex)
            {
                case 1:
         
                    Console.WriteLine("Are you even trying");
                    break;
                case 2:
                    Console.WriteLine("You can do better");
                    break;
                default:
                    Console.WriteLine("The answers incorrect");
                    break;
        }
            Console.ReadKey();

        }

    }
                
            }
            
            

        
        