namespace Assignment_Een_Eigen_Huis
{
    class Salon : Kamer
    {
        public Salon(string name, double vierkanteMeter, bool schouw) : base(name, vierkanteMeter)
        {
            Schouw = schouw;
        }

        public override double Price => Schouw ? 500 : 300;


        public bool Schouw { get; }
    }
}
