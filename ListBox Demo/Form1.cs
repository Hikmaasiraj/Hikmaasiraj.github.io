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
namespace ListBox_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // show button
            // a variable to hold the city name 
            string city;
            if (listBox1.SelectedIndex == -1)
            {
                // handel the exception
                // A value of negative one (-1) is returned if no item is selected.
                MessageBox.Show("Please select  a city!"); 
            }

            // get the selected item
            city = listBox1.SelectedItem.ToString();
            // determine the time zone 
            // method1:4 if statment
            // methed2: swich- case statement
            switch (city)
            {
                case "Seattle": Outputlebel.Text = "Pacific" ; break;
                case "Denver": Outputlebel.Text = "Moutain"; break;
                case "Huston": Outputlebel.Text = "Central"; break;
                case "New york":Outputlebel.Text = "Eastern"; break;

               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
