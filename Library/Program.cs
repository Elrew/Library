using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        var library = new List<Book>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Library Management System");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Update Book");
            Console.WriteLine("3. Delete Book");
            Console.WriteLine("4. List All Books");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Clear();
                    AddBook(library);
                    break;
                case "2":
                    Console.Clear();
                    UpdateBook(library);
                    break;
                case "3":
                    Console.Clear();
                    DeleteBook(library);
                    break;
                case "4":
                    Console.Clear();
                    ListBooks(library);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void AddBook(List<Book> library)
    {
        Console.WriteLine("\nPlease enter the book Title:");
        string titleInput = Console.ReadLine();
        Book newBook = new Book();

        Console.WriteLine("Please enter the book Author:");
        string authorInput = Console.ReadLine();

        Console.WriteLine("Please enter the book Genre:");
        string genreInput = Console.ReadLine();

        Console.WriteLine("Please enter the book's publishing year:");
        string yearInput = Console.ReadLine();

        Console.WriteLine("Please enter the book's ISBN:");
        string isbnInput = Console.ReadLine();

        Console.WriteLine("Please enter the book description:");
        string descriptionInput = Console.ReadLine();


        newBook.Title = titleInput;
        newBook.Author = authorInput;
        newBook.Genre = genreInput;
        newBook.Year = yearInput;
        newBook.ISBN = isbnInput;
        newBook.Description = descriptionInput;
        library.Add(newBook);

        Console.WriteLine("\n" +
            newBook.Title + "\n" +
            newBook.Author + "\n" +
            newBook.Genre + "\n" +
            newBook.Year + "\n" +
            newBook.ISBN + "\n" +
            newBook.Description + "\n");


    }

    static void UpdateBook(List<Book> library)
    {
        Console.WriteLine(ListBooks);
        Console.WriteLine("Which book would you like to edit?:");
        // Need to add a way for the program to list just the titles of the books. 

        string userBookEdit = Console.ReadLine();

    }

    static void DeleteBook(List<Book> library)
    {
        // Implementation to delete a book
    }

    static void ListBooks(List<Book> library)
    {

        if (library.Count == 0)
        {
            Console.WriteLine("The library does not currently have any books in it.");
        }
        else
        {
            foreach (Book book in library)
            {

                Console.WriteLine("\n Title: " + book.Title);
                Console.WriteLine("Author: " + book.Author);
                Console.WriteLine("Genre: " + book.Genre);
                Console.WriteLine("Year: " + book.Year);
                Console.WriteLine("ISBN: " + book.ISBN);
                Console.WriteLine("Description: " + book.Description);
                Console.WriteLine();

            }

        }
    }
}

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public string Genre { get; set; }
    public string Description { get; set; }
    public string Year { get; set; }

    // Other properties and methods
}
