namespace Assignment_Book
{
    internal class TextBook : Book
    {
        public TextBook(int isbn, string title, string author, double price)
            : base(isbn, title, author, price)
        {
            if (price < 20 || price > 80)
            {
                throw new RangeExeption(price, min: 20, max: 80);
            }
           
        }
        public int GradeLevel { get; set; }
    }
}
