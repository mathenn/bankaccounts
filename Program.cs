using System;

namespace MyBanker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var account = new BankAccount("Matt", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with ${account.Balance}.");
            Console.WriteLine("");

            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            account.MakeWithdrawal(50, DateTime.Now, "Xbox game");

            Console.WriteLine(account.getAccountHistory());

        }
    }
}