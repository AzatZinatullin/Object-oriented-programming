
using System;

class CreateAccount
{
    static void Main() 
    {
        BankAccount berts = NewBankAccount();
        TestDeposit(berts);
        Write(berts);
        
        BankAccount freds = NewBankAccount();
        TestDeposit(freds);
        Write(freds);
    }
    
    public static void TestDeposit(BankAccount acc)
    {
        Console.Write("Enter emount to deposit: ");
        decimal amount = int.Parse(Console.ReadLine());
        acc.Deposit(amount);
    }

    static BankAccount NewBankAccount()
    {       
        BankAccount created = new BankAccount();

        // Console.Write("Enter the account number   : ");
        // long number = long.Parse(Console.ReadLine());        

        // long number = BankAccount.NextNumber();
        Console.Write("Enter the account balance: ");
        decimal balance = decimal.Parse(Console.ReadLine());
        
        created.Populate(balance);

        // created.accNo = number;
        // created.accBal = balance;
        // created.accType = AccountType.Checking;
        
        return created;
    }
    
    static void Write(BankAccount toWrite)
    {
        Console.WriteLine("Account number is {0}",  toWrite.Number());
        Console.WriteLine("Account balance is {0}", toWrite.Balance());
        Console.WriteLine("Account type is {0}", toWrite.Type());
    }
}
