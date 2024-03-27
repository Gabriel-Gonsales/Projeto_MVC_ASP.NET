using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MVC_ASP.NET.Model;
using MVC_ASP.NET.Model.Business;
using MVC_ASP.NET.Model.DTO;

namespace Teste_MVC.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly LivroService _livroService;

        public IndexModel(ILogger<IndexModel> logger, LivroService livroService)
        {
            _logger = logger;
            _livroService = livroService;
        }
        public IEnumerable<LivroDTO> Livros { get; private set; }
        public void OnGet()
        {
            Livros = _livroService.GetAllLivros();
        }
    }
}
