using BookStrore.Core.Models;

namespace BookStore.Aplication.Services
{
    public interface IBookService
    {
        Task<Guid> CreateBook(Book book);
        Task<Guid> DeleteBook(Guid id);
        Task<List<Book>> GetallBooks();
        Task<Guid> UpdateBook(Guid id, string title, string description, decimal price);
    }
}