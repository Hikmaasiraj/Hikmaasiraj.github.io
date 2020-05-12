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
namespace ListBox_Demo_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //add new item to the ListBox and clear inputTextBox
           // string animal_name; 
            if(inputTextBox.Text != "Dog" || inputTextBox.Text != "Cat" || inputTextBox.Text != "Tiger")
            {
                animalListBox.Items.Add(inputTextBox.Text);

            }
            else
            {
                MessageBox.Show("it is already in  the list box!");
            }
            //inputTextBox.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (animalListBox.SelectedIndex != -1)
            {
                //remove item if one is selected

                //First, check whether an item is selected or not, i.e. if it's selected
                animalListBox.Items.RemoveAt(animalListBox.SelectedIndex);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            //clear the textbox
            inputTextBox.Clear();
            ///animalListBox.Items.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
