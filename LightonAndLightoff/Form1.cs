using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Hikmat Yusuf
namespace LightonAndLightoff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            yellowon.Visible = true;
            grayoff.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (yellowon.Visible == true)
            {
                yellowon.Visible = false;
                grayoff.Visible = true ;
                label1.Text = "off";
            }
            else if(grayoff.Visible == true)
            {
                grayoff.Visible = false;
                yellowon.Visible = true;
                label1.Text = "on";

            }
           


        
        

        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
