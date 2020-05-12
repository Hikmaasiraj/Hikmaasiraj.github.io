using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Hikmat Yusuf
namespace BoolenMethedDemo
{
    public partial class Form1 : Form
    {
        // 0. constant variable
        private const decimal contribution_rate = 0.05m;
        public Form1()
        {
            InitializeComponent();
        }
        // 2. a boolean method converts the user pnput and strs it 
        private bool InputIsValid()
        {
            // 2.1 flag variable to indicate whether the onput is valid or not

            bool validonput = false;
            
            //2.2
            if (decimal.TryParse(textBox1.Text, out grosspay)) {
                if (decimal.TryParse(textBox2.Text, out bonuspay))
            }
        }
                else
                {
                    MessageBox.Show("The bonus pay textbox contains invalide data");
                }
}
            else
            {
                MessageBox.Show("The gross pay textbox contains invalide data");
            }
                
            

            return;


            private void button1_Click(object sender, EventArgs e)
        {
            // user input the total pay and bonus pay
            // the contribution will be paid by employer 5% of sum (input + bonuse)
            // 1. change the varuable type
            decimal grosspay, bonuspay, sum; contribution= 0m;

            //user the Trytpass() method to handle the exception we predict
            if (int.TryParse(textBox1.Text, out grosspay)){
                // bonus pay textbox
                if (int.TryParse(textBox2.Text, out bonuspay))
                {
                    sum = grosspay + bonuspay;

                    label4.Text = sum.ToString();
                }
                

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

