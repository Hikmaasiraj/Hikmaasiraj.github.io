using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_Button__Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //BACK TO NORMAL
            this.BackColor = Color.White;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        { 
            // BLUE
            if (radioButton1.Checked)
            {
                // change the background color to Blue
                this.BackColor = Color.Blue;
            }



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //RED
            if (radioButton2.Checked)
            {
                // change the backgroud color to red
                this.BackColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
