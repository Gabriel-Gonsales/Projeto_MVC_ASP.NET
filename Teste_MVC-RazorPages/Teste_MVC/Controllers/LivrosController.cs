using Microsoft.AspNetCore.Mvc;
using MVC_ASP.NET.Model;
using MVC_ASP.NET.Model.Business;
using MVC_ASP.NET.Model.DTO;
using MVC_ASP.NET.Model.Repository;

namespace MVC_ASP.NET.Controllers
{
    [ApiController]
    public class LivroController : Controller
    {
        private readonly LivroService _livroService;

        public LivroController()
        {
            _livroService = new LivroService(new LivroRepository());
        }
        [Route("Livros/Index")]
        public ActionResult Index()
        {
            var livros = _livroService.GetAllLivros();
            return View(livros);
        }

    }
}
