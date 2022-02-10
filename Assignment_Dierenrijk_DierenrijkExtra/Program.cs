// See https://aka.ms/new-console-template for more information
using Assignment_Dierenrijk_DierenrijkExtra;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Assignment Dierenrijk");
Console.ResetColor();
var hagedis = new Reptile(24, "GroeneHagedis");
var olifant = new Mammal(isZwanger: false, naam: "Dumbo") { Decibel=125};
hagedis.ToonInfo();
olifant.ToonInfo();


List<Animal> animals = new List<Animal>
{
new Mammal(isZwanger:true, naam: "Afrikaanse Leeuw") {Decibel=99},
new Reptile(10, "Salamander"),
olifant,
hagedis,
};

foreach (var animal in animals)
{
   animal.ToonInfo();
}

Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("Assignment DierenrijkExtra");
Console.ResetColor();
foreach(var animal in animals)
{
    if(animal is IPraat talkingAninal)
    {
        Console.WriteLine($"Decibel: {talkingAninal.Decibel}");
       animal.ToonInfo(); 
    }
       
}