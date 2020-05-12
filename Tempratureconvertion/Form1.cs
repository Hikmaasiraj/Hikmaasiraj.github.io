using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tempratureconvertion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convert_Click(object sender, EventArgs e)

        {
            try { 

            double fahrenheit = double.Parse(inputtb.Text);
            int celciuse = Convert.ToInt32(fahrenheit - 32) * 5 / 9;

            outputlabel.Text = fahrenheit + " gedree fahrenheit "  + celciuse +  " degree celciuse ";
        }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

    }
    }
}
