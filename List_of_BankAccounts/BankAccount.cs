using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_of_BankAccounts
{
    class BankAccount
    {
        //private fields
        private int _accountNumber;
        private decimal _balance;
        private string _bankName;
        private string _owner;

        //constructor
        public BankAccount(int accountNumber, decimal balance, string bankName, string owner)
        {
            _accountNumber = accountNumber;
            _balance = balance;
            _bankName = bankName;
            _owner = owner;
        }

        //properties
        public int AccountNumber { get { return _accountNumber; } }
        public decimal Balance { get { return _balance; } }
        public string BankName { get { return _bankName; } }
        public string Owner { get { return _owner; } }

        //methods
        public void Deposit(decimal amount)
        {
            if (amount <= 0) //throw an exception
                throw new Exception("Invalid negative amount");
            //add the amount to the _balance
            _balance += amount;
        }
        public bool Withdraw(decimal amount)
        {
            //subtract the amount from the balance, if there is enough funds
            //if there is enough funds
            //subtract amount from _balance
            //return true
            //otherwise/else
            //deny: (no action taken) return false

            //test for invalid data
            if (amount <= 0)
                throw new Exception("Invalid negative amount");

            if (_balance > amount)
            {
                _balance -= amount;
                return true;
            }
            else
            {
                //you could subtract a fee ($25)
                return false;
            }

        }
        public string GetAccountInfo()
        {
            string info = $" {_accountNumber}\t\t{_balance:c}\t\t{_bankName}\t{_owner}";
            return info;
        }
    }
}

    

