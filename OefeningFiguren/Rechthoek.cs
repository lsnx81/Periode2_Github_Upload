namespace OefeningFiguren
{
    internal class Rechthoek : Figuren
    {
        private int lengte;
        

        public int Lengte  { get => lengte; set => SetProperty(ref lengte, value); }
        
        public override double ToonOppervlakte()
        {
            return Breedte*Lengte;
        }
    }



}
