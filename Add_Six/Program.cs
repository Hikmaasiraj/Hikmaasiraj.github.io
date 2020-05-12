using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Six
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            Console.WriteLine(a);

            //AddSix(a); // calling the predefined method
            //This is called "Pass by value"

            Console.WriteLine(Add_Six(a)); //9

            //In C#, there are 2 ways to pass an argument by reference. 
            //1)reference 2)output parameter

            Console.ReadLine();
        }
       

        static int Add_Six(int total)
        {
            //int total;
            total = total + 7;
            //total += 6;

            return total;   //9
        }
        

    }
}
