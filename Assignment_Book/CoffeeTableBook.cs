namespace Assignment_Book
{
    internal class CoffeeTableBook : Book, IEquatable<Book?>
    {
        public CoffeeTableBook(int isbn, string title, string author, double price)
            : base(isbn, title, author, price)
        {
            if(price < 35 || price >100)
            {
                throw new RangeExeption(price, min: 35, max: 100);
            }
           
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Book);
        }

        public bool Equals(Book? other)
        {
            return other != null &&
                   base.Equals(other) &&
                   ISBN == other.ISBN;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), ISBN);
        }

        public static bool operator ==(CoffeeTableBook? left, CoffeeTableBook? right)
        {
            return EqualityComparer<CoffeeTableBook>.Default.Equals(left, right);
        }

        public static bool operator !=(CoffeeTableBook? left, CoffeeTableBook? right)
        {
            return !(left == right);
        }
    }
}
