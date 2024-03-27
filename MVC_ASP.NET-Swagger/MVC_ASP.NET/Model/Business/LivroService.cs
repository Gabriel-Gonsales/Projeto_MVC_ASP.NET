using MVC_ASP.NET.Model.DTO;
using MVC_ASP.NET.Model.Repository;

namespace MVC_ASP.NET.Model.Business
{
    public class LivroService
    {
        private readonly ILivroRepository _livroRepository;

        public LivroService(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public IEnumerable<LivroDTO> GetAllLivros()
        {
            var livros = _livroRepository.GetAll();
            return livros.Select(livro => new LivroDTO
            {
                Titulo = livro.Titulo,
                Autor = livro.Autor,
                Preco = livro.Preco
            });
        }


        public void AdicionarLivro(LivroDTO livroDTO)
        {
            var livro = new Livro
            {
                Titulo = livroDTO.Titulo,
                Autor = livroDTO.Autor,
                Preco = livroDTO.Preco
            };
            _livroRepository.Add(livro);
        }
    }

}
