using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    class Account
    {
        
        public int AccountNumber { get; private set; }
        public string OwnerName { get; private set; }
        public decimal Balance { get; set; }  

        
        public Account(int accountNumber, string ownerName, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            Balance = initialBalance;
        }

       
        public virtual void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount:C} to {OwnerName}'s account. New Balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }
        }

       
        public virtual void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount:C} from {OwnerName}'s account. New Balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds or invalid amount.");
            }
        }

      
        public void CheckBalance()
        {
            Console.WriteLine($"Account {AccountNumber}: {OwnerName}'s balance is {Balance:C}");
        }
    }
}
