namespace Assignment_Een_Eigen_Huis
{
    class Gang : Kamer
    {
        public Gang(string name, double vierkanteMeter) : base(name, vierkanteMeter)
        {
        }

        public override double Price =>(10*VierkanteMeter);
    }
}
