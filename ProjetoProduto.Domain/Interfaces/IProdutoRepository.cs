using ProjetoProduto.Domain.Entities;

namespace ProjetoProduto.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        Produto Add(Produto produto);
        IEnumerable<Produto> GetAll();
        Produto? GetById(int id);
        Produto? Update(Produto produto, int id);
        Produto? Delete(int id);
    }
}