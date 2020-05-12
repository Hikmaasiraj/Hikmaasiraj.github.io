using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converting_Temprature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double fahrenheit;
            int celsius;

            fahrenheit = double.Parse(textBox1.Text);
            celsius = Convert.ToInt32(fahrenheit - 32) * 5 / 9;

            label1.Text = fahrenheit + " Degree fahrenheit is " + celsius + " degree celsius";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
