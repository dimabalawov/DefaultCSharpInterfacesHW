using Classes;

Book[] bookArray = 
            {
                new Book("The Catcher in the Rye", "J.D. Salinger", "Fiction", 1951, 277),
                new Book("To Kill a Mockingbird", "Harper Lee", "Fiction", 1960, 324),
                new Book("1984", "George Orwell", "Dystopian", 1949, 328),
                new Book("The Great Gatsby", "F. Scott Fitzgerald", "Classic", 1925, 180),
                new Book("Moby-Dick", "Herman Melville", "Adventure", 1851, 635)
            };

Library library = new Library(bookArray);

Console.WriteLine("Unsorted Books:");
foreach (Book book in library)
{
    book.Show();
    Console.WriteLine();
}

Console.WriteLine("Books Sorted by Name:");
Array.Sort(bookArray, new Book.SortByName());
foreach (Book book in bookArray)
{
    book.Show();
    Console.WriteLine();
}

Console.WriteLine("Books Sorted by Author:");
Array.Sort(bookArray, new Book.SortByAuthor());
foreach (Book book in bookArray)
{
    book.Show();
    Console.WriteLine();
}
Console.WriteLine("Books Sorted by Year:");
Array.Sort(bookArray, new Book.SortByYear());
foreach (Book book in bookArray)
{
    book.Show();
    Console.WriteLine();
}

Console.WriteLine("Books Sorted by Genre:");
Array.Sort(bookArray, new Book.SortByGenre());
foreach (Book book in bookArray)
{
    book.Show();
    Console.WriteLine();
}

Console.WriteLine("Books Sorted by Pages:");
Array.Sort(bookArray, new Book.SortByPages());
foreach (Book book in bookArray)
{
    book.Show();
    Console.WriteLine();
}