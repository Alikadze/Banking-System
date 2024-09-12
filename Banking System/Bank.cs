using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    class Bank
    {
        private List<Account> accounts = new List<Account>();  // List to store all accounts in the bank

        // Method to add a new account
        public void AddAccount(Account account)
        {
            accounts.Add(account);
            Console.WriteLine($"Account {account.AccountNumber} added for {account.OwnerName}");
        }

        // Method to display all accounts in the bank
        public void DisplayAllAccounts()
        {
            foreach (var account in accounts)
            {
                account.CheckBalance();  // Use the CheckBalance method of each account to print details
            }
        }

        // Method to transfer funds between accounts
        public void TransferFunds(int fromAccountNumber, int toAccountNumber, decimal amount)
        {
            var fromAccount = GetAccountByNumber(fromAccountNumber);
            var toAccount = GetAccountByNumber(toAccountNumber);

            if (fromAccount != null && toAccount != null)
            {
                if (fromAccount.Balance >= amount)
                {
                    fromAccount.Withdraw(amount);
                    toAccount.Deposit(amount);  
                    Console.WriteLine($"Transfer of {amount:C} from Account {fromAccountNumber} to Account {toAccountNumber} successful!");
                }
                else
                {
                    Console.WriteLine("Insufficient funds in the source account.");
                }
            }
            else
            {
                Console.WriteLine("One or both accounts not found.");
            }
        }

   
        private Account GetAccountByNumber(int accountNumber)
        {
            return accounts.Find(acc => acc.AccountNumber == accountNumber);
        }

    
        public decimal GetTotalBankFunds()
        {
            decimal total = 0;
            foreach (var account in accounts)
            {
                total += account.Balance; 
            }
            return total;
        }
    }
}
