using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructer_properties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dog d1 = new Dog("name", "husky", "grey", 5, 80);
            Dog d2 = new Dog("fluffy", "pooldel", "white", 7, 90);
            Display(d1);
            Display(d2);

        }

        //method that takes a Dog object and displays it
        private void Display(Dog d)
        {
            listBox1.Items.Add($"{d.Name} {d.Breed} {d.Color} {d.Age} years old  {d.Weight} lbs ");
            d.Age = 22;
        }
    }
}

