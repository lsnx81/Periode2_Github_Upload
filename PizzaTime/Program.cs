// See https://aka.ms/new-console-template for more information
using PizzaTime;

Console.WriteLine("Pizzatime");
var prijsLijst = new List<Pizza>();
prijsLijst = CreatePizzas();

PrintPrijsLijst(prijsLijst);

List<Pizza> CreatePizzas(int amountOfPizzas = 3)
{
    Console.WriteLine($"Geef {amountOfPizzas} Pizza's in:");
    while (prijsLijst.Count < amountOfPizzas)
    {
        Pizza pizza = CreatePizza(prijsLijst.Count + 1);
        prijsLijst.Add(pizza);
    }

    return prijsLijst;
}

Pizza CreatePizza(int pizzaNumber)
{
    Console.WriteLine($"Geef Topping in voor Pizza {pizzaNumber}:");
    var topping = Console.ReadLine();

    Console.WriteLine($"Geef de diameter tussen 10 en 30 in voor Pizza {pizzaNumber}:");
    var diameter = int.Parse(Console.ReadLine());

    Console.WriteLine($"Geef de prijs in voor Pizza {pizzaNumber}:");
    var prijs = double.Parse(Console.ReadLine());

    try
    {
        var pizza = new Pizza(toppings: topping, price: prijs, diameter: diameter);
        return pizza;
    }
    catch (ArgumentException ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(ex.Message);
        Console.ResetColor();

        return CreatePizza(pizzaNumber);
    }
    catch (Exception ex)
    {
        // Log error & rethrow exception
        throw;
    }
}

// If a method needs data (prijslijst) -> Ask for said data. Do NOT retrieve it yourself.
void PrintPrijsLijst(IList<Pizza> prijsLijst)
{
    Console.WriteLine("Uw ingegeven prijslijst:");
    foreach (var pizza in prijsLijst
                 .OrderBy(o => o.Toppings)
                 .ThenBy(b => b.Diameter))
    {
        Console.WriteLine(pizza.ToString());
    }
}