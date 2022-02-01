using Assignent_Speelkaarten;

Console.WriteLine(PrintTitel());
IList<Speelkaart> fiftyTwoinForSuites = GenereerKaarten();

Random random = new Random();
while (fiftyTwoinForSuites.Count > 0)
{
   Speelkaart getrokkenKaart = TrekKaart(fiftyTwoinForSuites, random);
   fiftyTwoinForSuites.Remove(getrokkenKaart);
   Console.ReadKey();
   Console.Clear();
}

Console.WriteLine("bij de laatste had je zeker juist moeten hebben");

List<Speelkaart> GenereerKaarten()
{
    List<Speelkaart> speelkaarts = new();

    for (int suite = 0; suite < 4; suite++)
    {
        for (int getal = 1; getal < 14; getal++)
        {
            Speelkaart toAdd = new Speelkaart(getal, (Suite)suite);
            speelkaarts.Add(toAdd);
        }
    }

    return speelkaarts;
}

// A method with a return value performs an action and returns a result
Speelkaart TrekKaart(IList<Speelkaart> fiftyTwoinForSuites, Random random)
{
    Console.WriteLine(PrintTitel());
    Speelkaart getrokkenKaart = fiftyTwoinForSuites[random.Next(0, fiftyTwoinForSuites.Count)];
    Console.WriteLine($"Tadatadaaaaaaaaaaaaa = {getrokkenKaart.Suite}  {getrokkenKaart.Getal} Gewonnen?");

    return getrokkenKaart;
}

string PrintTitel()
{
    return "S_P_E_E_L_K_A_A_R_T_E_N";
}