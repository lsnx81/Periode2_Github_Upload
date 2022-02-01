namespace Assignent_Speelkaarten
{
    internal class Speelkaart
    {
        // Providing a constructor (ctor) forces a user to provide data
        public Speelkaart(int getal, Suite suite)
        {
            Getal = getal;
            Suite = suite;
        }

        public int Getal { get; set; }
        public Suite Suite { get; set; }
    }
}