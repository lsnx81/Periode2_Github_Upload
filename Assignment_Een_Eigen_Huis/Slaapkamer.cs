namespace Assignment_Een_Eigen_Huis
{
    class Slaapkamer : Kamer
    {
        public Slaapkamer(string name, double vierkanteMeter) : base(name, vierkanteMeter)
        {
        }

        public override double Price => 225;
    }
}
