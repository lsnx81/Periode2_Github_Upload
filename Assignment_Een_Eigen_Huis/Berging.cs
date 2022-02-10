namespace Assignment_Een_Eigen_Huis
{
    class Berging : Kamer
    {
        public Berging(string name, double vierkanteMeter) : base(name, vierkanteMeter)
        {
        }

        public override double Price => 199;
    }
}
