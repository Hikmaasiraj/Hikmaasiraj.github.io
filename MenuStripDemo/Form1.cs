using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStripDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. File > About menu ; show the messgebox
            MessageBox.Show("This is an example of using Menus. ", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //2. exit the program
            Application.Exit();


        }
        // 5. 
        private void ClearColor()
        {
            blackToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
        }
         private void ClearFont()
        {
            timesNewRomanToolStripMenuItem.Checked = false;
            comicSansToolStripMenuItem.Checked = false;
        }


        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ClearColor();
            //3. set the font to black
            label1.ForeColor = Color.Black;
            // Leave the black checkmark on
            blackToolStripMenuItem.Checked = true;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            label1.ForeColor = Color.Blue;
            blueToolStripMenuItem.Checked = true;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            label1.ForeColor = Color.Red;

            redToolStripMenuItem.Checked = true;
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //6. set font to Times Nw Roman
            ClearFont();

            label1.Font = new Font("Times New Roman", 14, label1.Font.Style);
            // leave the Times 
            timesNewRomanToolStripMenuItem.Checked = true;

        }

        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //6.1 
            ClearFont();
            label1.Font = new Font("Comic Sans MS", 14, label1.Font.Style);

            comicSansToolStripMenuItem.Checked = true;
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boldToolStripMenuItem.Checked = !boldToolStripMenuItem.Checked;
            //9.set the font yo bold.
            //keep all other styles and bitwise operater, to add the bold style
            label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)

        {
            italicToolStripMenuItem.Checked = !italicToolStripMenuItem.Checked;


            // 10 BOL
            //  boldToolStripMenuItem.Checked = (boldToolStripMenuItem.Checked ^ true);
            //9.set the font yo italict.
            //keep all other styles and bitwise operater, to add the italic style
            label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Italic);
        }
    }
}
