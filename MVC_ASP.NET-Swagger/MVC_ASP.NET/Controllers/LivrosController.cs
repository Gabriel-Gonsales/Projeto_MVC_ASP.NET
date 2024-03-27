using Microsoft.AspNetCore.Mvc;
using MVC_ASP.NET.Model.Business;
using MVC_ASP.NET.Model.DTO;

namespace MVC_ASP.NET.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivrosController : ControllerBase
    {
        private readonly LivroService _livroService;

        public LivrosController(LivroService livroService)
        {
            _livroService = livroService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<LivroDTO>> GetAllLivros()
        {
            var livros = _livroService.GetAllLivros();
            return Ok(livros);
        }

        [HttpPost]
        public ActionResult AdicionarLivro([FromBody] LivroDTO livro)
        {
            _livroService.AdicionarLivro(livro);
            return Created();
        }
    }
}
