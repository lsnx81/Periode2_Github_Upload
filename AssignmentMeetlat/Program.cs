// See https://aka.ms/new-console-template for more information
using AssignmentMeetlat;

Console.WriteLine("Meetlat");



Console.WriteLine("Geef lengte in meter in aub");
var beginLengte = decimal.Parse(Console.ReadLine());

Meetlat meetlat = new(beginLengte);
Console.WriteLine($"{meetlat.BeginLengte} meter is {meetlat.LengteInM} in meter");
Console.WriteLine($"{meetlat.BeginLengte} meter is {meetlat.LengteInCm} in centimeter");
Console.WriteLine($"{meetlat.BeginLengte} meter is {meetlat.LengteInKm} in kilometer");
Console.WriteLine($"{meetlat.BeginLengte} meter is {meetlat.LengteInVoet} in Voet, waarbij 1m=3.2808 Voet");


