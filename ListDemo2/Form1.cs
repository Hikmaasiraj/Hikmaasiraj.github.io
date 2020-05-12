using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListDemo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //1. create a list to hold the 5 test scores, between 0-100
            List<int> scoreList = new List<int> { 99, 100, 78, 56, 98 };

            //2. display the test scores in the listbox
            foreach (int i in scoreList)
            {
                listBox1.Items.Add(i);
            }

            //3. call the Average() method
            iAverage(scoreList);

            //4. display the average value to the label2
            label2.Text = iAverage(scoreList).ToString();



        }
        private double iAverage(List<int> iList)
        {
            double avg, total=0;
            for (int i = 0; i < iList.Count; i ++)
            {
                total += iList[i];
            }


            return total/iList.Count;

        }
        //5. difinition of aboveAvg()

        private int aboveAvg(List<int> iList)
        {
            //5. call the aboveAvg() method to get the # above the average
            aboveAvg(scoreList);

            //6. call the belowAvg() method to get the # below the average
            belowAvg(scoreList);

            //7. display #5 and #6 into the label4 and label6
            label4.Text = aboveAvg(scoreList).ToString();
            label6.Text = belowAvg(scoreList).ToString();

        }
        //6.  difinition of belowAverage
        private int belowAvg(List<int> iList)
        {
            int count = 0;

            //call the iAverage() method to get the avg
            double avg1 = iAverage(iList);

            for (int i = 0; i < iList.Count; i++)
            {
                if (iList[i] < avg1)
                {
                    count++;
                }
            }
            return count;

        }
    }
}
