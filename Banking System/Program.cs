using System;

namespace Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savings = new(1001, "John Doe", 1000m, 0.05m);
            Console.WriteLine("Savings Account Created:");
            savings.CheckBalance();

            
            savings.Deposit(500m);  
            savings.Withdraw(200m);  
            savings.Withdraw(300m);  
            savings.Withdraw(100m); 

           
            savings.ApplyInterest(); 

           
            savings.CheckBalance();

            Console.WriteLine("----------------------------------");

            CheckingAccount checking = new(1002, "Jane Smith", 2000m, 10m); 
            Console.WriteLine("Checking Account Created:");
            checking.CheckBalance(); 

            checking.Deposit(1000m);
            checking.Withdraw(500m);
            checking.Withdraw(1500m);

            
            checking.CheckBalance();
        }
    }
}