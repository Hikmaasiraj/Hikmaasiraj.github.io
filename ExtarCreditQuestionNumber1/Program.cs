using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtarCreditQuestionNumber1
{
    class Program
    {

        static int index(int i)
        {
            return 1 + (i >> 31) - (-i >> 31);
        }

        static void check(int n)
        {

            // string array to store all kinds of number 
            String[] s = { "negative", "zero", "positive" };

            // function call to check the sign of number 
            int val = index(n);

            Console.WriteLine(n + " is " + s[val]);
            Console.ReadLine();
        }

        //Driver code 
        public static void Main()
        {
            check(30);
            check(-20);
            check(0);
        }
    }
}
    

    

