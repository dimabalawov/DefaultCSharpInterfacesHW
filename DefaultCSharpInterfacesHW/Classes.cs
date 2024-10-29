using System;
using System.Collections;
using System.Collections.Generic;

namespace Classes
{
    public class Book : ICloneable, IComparable
    {
        public string Name { get; private set; } = "NULL";
        public string Author { get; private set; } = "NULL";
        public string Genre { get; private set; } = "NULL";
        public int Year { get; private set; } = -1;
        public int Pages { get; private set; } = -1;

        public Book(string name, string author, string genre, int year, int pages)
        {
            Name = name;
            Author = author;
            Genre = genre;
            Year = year;
            Pages = pages;
        }

        public void Show() =>
            Console.WriteLine($"Name: {Name}\nAuthor: {Author}\nGenre: {Genre}\nYear of Publication: {Year}\nAmount of Pages: {Pages}");

        #region ICloneable
        public object Clone()
        {
            return new Book(Name, Author, Genre, Year, Pages);
        }
        #endregion ICloneable

        #region IComparable
        public int CompareTo(object obj)
        {
            if (obj is Book book)
                return Year.CompareTo(book.Year);

            throw new ArgumentException("Object is not a Book");
        }
        #endregion IComparable

        #region IComparer
        public class SortByName : IComparer
        {
            public int Compare(object obj1, object obj2)
            {
                if (obj1 is Book book1 && obj2 is Book book2)
                    return book1.Name.CompareTo(book2.Name);

                throw new ArgumentException("Objects are not of type Book");
            }
        }

        public class SortByAuthor : IComparer
        {
            public int Compare(object obj1, object obj2)
            {
                if (obj1 is Book book1 && obj2 is Book book2)
                    return book1.Author.CompareTo(book2.Author);

                throw new ArgumentException("Objects are not of type Book");
            }
        }
        public class SortByYear : IComparer
        {
            public int Compare(object obj1, object obj2)
            {
                if (obj1 is Book book1 && obj2 is Book book2)
                    return book1.Year.CompareTo(book2.Year);

                throw new ArgumentException("Objects are not of type Book");
            }
        }
        public class SortByGenre : IComparer
        {
            public int Compare(object obj1, object obj2)
            {
                if (obj1 is Book book1 && obj2 is Book book2)
                    return book1.Genre.CompareTo(book2.Genre);

                throw new ArgumentException("Objects are not of type Book");
            }
        }
        public class SortByPages : IComparer
        {
            public int Compare(object obj1, object obj2)
            {
                if (obj1 is Book book1 && obj2 is Book book2)
                    return book1.Pages.CompareTo(book2.Pages);

                throw new ArgumentException("Objects are not of type Book");
            }
        }
        #endregion IComparer
    }

    public class Library : IEnumerable, IEnumerator
    {
        private Book[] books;
        private int curpos = -1;

        public Library(Book[] arr)
        {
            books = new Book[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                books[i] = (Book)arr[i].Clone();
        }

        #region IEnumerator
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public void Reset()
        {
            curpos = -1;
        }

        public object Current => books[curpos];

        public bool MoveNext()
        {
            if (curpos < books.Length - 1)
            {
                curpos++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }
        #endregion IEnumerator
    }
}
