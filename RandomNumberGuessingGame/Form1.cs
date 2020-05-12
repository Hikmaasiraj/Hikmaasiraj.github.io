using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberGuessingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            //int gameNumber = rnd.Next(1, 50);
            //int number;
           // attempt = 0;

           // count = 10;

            {
                MessageBox.Show("\n\tGuess a number between 1 and 50: ");
                if (int.TryParse(Text, out number))
                {
                    MessageBox.Show("This only works with numbers!");
                }
                else
                {

                    if (number < gameNumber)
                    {

                        MessageBox.Show("\tThe number you entered " + number + " is too small, try again.");
                    }

                    else if (number > gameNumber)
                    {
                        MessageBox.Show("\tThe number you entered " + number + " is too big, try again.");
                    }

                    else if (number == gameNumber)
                    {
                        MessageBox.Show("Congratulation " + number + " is the correct Number!");


                       // attempt++;

                        label2.Text = "Guess Attempt: " + number;

                    }


                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //label2.Text = gameNumger.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int gameNumber = rnd.Next(1, 50);
            int number;

        }
    }
}
