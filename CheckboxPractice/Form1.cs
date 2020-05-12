using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckboxPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String find = " ";

            if(checkBox1.CheckState == CheckState.Checked)
            {
                find += "F";
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
            
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
               // Find += "I";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.CheckState == CheckState.Checked)
            {
                //Find += "n";
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.CheckState == CheckState.Checked)
            {
               // string Find = null;
                //Find += "d";
            }
        }
    }
}
