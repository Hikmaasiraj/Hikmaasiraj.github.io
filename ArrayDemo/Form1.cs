using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1. use random class to generete to generete 5 random numbers
            Random random = new Random();
           
            //2. create an array to hold the 5 number
            int[] numbers = new int[5]; 
            //3. assign those number to the arry
            for (int i = 0;  i < 5; i++)
            {
                numbers[i] = random.Next(0, 101);
            }
            //4. display the array element in the labels(label 1,2,3,4,5)
            label1.Text = numbers[0].ToString();
            label2.Text = numbers[1].ToString();
                 label3.Text = numbers[2].ToString();
                 label4.Text = numbers[3].ToString();
                 label5.Text = numbers[4].ToString();
        }
    }
}
