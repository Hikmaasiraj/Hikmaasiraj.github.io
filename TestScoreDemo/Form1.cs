using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestScoreDemo
{
    public partial class Form1 : Form
    {
     

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // culculate avg button
            //set the variables

            double mathTs, historyTs, csTs;
            double avg;

            mathTs = double.Parse(textBox1.Text);
            historyTs = double.Parse(textBox2.Text);
            csTs = double.Parse(textBox3.Text);

           // calulate the average test score
            avg = (mathTs + historyTs + csTs);
            // display the avg  to outputLable 

            OutputLable.Text = avg.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clear the 3 textboxes and outputLabel
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            outputLabel.Text = ;




        }
    }
}
