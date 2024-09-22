using System;

namespace Encapsulation.Banking
{
    public class BankAccount
    {
        private string _accountNumber;
        private string _accountHolder;
        private double _balance;

        public string AccountNumber
        {
            get { return _accountNumber; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _accountNumber = value;
                else
                    _accountNumber = "Unknown";
            }
        }

        public string AccountHolder
        {
            get { return _accountHolder; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _accountHolder = value;
                else
                    _accountHolder = "Unknown";
            }
        }

        public double Balance
        {
            get { return _balance; }
            set
            {
                if (value >= 0)
                    _balance = value;
            }
        }

        public BankAccount(string accountNumber, string accountHolder, double balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            if (balance >= 0)
                _balance = balance;
            else
                _balance = 0.0;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
                _balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && _balance >= amount)
                _balance -= amount;
        }

        public double GetBalance()
        {
            return _balance;
        }
    }
}