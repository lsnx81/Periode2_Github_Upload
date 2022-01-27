// See https://aka.ms/new-console-template for more information
using OefeningFiguren;

Console.WriteLine("Figuren");
var figuren = new List<Figuren>();
Console.WriteLine("Maak een lijst van figuren op opp te berekenen. Maximaal 5");

do
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Figuurnummer {figuren.Count + 1} van maximum 5");
    Console.ResetColor();
    Console.WriteLine("Druk op 3 voor een driehoek, op 4 voor een rechthoek of een andere toets om te rekenen");
    var userKeuze = Console.ReadLine();
    if (userKeuze == "3")
    {
        try
        {
            var driehoek = new Driehoek();
            Console.WriteLine("geef de hoogte in van uw driehoek. Gehele Getallen aub");
            driehoek.Hoogte = int.Parse(Console.ReadLine());
            Console.WriteLine("geef de breedte in van uw driehoek. Gehele Getallen aub");
            driehoek.Breedte = int.Parse(Console.ReadLine());

            figuren.Add(driehoek);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
            Console.ResetColor();
        }
    }
    else if (userKeuze == "4")
    {
        try
        {
            var rechthoek = new Rechthoek();
            Console.WriteLine("geef de lengte in van uw rechthoek. Gehele Getallen aub");
            rechthoek.Lengte = int.Parse(Console.ReadLine());
            Console.WriteLine("geef de breedte in van uw rechthoek. Gehele Getallen aub");
            rechthoek.Breedte = int.Parse(Console.ReadLine());


            figuren.Add(rechthoek);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
            Console.ResetColor();
            continue;
        }
    }
    else
    {
        break;
    }

} while (figuren.Count < 5);

Console.Clear();
for (int i = 0; i < figuren.Count; i++)
{

    Console.WriteLine($"{i + 1} : {figuren[i]}");
}