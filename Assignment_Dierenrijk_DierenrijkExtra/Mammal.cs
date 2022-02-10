namespace Assignment_Dierenrijk_DierenrijkExtra
{
    internal class Mammal:Animal, IPraat
    {
        public Mammal(bool isZwanger, string naam) : base(naam)
        {
         IsZwanger = isZwanger;
        }

        public bool IsZwanger { get; set; }
        public int Decibel { get; set; }

        public override void ToonInfo()
        {
            Console.WriteLine($"Eigenschappen van {this.GetType().Name} met namen {Naam} zijn:");
            Console.WriteLine($"Weet je dat {Naam} {(IsZwanger ? "zwanger is" : "niet zwanger is.")}");
        }
    }
}


