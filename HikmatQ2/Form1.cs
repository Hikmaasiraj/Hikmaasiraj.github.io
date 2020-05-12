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

namespace HikmatQ2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Displaystring();
            MaxLength(List<string> name);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> name = new List<string>();
            name.Add("We are learning");
            name.Add("C# programming");
            name.Add("on .NET Framework");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.length.Tostring();
            if (textBox1.Text.Length == 15)
            {
                label3.Text = name.Text.length.ToString();
            }
        }
    }
    private void Displaystring(List<string> name)
    {
        foreach (int i  in name)
        {
            listBox1.Items.Add(i);
        }


        private int GetLength(string name)
        {
            label3.Text = getlength;
        }
        return Length;

        private void MaxLength(List<string> nane)
        {
            int maxLength;

            for (int i = 0; i < name.Count; i++)
            {
                maxLength.Equals.maxLength;
            }
            return maxLength;
        }

    }
}





