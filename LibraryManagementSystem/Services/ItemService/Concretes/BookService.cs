using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services.Interfaces;

namespace LibraryManagementSystem.Services.Concretes;

public class BookService : IBookService
{
    public static List<Book> Books;

    public BookService()
    {
        Books = new List<Book>();
    }
    public void CreateBook(Book book)
    {
        Books.Add(book);
    }

    public void DeleteBook(int id, bool IsSoftDelete)
    {
        int index = -1;
        for (int i = 0; i < Books.Count; i++)
        {
            if (id == Books[i].Id)
            {
                index = i;
                break;
            }
        }

    }

    public List<Book> GetAllBooks()
    {
        return Books;
    }

    public Book GetBookById(int id)
    {
        int index = -1;
        for (int i = 0; i < Books.Count; i++)
        {
            if (id == Books[i].Id)
            {
                index = i;
                break;
            }
        }

        if (index != -1)
        {
            return Books[index];
        }
        else
        {
            throw new Exception($"Kitabin id ({id}) sine uygun kitab tapilmadi");
        }
    }
}
