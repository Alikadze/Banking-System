using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    class SavingsAccount : Account
    {
        private int withdrawalLimit = 3; 
        private int withdrawalsMade = 0;
        private decimal interestRate; 

       
        public SavingsAccount(int accountNumber, string ownerName, decimal initialBalance, decimal interestRate)
            : base(accountNumber, ownerName, initialBalance)
        {
            this.interestRate = interestRate;
        }

       
        public override void Withdraw(decimal amount)
        {
            if (withdrawalsMade < withdrawalLimit)
            {
                base.Withdraw(amount); 
                withdrawalsMade++;
            }
            else
            {
                Console.WriteLine("Withdrawal limit reached for this account.");
            }
        }

  
        public void ApplyInterest()
        {
            decimal interest = Balance * interestRate;
            Deposit(interest);
            Console.WriteLine($"Interest applied: {interest:C}. New Balance: {Balance:C}");
        }
    }
}
