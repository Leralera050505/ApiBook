using BookStore.DataAccess.Reposotories;
using BookStrore.Core.Models;

namespace BookStore.Aplication.Services
{

    //В этом проекте будут храниться все сервисы программы -кэщирование, валидация c используемая реползиториев
    public class BookService : IBookService
    {
        private readonly IBooksRepository booksRepository;

        //Конструктор - репозиторий с книгами
        public BookService(IBooksRepository booksRepository)
        {
            this.booksRepository = booksRepository;
        }
        public async Task<List<Book>> GetallBooks()
        {
            return await booksRepository.Get();
        }

        public async Task<Guid> CreateBook(Book book)
        {
            return await booksRepository.Create(book);
        }

        public async Task<Guid> UpdateBook(Guid id, string title, string description, decimal price)
        {
            return await booksRepository.Update(id, title, description, price);
        }

        public async Task<Guid> DeleteBook(Guid id)
        {
            return await booksRepository.Delete(id);
        }
    }
}
