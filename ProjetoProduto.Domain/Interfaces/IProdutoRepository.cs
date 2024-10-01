using ProjetoProduto.Domain.Entities;

namespace ProjetoProduto.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        void Add(Produto produto);
        IEnumerable<Produto> GetAll();
        Produto? GetById(int id);
        void Update(Produto produto, int id);
        void Delete(int id);
    }
}