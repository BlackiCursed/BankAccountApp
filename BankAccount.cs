using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    public class BankAccount
    {
        private int accountNumber;
        private string accountHolder;
        public string AccountHolder
        {
            get { return accountHolder; }
            set { accountHolder = value; }
        }            

        private double balance;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        private int depositMoney;
        public void DepositMoney(double amount)
        {
            if (depositMoney > 0)
            {
                balance += amount;
            }
        }
        private double withdrawMoney;
        public void WithdrawMoney(double amount)
        {
           if (amount <= 0)
            {  
                Console.WriteLine($"Amount must be greater than zero");   
                return; 
            }
            if (amount > balance)
            {
                Console.WriteLine("Insufficient Fund");
                return;
            }
            
        }

        

    }
}
