// See https://aka.ms/new-console-template for more information
using BankAbstract;

Console.WriteLine("Bienvenu dans notre banque");

Customer customer = new Customer("Paul", "Jean", new DateTime(1997, 9, 25), true);

CommonAccount comAcc = new CommonAccount(50, "234234", 400, DateTime.Now);
customer.AddAccount(comAcc);

SavingAccount savAcc = new SavingAccount(10, "525345", 200, DateTime.Now);
customer.AddAccount(savAcc);

comAcc.Withdraw(30);
comAcc.Transfer(50, savAcc);

savAcc.Interest(true);

foreach(Account acc in customer.LstAccount)
{
    Console.WriteLine(acc.ToString());
}


