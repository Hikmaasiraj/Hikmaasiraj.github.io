using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        // private int comp;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            int pc;
            int player;
            Random random = new Random();
            pc = random.Next(3) + 1;
            label1.Text = pc.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pc = 1;
            int player = 1;

            if ((player == 1 && pc == 1) || (player == 2 && pc == 2) || (player == 3 && pc == 3))
            {

                label1.Text = "The computer selected Rock. So its Tie";
            }
            if ((player == 1 && pc == 2) || (player == 2 && pc == 3) || (player == 3 && pc == 1))
            {

                label1.Text = "The computer selected Paper. So the Winner is you ";
            }
            if ((player == 1 && pc == 3) || (player == 2 && pc == 1) || (player == 3 && pc == 2))
            {

                label1.Text = "The computer selected Paper. So the Winner is you ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pc = 1;
            int player = 1;

            if ((player == 1 && pc == 1) || (player == 2 && pc == 2) || (player == 3 && pc == 3))
            {

                label1.Text = "The computer selected Rock. So its Tie";
            }
            if ((player == 1 && pc == 2) || (player == 2 && pc == 3) || (player == 3 && pc == 1))
            {

                label1.Text = "The computer selected Paper. So the Winner is you ";
            }
            if ((player == 1 && pc == 3) || (player == 2 && pc == 1) || (player == 3 && pc == 2))
            {

                label1.Text = "The computer selected Paper. So the Winner is you ";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = clear;
        }
    }
}

