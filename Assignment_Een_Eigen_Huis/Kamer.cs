namespace Assignment_Een_Eigen_Huis
{
    abstract class Kamer
    {
        public double VierkanteMeter { get; set; }
        public abstract double Price { get;}
        public string Name { get; set; }

        protected Kamer(string name, double vierkanteMeter)
        {
            Name = name;
            VierkanteMeter = vierkanteMeter;
        }
    }
}
