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
namespace dupicateassignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 0;
        private void label3_Click(object sender, EventArgs e)
        {
            
            
            List<int> list1 = new List<int>() { 3, 7, 3, -1, 2, 3, 15, 0, 50 };
            List<int> list2 = new List<int>() { -5, 15, 2, -1, 7, 15, 36 };
           
            for (int i = 0; i < list1.Count; i++)
            {
                listbox1.Items.Add(list1[i]);
            }

            for (int i = 0; i < list2.Count; i++)
            {
                listbox2.Items.Add(list2[i]);
            }
            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    if (list1[i] == (list2[j]))
                    {
                        label5.Text = counter++.ToString();
                    }
                }
            }

        }
    }  
}

    

 