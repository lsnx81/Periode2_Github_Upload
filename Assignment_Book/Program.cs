// See https://aka.ms/new-console-template for more information
using Assignment_Book;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Assignment Book DEEL 1");
Console.ResetColor();


var boekEen = new TextBook(isbn: 258852258, title: "Leesverhalen van over zee", author: "Magic Mike", price: 50);
var boekTwee = new CoffeeTableBook(isbn: 525589600, title: "land en leven", author: "Boris de Wortel", price: 100);


var omnibus = Book.TelOp(boekEen, boekTwee);
Console.WriteLine(omnibus.Title);
Console.WriteLine(omnibus.Price);


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Assignment Book DEEL 2");
Console.ResetColor();

Console.WriteLine(boekEen.ToString());


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Assignment Book DEEL 2  PRO");
Console.ResetColor();

var kopieBoekTweeAnderePrijs = new CoffeeTableBook(isbn: 525589600, title: "land en leven", author: "Boris de Wortel", price: 60);

bool sameBook = kopieBoekTweeAnderePrijs == boekTwee;
bool notSameBook= boekTwee == boekEen;

Console.WriteLine($"twee instanties van hetzelfde boek omdat de isbn hetzelfde is en de prijs anders: {sameBook}");
Console.WriteLine($"twee verschillende boeken: {notSameBook}");


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Assignment Book DEEL 3  PRO00000000000");
Console.ResetColor();

var boekDrie = new TextBook(isbn: 258850258, title: "Leesverhalen van over zee", author: "Magic Mike", price: 60);
var boekVier = new CoffeeTableBook(isbn: 525489600, title: "land en leven", author: "Boris de Wortel", price: 77);

var omni = boekDrie + boekVier;

Console.WriteLine($"Omnibus2 :{omni}");

