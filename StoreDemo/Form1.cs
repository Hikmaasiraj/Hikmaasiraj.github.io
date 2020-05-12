using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1. create a random object
            Random random = new Random();
            //2.create a list to store  the random numbers between 10 - 20
            List<int> newList = new List<int>();
            // * of number < 10

            int no1 = random.Next();

            //3. store the random number in 
            for (int i = 0; i < no1; i ++)
            {
                int newList = random.Next(10, 20);
               
            //4. display the original number in the listbox1
            foreach (int i in newList)
            {
                listBox1.Items.Add(i);
            }

        }
       
    }
}
