using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayArgument_TestScores
{
    public partial class Test_Score : Form
    {
        public Test_Score()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. user the Random class
            Random random = new Random();
            // variable to store highest lowest average;
            double highest, lowest, average;
            //2. create an array to store the 5 test scores, in range of 0-100
            int[] number = new int[5];
            //3. use for loop to genereate 5 test scores into the arry 

            for(int i = 0; i < 5; i++)
            {
                number[i] = random.Next(0, 101);
            }
            //4. display the 5 test scores in the listbox
            foreach( int i in number)
            {
                listBox1.Items.Add(number[i].ToString());
            }
               highest = ihighest(number);
            lowest = iLowest(number);
            avgerge = iAvarage(number);
            //a methed to calculate the hihest number
            textBox1.Text = highest.ToString();
            textBox2.Text = lowest.ToString();
            textBox3.Text = average.ToString();
        }
        private double ihighest(int[] iArray)
        {
            //culculate the highest test score
            double highest = iArray[0];
            for (int i = 0; i < iArray.Length; i++)
            {
                if(iArray[i] > highest)
                {
                    highest = iArray[i];
                }
            }
            return highest ;
        }
        // a method to calculate the lowste() and i Average() metheds
        private double iLowest(int [] iArray)
        {
            double lowest = iArray[0];
            for(int i = 0; i < iArray.Length; i ++)
            {
                if (iArray[i] < lowest)
                {
                    lowest = iArray[i];
                }
                return lowest;
            }
            private double iAvarage (int [] iArray)
            {
                double Avarage = iArray[0];
                foreach (int i in iArray)
                {
                    total += i;

                }
                return total / iArray.Length;
            }
        }
    }
}
