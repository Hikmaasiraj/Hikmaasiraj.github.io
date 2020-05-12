using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_of_BankAccounts
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        // create a List of BankAccounts
        List<BankAccount> bankAccountList = new List<BankAccount>();
        
        string[] bankNames = { "Chase", "Bank of America", "Citigroup", "Wells Fargo", "Capitale One" };
        string[] owners = { "James", "Cynthia", "Roberts", "David", "Karen" };
        public Form1()
        {
            InitializeComponent();
            PreloudBankAccount();
            Display(bankAccountList);
        }
        // preloaud the bankAccountList with few accounts when this application runs
        private void PreloudBankAccount()
        {
            for (int i = 1;i <= 20; i++) { 
            string bankName = bankNames[rand.Next(bankNames.Length)];
            string owner = owners[rand.Next(owners.Length)];
            int accountNumber = rand.Next(1234567, 9999999);
            decimal balance = rand.Next(500, 25000);
            // create a Bankccount object
            BankAccount account = new BankAccount(accountNumber, balance, bankName, owner);
            // add it to the list 
            bankAccountList.Add(account);
            }

        }
        private void Display(List<BankAccount> list)
        {
            listBox1.Items.Clear();  // Empty the listbox
            foreach(BankAccount account in list)
            {
                string data = account.GetAccountInfo();
                listBox1.Items.Add(data);

               
            }
        }
    }
}
