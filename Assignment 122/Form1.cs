using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_122
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TBOriginalPrice.Text = (((double.Parse(TBDiscoutPrice.Text)) * (TBSalesPrice.B(TBSalesPrice.Text)) / 100)).ToString("F2");


            double Original, Discount, Sales;
            Original = double.Parse(TBOriginalPrice.Text);
            Discount = double.Parse(TBDiscoutPrice.Text);
            Sales = Original * Discount;
            double discout = double.Parse(TBDiscoutPrice.Text);
            TBSalesPrice.Text = Convert.ToString(Original - ((Original * Discount) / 100));

                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
