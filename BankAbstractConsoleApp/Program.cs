// See https://aka.ms/new-console-template for more information
using BankAbstract;

Console.WriteLine("Bienvenu dans notre banque");

Customer customer = new Customer("Paul", "Jean", new DateTime(1997, 9, 25), true);

CommonAccount comAcc = new CommonAccount(50, "234234", 0, DateTime.Now);
SavingAccount savAcc = new SavingAccount(10, "525345", 0, DateTime.Now);

customer.AddAccount(comAcc);
customer.AddAccount(savAcc);

comAcc.Deposit(200);

savAcc.Deposit(500);

foreach(Account acc in customer.LstAccount)
{
    Console.WriteLine(acc.ToString());
}
