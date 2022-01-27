// See https://aka.ms/new-console-template for more information
using PizzaTime;

Console.WriteLine("Pizzatime");
var prijsLijst = new List<Pizza>();
Console.WriteLine("Geef 3 Pizza's in:");
while (prijsLijst.Count < 3)
{
    Console.WriteLine($"Geef Topping in voor Pizza {prijsLijst.Count + 1}:");
    var topping = Console.ReadLine();
    Console.WriteLine($"Geef de diameter tussen 10 en 30 in voor Pizza {prijsLijst.Count + 1}:");
    var diameter = int.Parse(Console.ReadLine());
    Console.WriteLine($"Geef de prijs in voor Pizza {prijsLijst.Count + 1}:");
    var prijs = double.Parse(Console.ReadLine());
    try
    {
        var pizza = new Pizza()
        {
            Toppings = topping,
            Diameter = diameter,
            Price = prijs

        };
        prijsLijst.Add(pizza);
    }
    catch (ArgumentException ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(ex.Message);
        Console.ResetColor();
    }
}
Console.Clear();
Console.WriteLine("Uw ingegeven prijslijst:");
foreach (var pizza in prijsLijst.OrderBy(o => o.Toppings).ThenBy(b => b.Diameter))
{
    Console.WriteLine(pizza);
}