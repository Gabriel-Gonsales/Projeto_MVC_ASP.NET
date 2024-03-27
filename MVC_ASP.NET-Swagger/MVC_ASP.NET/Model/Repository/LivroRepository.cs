namespace MVC_ASP.NET.Model.Repository
{
    public class LivroRepository : ILivroRepository
    {
        private List<Livro> _livros = [];

        public LivroRepository()
        {
            _livros.AddRange(
            [
                new() { Id = 1, Titulo = "Livro 1", Autor = "Autor 1", Preco = 20.50m },
                new() { Id = 2, Titulo = "Livro 2", Autor = "Autor 2", Preco = 15.75m },
                new() { Id = 3, Titulo = "Livro 3", Autor = "Autor 3", Preco = 18.00m }
            ]);
        }

        public IEnumerable<Livro> GetAll()
        {
            return _livros;
        }

        public void Add(Livro livro)
        {
            livro.Id = _livros.Count + 1;
            _livros.Add(livro);
        }
    }

}
