// See https://aka.ms/new-console-template for more information
using Assignment_Een_Eigen_Huis;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Assignment: Een Eigen Huis");
Console.ResetColor();

var huisModelWoning = new Huis();




huisModelWoning.Kamers.AddRange(new Kamer[] {
    new Slaapkamer("kinderkamer1", 14),
    new Slaapkamer("kinderkamer2", 14),
    new Slaapkamer("Masterbedroom", 24),
    new Zolder(99, 7),
    new Gang("gang", 16),
    new Salon("salon", 44, true)
    });

Console.WriteLine(huisModelWoning.ToString());