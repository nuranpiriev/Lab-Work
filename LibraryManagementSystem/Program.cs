using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services.Concretes;
using System;
using System.Reflection.Metadata.Ecma335;

namespace ReAnimalClass
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            LibrarianService librarianService = new LibrarianService();

            Librarian librarian1 = new Librarian("Sadiq")
            {
               
                HireDate = DateTime.Now,

            };
            Librarian librarian2 = new Librarian("Adem")
            {
                HireDate = new DateTime(2005)
            };
            
           
            librarianService.CreateLibrarian(librarian1);
            librarianService.CreateLibrarian(librarian2);

            BookService bookService = new BookService();
            Book book1 = new Book("Mein camp", 1934);
            Book book2 = new Book("1984", 1999);
            bookService.CreateBook(book1);
            bookService.CreateBook(book2);


            foreach (var librarian in librarianService.GetAllLibrarians())
            {
                Console.WriteLine($"Librarian Adı: {librarian.Name}, Status: {librarian.LibrarianStatus}, Hire Date: {librarian.HireDate}");
            }
            librarianService.DeleteLibrarian(1,false );
            foreach (var librarian in librarianService.GetAllLibrarians())
            {
                Console.WriteLine($"Librarian Adı: {librarian.Name}, Status: {librarian.LibrarianStatus}, Hire Date: {librarian.HireDate}");
            }


        }

    
       
    }
}