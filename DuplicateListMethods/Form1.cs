using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplicateListMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       // newList.contains();

        private void label3_Click(object sender, EventArgs e)
        {
            List<int> newList = new List<int>();

            List<int> list1 = new List<int>() { 3, 7, 3, -1, 2, 3, 15, 0, 50 };
            List<int> list2 = new List<int>() { -5, 15, 2, -1, 7, 15, 36 };
            foreach(int newlist in newList)
            {
                newList.Add(newlist);
                newList.Add(newlist);

            }


        }
    }
    //newList.Contains();
}
