using BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public abstract class BankAccountDetails
    {
        public string? AccountNumber { get; set; }
        public decimal Balance { get; protected set; }

        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);
    }
}

class SavingsAccount : BankAccountDetails
{
    public decimal InterestRate { get; set; }

    public override void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited Amount: {amount:C}. New balance: {Balance:C}");
    }

    public override void Withdraw(decimal amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn Amount: {amount:C}. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient Balance.");
        }
    }
}

class CheckingAccount : BankAccountDetails
{
    public decimal OverdraftLimit { get; set; }

    public override void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited Amount: {amount:C}. New balance: {Balance:C}");
    }

    public override void Withdraw(decimal amount)
    {
        if (amount <= Balance + OverdraftLimit)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn Amount: {amount:C}. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient balance.");
        }
    }
    
}
