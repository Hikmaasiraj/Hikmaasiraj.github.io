using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listBoxPractice
{
    public partial class CARSALE : Form
    {
        public CARSALE()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "ACURA" || textBox1.Text != "CAMRY" || textBox1.Text != " TOYOTA" || textBox1.Text != "INFINITY")
            {
                COLLECTIONS.Items.Add(textBox1.Text);
            }
            else
            {
                MessageBox.Show("its alrady exsist");
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
        if (COLLECTIONS.SelectedIndex != -1)
            {
                COLLECTIONS.Items.RemoveAt(COLLECTIONS.SelectedIndex);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
          
            textBox1.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

             