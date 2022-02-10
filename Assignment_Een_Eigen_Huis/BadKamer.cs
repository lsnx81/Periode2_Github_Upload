namespace Assignment_Een_Eigen_Huis
{
    class BadKamer : Kamer
    {
        public BadKamer(string name, double vierkanteMeter) : base(name, vierkanteMeter)
        {
        }

        public override double Price => 500;
    }
}
