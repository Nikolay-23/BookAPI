using BookAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{
    // https://localhost:7040/api/books
    [Route("api/[Controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private Book[] _books = new Book[]
        {
            new Book{Id = 1, Author = "Author One", Title = "Book One"}
        };
    }
}
