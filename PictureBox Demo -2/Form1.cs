using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox_Demo__2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 3.1 showAce
        private void ShowAceofSpread()
        {
            Acecard.Visible = true;
            tencard.Visible = false;
            kingcard.Visible = false;
        }
        //3.2 Show

        private void ShowCard()
        {
            //2.1 declear
            string card; 
            switch (card)
            {
                case "Ace of Spandes":ShowAceofSpandes();
                case "10 of Hearts":Show10ofHearts();
              case "King of Clubs": 
                    

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // show card button
            // 1.if a card is selected in the listbox,display it 
            if (listBox1.SelectedIndex != -1)
            {
                //a method to show card 
                ShowCard();

            }
            else
            {
                MessageBox.Show("please select a card");

            }


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
