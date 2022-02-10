namespace Assignment_Een_Eigen_Huis
{
    class Zolder : Kamer
    {
        public Zolder(double vierkanteMeter, int dakramen) : base("zolder", vierkanteMeter)
        {
            Dakramen = dakramen;
        }

        public override double Price => (Dakramen*99)+1800;

        public int Dakramen { get; }
    }
}
