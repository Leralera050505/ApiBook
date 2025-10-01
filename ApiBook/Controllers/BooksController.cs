using ApiBook.Contracts;
using BookStore.Aplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiBook.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService bookService;

        public BooksController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        //Медот, возвращающий все книги
        [HttpGet]
        public async Task<ActionResult<List<BooksResponse>>> GetBooks()
        {

            var books = await bookService.GetallBooks();

            var respons = books.Select(b =>
            new BooksResponse(b.Id, b.Title, b.Description, b.Price));

            return Ok(respons);
        }
    }
}
