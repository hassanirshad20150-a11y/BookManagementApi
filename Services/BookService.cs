using BookManagementApi.Models;

namespace BookManagementApi.Services
{
    public class BookService : IBookService
    {
        private readonly List<Book> _books = new List<Book>();

        public List<Book> GetAllBooks()
        {
            return _books;
        }

        public Book? GetBookById(int id)
        {
            return _books.FirstOrDefault(b => b.Id == id);
        }

        public void AddBook(Book book)
        {
            // Validate client-provided Id
            if (book.Id <= 0)
                throw new ArgumentException("Id must be greater than 0.");

            if (_books.Any(b => b.Id == book.Id))
                throw new ArgumentException("A book with this Id already exists.");

            _books.Add(book);
        }
    }
}