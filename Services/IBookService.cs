using BookManagementApi.Models;

namespace BookManagementApi.Services
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        Book? GetBookById(int id);
        void AddBook(Book book);
    }
}
