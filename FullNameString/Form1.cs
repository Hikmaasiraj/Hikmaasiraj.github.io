using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullNameString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showname_Click(object sender, EventArgs e)
        {
            String FristName = FirstTB.Text;
            String LastName = LastTB.Text;
            string fullname = FirstTB + "  " + LastTB;

            FullName.Text = fullname;

           
        }
        
    }
}
