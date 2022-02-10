using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Book
{
    internal class Book : IEquatable<Book?>
    {
        private double _price;
        public Book(int isbn, string title, string author, double price)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            Price = price;
        }

        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get => _price; set => _price = value; }

        public static Book TelOp(Book boek1, Book boek2)
        {
            return new Book(
                    isbn:8582558
                , title: $"Omnibus van: {boek1.Author},{boek2.Author}"
                , author:"omnibus"
                , price: (boek1.Price + boek2.Price) / 2);
            
        }

    

        

        //  DEEL 2
        public override string ToString()
        {
            return $"{Title} {Author} ({ISBN}) {Price}";
        }

        public static bool operator ==(Book? left, Book? right)
        {
            return EqualityComparer<Book>.Default.Equals(left, right);
        }

        public static bool operator !=(Book? left, Book? right)
        {
            return !(left == right);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(ISBN, Title, Author, Price);
        }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Book);
        }

        public bool Equals(Book? other)
        {
            return other != null &&
                   ISBN == other.ISBN &&
                   Title == other.Title &&
                   Author == other.Author &&
                   Price == other.Price;
        }


        // DEEL 3

        public static Book operator +(Book boekEen, Book boekTwee) => Book.TelOp(boekEen, boekTwee);
    }
}
