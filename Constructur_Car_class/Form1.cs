using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructur_Car_class.people
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateCar_Click(object sender, EventArgs e)
        {
            Car c1 = new Car("Toyota", "Camry", 2011, 104.00, 18.000);
            Car c2 = new Car("Acura", "MDX", 2014, 125.000, 14.000);
            Display(c1);
            Display(c2);
           


        }

        private void Display(Car c)
        {
            listBox1.Items.Add($" {c.Make} {c.Model} {c.Year}  {c.Mileage} {c.Price}" );
            c.Price = 20.00;
            
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            Account bank = new Account("Mike", "bank of America", 800, 1550000);
            Display(bank);


        }
        private void Display(Account bank)
        {
            listBox1.Items.Add($" {bank.OwnerName} {bank.BankName} {bank.Balance} {bank.AccountNumber}");
        }
    }
}
