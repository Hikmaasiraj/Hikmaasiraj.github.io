using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labassignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double Flushcharges()
        {
            double flush = 0;
            double trnflus = 0;
            double total = 0;

            if (checkBox4.CheckState == CheckState.Checked)
            {
                flush = 30;

            }
            if (checkBox3.CheckState == CheckState.Checked)
            {
                trnflus = 80;
            }
            total = flush + trnflus;
            
            return total;



        }
        public double OtherCharges()
        {
           
            
                double parts, labor;
                parts = Convert.ToDouble(textBox1.Text);
                labor = Convert.ToDouble(textBox2.Text);
           
            return labor+parts ;
        }
        public double TotalCharges()
        {
            double total;

            total = Flushcharges() + OtherCharges();
                return total;
        }
        private void ClearFlushes()
        {
            checkBox4.Checked = false;
            checkBox3.Checked = false;
        }
        private void ClearOther()
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FlushGB_Enter(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double a;
            //a = Flushcharges();
            //labelSandL.Text = a.ToString();
            //double b;
            //// b = TotalCharges();
            ////labelTotal.Text = b.ToString("c1");
            {
                double labelTax = 0.65;
                double labeltax = Convert.ToDouble(labelParts = labelTotal);
                labelParts = labelTotal;
            }


        }
        private void TaxCharges()
            
        {
            //double labelTax = 0.65;
            double labeltax = Convert.ToDouble(labelParts = labelTotal);
            labelParts = labelTotal;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ClearFlushes();
            ClearOther();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
