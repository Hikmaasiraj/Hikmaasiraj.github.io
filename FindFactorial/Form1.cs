using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindFactorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Factorial(int number)
        {
         
            int result = 1;
            for(int i = 1; i <= number; i = i + 1)
            {
                result = result * i;
            }  
                return result;    
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int fact, result;
            int number;
          
            if (!int.TryParse(textBox1.Text, out number ))
              
                {
               
                MessageBox.Show("The input should be a number!");
            }
            else
            {
                
               if (number <= -1)
                    {
                        MessageBox.Show("The input should be a possive number!");
                    }
                    else
                    {
                        fact = int.Parse(textBox1.Text);
                        result = Factorial(fact);
                        Answer.Text = result.ToString();
                        Answer.Text = ( +fact+ "!" + " = " +result);
                   
                    }
                    }
                }
            }
        }
    

