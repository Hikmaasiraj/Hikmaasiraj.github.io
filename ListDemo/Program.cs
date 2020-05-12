using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> noList  = new List<int>();
            //noList.Add(1);
            //noList.Add(5);

            //for(int i = 0; i < noList.Count; i++)
            //{
            //    Console.WriteLine(noList[i]);
            //    Console.ReadLine();

            List<string> nameList = new List<string>();
                nameList.Add("Andy");
            nameList.Add("Bob");
            nameList.Add("Charles");

            for(int i =0; i < nameList.Count; i++)
            {
                Console.WriteLine(nameList);
                Console.ReadLine();
            }

        }




        }
    }

