using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int number;
        int gameNumber;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int gameNumber = rnd.Next(50) +1;
            int number;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gameNamber = Convert.ToInt32(tbnumber.Text);

           // MessageBox.Show("Guess a number between 1 and 50: ");
          

                if (int32.TryParse.number < gameNumber)
                {

                label2.Text = ("The number you entered " + number + " too Low");
                }

                else if (number > gameNumber)
                {
                    label2.Text =("tThe number you entered " + number + " is too big, try again.");
                }

                else if (number == gameNumber)
                {
                    label2.Text =("Congratulation " + number + " is the correct Number!");

                label2.Text = "Guess Attempt: " + number++;

            }



        }
                }
            }
        
                
            

