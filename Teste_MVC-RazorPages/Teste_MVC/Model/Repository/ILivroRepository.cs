namespace MVC_ASP.NET.Model.Repository
{
    public interface ILivroRepository
    {
        public IEnumerable<Livro> GetAll();
        public void Add(Livro livro);
    }
}
