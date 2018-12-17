using System;

namespace Project 
{
    public enum AccountType { Checking, Deposit }

    public struct BankAccount 
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType; 
    }

    public class Test
    {
        public static void Main()
        {   
            // Bank Account

            AccountType goldAccount = AccountType.Checking; 
            AccountType platinumAccount = AccountType.Deposit;
            Console.WriteLine(goldAccount);
            Console.WriteLine(platinumAccount);

            //Struct Type

            BankAccount goldAccount2;
            goldAccount2.accNo = 10;
            goldAccount2.accBal = 10.1M;
            goldAccount2.accType = AccountType.Checking;
            Console.WriteLine(goldAccount2.accNo);
            Console.WriteLine(goldAccount2.accBal);
            Console.WriteLine(goldAccount2.accType);
        }
    }
}