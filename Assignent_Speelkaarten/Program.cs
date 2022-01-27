// See https://aka.ms/new-console-template for more information
using Assignent_Speelkaarten;

Console.WriteLine("S_P_E_E_L_K_A_A_R_T_E_N");
Console.WriteLine("S_P_E_E_L_K_A_A_R_T_E_N");


List<Speelkaart> fiftyTwoinForSuites = new List<Speelkaart>();
for (int i = 0; i < 4; i++)
{
    for (int j = 1; j < 14; j++)
    {
        Speelkaart toAdd = new Speelkaart() { Getal = j, Suite = (Suite)i };
        fiftyTwoinForSuites.Add(toAdd);
    }
}
Random r = new Random();
while (fiftyTwoinForSuites.Count > 0)
{
    Console.WriteLine("S_P_E_E_L_K_A_A_R_T_E_N");
    Speelkaart nextInLine = fiftyTwoinForSuites[r.Next(0, fiftyTwoinForSuites.Count)];
    Console.WriteLine($"Tadatadaaaaaaaaaaaaa = {nextInLine.Suite}  {nextInLine.Getal} Gewonnen?");
    
    fiftyTwoinForSuites.Remove(nextInLine);
    Console.ReadKey();
    Console.Clear();
}
Console.WriteLine("bij de laatste had je zeker juist moeten hebben");

