using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz2
{
    public partial class Form1 : Form
    {
        List<string> name = new List<string>() { "CSI 122", "Programming-II class", "is Fun!" };
        public Form1()
        {
            InitializeComponent();
           DisplayString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> name = new List<string>() { "CSI 122", "Programming-II class", "is Fun!" };

            label4.Text = label2.Text.Length.ToString(); 

       //  private int  getLength()
            {

            }
            

        }
    }
    private void DisplayString()
    {
        for (int i = 0; i < name.Count; i++)
        {
            label2.Items.Add(name[i]);
        }

    }
    //private void charCounter()
    //{
    //    string[] allcharCounter = charCounter();
    //    return allcharCounter.Length;
    //}

}

      


                
            