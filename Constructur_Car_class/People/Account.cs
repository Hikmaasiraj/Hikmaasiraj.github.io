using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Constructur_Car_class.people
{
    public class Account
    {
        private string _ownerName;
        private string _bankName;
        private decimal _balance;
        private int _accountNumber;

        public Account(string ownerName, string bankName, decimal balance, int accountNumber)
        {
            _ownerName = ownerName;
            _bankName = bankName;
            _balance = balance;
            _accountNumber = accountNumber;
        }
        public string OwnerName
        {
            get
            {
                return _ownerName;
            }
        }
        public string BankName
        {
            get
            {
                return _bankName;
            }
            set
            {
                _bankName = value;
            }
        }
        public decimal Balance
        {
            get
            {
                return _balance;
            }
        }
        public int AccountNumber
        {
            get
            {
                return _accountNumber;
            }
        }
    }
}
//Excercise 
// Add construtor and properties to both classes. All fields should be private
// for Car class only the Price should have a set asccessor.
// for Account class only the BankName should have a set accessor.
// Redo the car class
// Add a class Account:_ownerName,bankName, balance(decimal),_accountNumbe(int),


