using ProjetoProduto.Domain.Entities;
using ProjetoProduto.Domain.Interfaces;
using ProjetoProduto.Infrastructure.Data;

namespace ProjetoProduto.Infrastructure.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProdutoRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Produto Add(Produto produto)
        {
            _appDbContext.Produtos.Add(produto);
            _appDbContext.SaveChanges();

            return produto;
        }

        public Produto? Delete(int id)
        {
            var produto = GetById(id);

            if (produto != null) _appDbContext.Produtos.Remove(produto);
            _appDbContext.SaveChanges();

            return produto;
        }

        public IEnumerable<Produto> GetAll()
        {
            return _appDbContext.Produtos.ToList();
        }

        public Produto? GetById(int id)
        {
            return _appDbContext.Produtos.FirstOrDefault(p => p.Id == id);
        }

        public Produto? Update(Produto produto, int id)
        {
            var produtoToUpdate = _appDbContext.Produtos.Find(id);

            if (produtoToUpdate != null)
            {
                produtoToUpdate.Nome = produto.Nome;
                produtoToUpdate.Descricao = produto.Descricao;
                produtoToUpdate.Preco = produto.Preco;

                _appDbContext.Produtos.Update(produtoToUpdate);
                _appDbContext.SaveChanges();
            }

            return produtoToUpdate;
        }
    }
}