// See https://aka.ms/new-console-template for more information
using Assignment_BankManager;

Console.WriteLine("BankManager");
var accountmanager= new AccountManager();
Console.WriteLine("Geef de naam in van de bankrekening ");
string naam = Console.ReadLine();
var walterAccount= accountmanager.CreateAccountFor(accountHolder:naam,initialDeposit: 1000);
Console.WriteLine(walterAccount);