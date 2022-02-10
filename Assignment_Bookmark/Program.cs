// See https://aka.ms/new-console-template for more information
using Assignment_Bookmark;

Console.WriteLine("BOOKMARK MANANGER");

var manager = new BookMarkManager();
manager.LijstVullenMetFavorieten();
Console.WriteLine($"Dank u. U heb 5 websites ingegeven.");

while (true)
{
    manager.HuidigeBookMarks();
    Console.WriteLine($"Welke bookmark (1 - 2 - 3 - 4 - 5 ) wilt u bewerken ?");
    if (int.TryParse(Console.ReadLine(), out var bookMarkNummer)== false || bookMarkNummer<1 || bookMarkNummer>5)
    {
        Console.ForegroundColor= ConsoleColor.Red;
        Console.Beep();
        Console.WriteLine("Nummer moet tussen 1 en 5 zijn.");
        Console.ResetColor();
        continue;
    }

    Console.WriteLine($"Druk op 1 om een website te starten of druk op 2 om website te verwijderen en 3 om te wijzigen 9 om het programma te beeindigen");
    var keuze = Console.ReadLine();
    switch (keuze)
    {
        case "1":
            manager.StartBookMarkNummer(bookMarkNummer);
            break;

        case "2":
            manager.RemoveBookMark(bookMarkNummer);
            manager.LijstVullenMetFavorieten();
            break;


        case "3":
            manager.AdjustBookMark(bookMarkNummer);
            break;

        case "9":
            Environment.Exit(0);
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Beep();
            Console.WriteLine($"Dit is geen geldige keuze."); 
            Console.ResetColor();
            break;
    }


}





























//List<BookMark> LijstMetFavorieten = LijstVullenMetFavorieten();
//Console.Clear();
////GaNaarBasisTabel(NaamWebsites);





//BookMark bookMark = new BookMark();
//bookMark.URL = "https://www.sporza.be";


//bookMark.LinkNaarDeWebsite();