// See https://aka.ms/new-console-template for more information
using Assignment_BankManager;


Console.WriteLine("BankManager");
AccountManager accountManager = new AccountManager();

while (true)
{
    Console.Clear();
    Console.WriteLine("Welkom bij GratisRekeningBANK");
    Console.WriteLine("u heeft volgende opties:");
    Console.WriteLine("1 overzicht rekeningen");
    Console.WriteLine("2 nieuwe rekening maken");
    Console.WriteLine("3 geld overboeken naar andere rekening");
    Console.WriteLine("4 geld afhalen");
    Console.WriteLine("5 geld storten");
    Console.WriteLine("6 rekening 'blokkeren' of 'deblokkeren'");
    Console.WriteLine("9 Einde van de Werkdag. Verlaat het Programma");
    var keuzeBankMedewerker = Console.ReadLine();
    switch (keuzeBankMedewerker)
    {
        case "1":
            Console.WriteLine("Dit zijn de huidige rekeningen");
            foreach (var rekeningnummer in accountManager.Accounts())
            {
                Console.WriteLine(rekeningnummer);
            }
            Console.WriteLine("Press Any Key to continue");
            Console.ReadKey();
            break;
        case "2":
            Console.WriteLine("Maakt een nieuwe rekening.  Geef de naam van de rekeninghouder in:");
            var nieuweRekening = Console.ReadLine();
            Console.WriteLine("Het geld te storten om de rekening te openen:");
            if (decimal.TryParse(Console.ReadLine(), out var openingsStorting))
            {
                accountManager.CreateAccountFor(nieuweRekening, openingsStorting);
            }
            break;
        case "3":
            var vanRekening = SelectAccount("Van welke rekening ga je geld afboeken");
            var naarRekening = SelectAccount("Naar welke rekening ga je geld overboeken");
            Console.WriteLine($"Hoeveel wil je overboeken? Het beschikbare bedrag is {vanRekening.GetBalance()}");
            if (decimal.TryParse(Console.ReadLine(), out var overBoeking))
            {
                if (accountManager.TryWithDrawFunds(vanRekening.RekeningNummer, overBoeking, out var effectiefGeboekt))
                {
                    accountManager.TryDeposit(naarRekening, effectiefGeboekt);
                }
                else
                {
                    accountManager.TryDeposit(vanRekening, effectiefGeboekt);
                }
                Console.WriteLine($"{vanRekening}");
                Console.WriteLine($"{naarRekening}");

            }
            else
            {
                Console.WriteLine("Geen Gelden overgeboekt");
            }
            Console.WriteLine("Press Any Key to continue");
            Console.ReadKey();
            break;
        case "4":
            var rekeningCashAfhaling = SelectAccount("Van welke rekening ga je geld afboeken");
            Console.WriteLine($"Hoeveel wil je afhalen van je rekening? Het beschikbare bedrag is {rekeningCashAfhaling.GetBalance()}");
            if (decimal.TryParse(Console.ReadLine(), out var afBoeking) && accountManager.TryWithDrawFunds(rekeningCashAfhaling.RekeningNummer, afBoeking, out var effectiefCashAfboeking))
            {
                Console.WriteLine($"Effectieve Cashafhaling {effectiefCashAfboeking}");
            }
            else
            {
                Console.WriteLine("Geen Geld afgeboekt");
            }
            Console.WriteLine($"Nieuwe Rekeningstand bedraagt {rekeningCashAfhaling.GetBalance()}");
            Console.WriteLine("Press Any Key to continue");
            Console.ReadKey();

            break;
        case "5":
            var rekeningCashStorting = SelectAccount("welke rekening ontvangt gelden?");
            Console.WriteLine($"Hoeveel wordt op de rekening gestort?");
            if (decimal.TryParse(Console.ReadLine(), out var teOntvangenGeldenOpRekening) && accountManager.TryDeposit(rekeningCashStorting, teOntvangenGeldenOpRekening))
            {
                Console.WriteLine($"uw nieuw saldo bedraagt: {rekeningCashStorting.GetBalance()}");
            }
            else
            {
                Console.WriteLine("Geen Geld bijgeboekt");
            }
            Console.WriteLine("Press Any Key to continue");
            Console.ReadKey();
            break;
        case "6":
            var rekeningChangeState = SelectAccount("welke rekening wordt geblokkeerd of gedeblokkeerd?");
            Console.WriteLine($"Welke status moet de rekening krijgen hij heeft nu {rekeningChangeState.Status}");
            foreach (var state in Enum.GetValues<AccountStatus>())
            {
                Console.WriteLine($"{(int)state}: {state.ToString()}");
            }
            if (int.TryParse(Console.ReadLine(), out var statusNummer) && Enum.IsDefined(typeof(AccountStatus), statusNummer))
            {
                accountManager.ChangeState(rekeningChangeState.RekeningNummer, (AccountStatus)statusNummer);
            }
            Console.WriteLine(rekeningChangeState);
            Console.WriteLine("Press Any Key to continue");
            Console.ReadKey();
            break;
        case "9":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Ongeldige Keuze");
            break;
    }
 }

Account SelectAccount(string standaardTekst)
{
    int keuzeRekening;
    Console.WriteLine(standaardTekst);
    List<Account> list = accountManager.Accounts();
    for (int i = 0; i < list.Count; i++)
    {
        Console.WriteLine($"{i + 1}: {list[i]}");

    }


    do
    {
        Console.WriteLine("kies rekening of geef ESC in om terug te keren:");
    } while (!(int.TryParse(Console.ReadLine(), out keuzeRekening) && keuzeRekening > 0 && keuzeRekening <= list.Count) && Console.ReadLine() != "ESC");

    return list[keuzeRekening - 1];
    

    //if (int.TryParse(Console.ReadLine(), out var keuzeRekening) && keuzeRekening>0 && keuzeRekening <=list.Count)
    //{
    //    return list[keuzeRekening - 1];
    //}
    //else
    //{
    //    Console.WriteLine(("this is not a valid choice.  Choose an existing accountnumber"));

    //    return SelectAccount(standaardTekst);

    //}
}