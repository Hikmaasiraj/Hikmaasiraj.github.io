using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopularNameDemo
{
    public partial class Form1 : Form
    {
        private int i;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<string> girlName = new List<string>() { "Emily", "Tasnim", "Yasmin", "Madison", "Olivia", "Hannah", "Ahlam" };
            List<string> boyName = new List<string>() { "Jacob", "Michael", "Chris", "Ethan", "Anhar", "Ashrafu" };

            //girl's name
            if (textBox1.Text != "")

            {

                //run through the loop to compare the user input with girlName. for() or foreach()
                for (int i = 0; i < girlName.Count; i++)
                {

                    //if the user input = one of the name in girlName 
                    if (textBox1.Text == (girlName[i]))
                    {
                        label3.Text = (textBox1.Text + "  is a popular name.");
                        {
                            break;

                        }

                    }      //if the user input is NOT one of the name in girlName 
                    else
                    {
                        label3.Text = (textBox1.Text + " is NOT a popular name.");
                    }
                }
                //boy's name

                //get a boy name from the user and compare the name with boyName

                if (textBox2.Text != "")
                {

                   // for (int i = 0; i < boyName.Count; i++)


                        if (textBox1.Text == (boyName[i]))
                        {

                        label3.Text = (textBox2.Text + "  is a popular name");
                                
                            }
                        }

                        //if the user input is NOT one of the name in girlName 
                        else
                        {
                            label3.Text = (textBox2.Text + " is NOT a popular name.");
                        }


                }

            }
        }
    }
//}


        
    





