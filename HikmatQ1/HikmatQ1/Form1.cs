using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HikmatQ1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputListB.Text = clear();
            Random random = new Random();
            int average, lessthenavarage;

            int[] number = new int[11];

            for(int i = 0; i < 11 ; i++)
            {
                number[i] = random.Next(150, 200);
            }
            foreach(int i in number)
            {
                outputListB.Items.Add(i);
            }
            average = Average(number);
            lessthanaverage = iLessthanaverage(number);
        }
        label2.Text = average.Tostring();


    private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    private int Average(int[] Array)
    {
        int total = 0;
        for (int i  =0; i < Array.Length; i ++)
        {
            total = total + Array[i];
        }
        return total / Array.Length;
    }

    private int lessthanavarage(int[] Array)
    {
        
        for (int i = 0; i < Array.Length; i++)
        {
          if(Array[i] < average)
            {
                return lessthanaverage;
            }
      
    }
        
    }
}
