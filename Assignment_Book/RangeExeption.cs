namespace Assignment_Book
{
    [Serializable]
    internal class RangeExeption : Exception
    {
        private readonly double price;
        private readonly int min;
        private readonly int max;

        public RangeExeption(double price, int min, int max) : base($"Prijs moet tussen {min} en {max} zijn. Uw waarden van {price} is ongeldig")
        {
            this.price = price;
            this.min = min;
            this.max = max;
        }

        public double Price { get => price; }
        public int Min { get => min;}
        public int Max { get => max;}
    }
}