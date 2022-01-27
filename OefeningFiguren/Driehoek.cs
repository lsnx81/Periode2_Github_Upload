namespace OefeningFiguren
{
    internal class Driehoek : Figuren
    {
        private int hoogte;

        public int Hoogte { get => hoogte; set => SetProperty(ref hoogte, value); }
        public override double ToonOppervlakte()
        {
            return (Breedte*Hoogte)/2;
        }
    }



}
