
using System;

class BankAccount 
{
    private long accNo;
    private decimal accBal;
    private AccountType accType;
    private static long nextAccNo;

    public void GetAccount()
    {
        Console.WriteLine("Type of account: " + accType);
        Console.WriteLine("Number: " + accNo);
        Console.WriteLine("Balance: " + accBal);
    }

    public void TransferFrom(BankAccount accFrom, decimal amount)
    {
        if(Withdraw(amount))
        {
            accFrom.Deposit(amount); 
        }
    }

    public bool Withdraw(decimal amount)
    {
        if((accBal -= amount) > 0)
            return true;
        else return false;
    }

    public decimal Deposit(decimal amount)
    {
        return accBal += amount;
    }

    private static long NextNumber()
    {   
        return nextAccNo++;
    }

    public void Populate(decimal balance)
    {
        accNo = NextNumber();
        accBal = balance;
        accType = AccountType.Checking;
    }

    public long Number()
    {
        return accNo;
    }
    public decimal Balance()
    {
        return accBal;
    }
    public AccountType Type()
    {
        return accType;
    }
}

