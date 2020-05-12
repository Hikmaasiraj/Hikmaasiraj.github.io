using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        // Combine button          
        {
            String love = "";
            if (checkBox1.CheckState == CheckState.Checked)
            {
                love += "L";
               // love = love + "L";
            }


            if (checkBox2.CheckState == CheckState.Checked)
            {
                love += "O";
            }

            if (checkBox3.CheckState == CheckState.Checked)
            {
                love += "V";
            }


            if (checkBox3.CheckState == CheckState.Checked)
            {
                love += "E";

            }
             MessageBox.Show(love);
        }
    }
}