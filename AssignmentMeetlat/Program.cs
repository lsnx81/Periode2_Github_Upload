using AssignmentMeetlat;

Console.WriteLine("Meetlat");
int retries = 0;
double input = GetUserInput();
PrintAfmetingen(input);

// Methods that return a value are super effective to test
double GetUserInput()
{
    Console.WriteLine("Geef lengte in meter in aub");
    if (double.TryParse(Console.ReadLine(), out double userInput))
    {
        return userInput;
    }
    else
    {
        Console.WriteLine("Gelieve een geldig getal in te voeren");
        retries++;

        if (retries >= 3)
        {
            throw new Exception("Too many tries");
        }
        return GetUserInput();
    }
}

void PrintAfmetingen(double input)
{
    Meetlat meetlat = new(input);
    Console.WriteLine($"{meetlat.BeginLengte} meter is {meetlat.BeginLengte} in meter");
    Console.WriteLine($"{meetlat.BeginLengte} meter is {meetlat.LengteInCm} in centimeter");
    Console.WriteLine($"{meetlat.BeginLengte} meter is {meetlat.LengteInKm} in kilometer");
    Console.WriteLine($"{meetlat.BeginLengte} meter is {meetlat.LengteInVoet} in Voet, waarbij 1m=3.2808 Voet");
}