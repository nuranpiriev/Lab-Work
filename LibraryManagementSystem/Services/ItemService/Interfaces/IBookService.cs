using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Services.Interfaces;

public interface IBookService
{
    Book GetBookById(int id);
    List<Book> GetAllBooks();
    void CreateBook(Book book);
    void DeleteBook(int id, bool IsSoftDelete);
}


