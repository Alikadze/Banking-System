using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    class CheckingAccount : Account
    {
        private decimal transactionFee;

        
        public CheckingAccount(int accountNumber, string ownerName, decimal initialBalance, decimal transactionFee)
            : base(accountNumber, ownerName, initialBalance)
        {
            this.transactionFee = transactionFee;
        }


        public override void Withdraw(decimal amount)
        {
            decimal totalAmount = amount + transactionFee;
            if (totalAmount <= Balance)
            {
                base.Withdraw(totalAmount); 
                Console.WriteLine($"Transaction fee of {transactionFee:C} applied. New Balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds for this withdrawal and fee.");
            }
        }
    }
}
