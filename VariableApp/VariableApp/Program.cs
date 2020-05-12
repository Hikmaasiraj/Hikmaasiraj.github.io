using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int x;
             int y;

             x = 7;
             y = x + 3;
             Console.WriteLine(y);

             Console.WriteLine();*/

            // string myFirstName;
            // myFirstName = "Hikmat";
            // string myFirstName = "Hikmat";
            // var myFirstName = "Hikmat";

            // Console.WriteLine(myFirstName);

            int x = 7;
            // string y = "Hikmat";
            string y = "5";
            String myFirstTry = x.ToString() + y;

            //int mySecondTry = x + y;
            int mySecondTry = x + int.Parse(y);
            Console.WriteLine(myFirstTry);
           // Console.WriteLine(mySecondTry);
            

            Console.ReadLine();
        }
    }
}
