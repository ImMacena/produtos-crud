using ProjetoProduto.Domain.Entities;
using ProjetoProduto.Domain.Interfaces;

namespace ProjetoProduto.Application.Services
{
    public class ProdutoServices
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoServices(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public Produto CriarProduto(Produto produto)
        {
            return _produtoRepository.Add(produto);
        }

        public IEnumerable<Produto> ListarTodosProdutos()
        {
            return _produtoRepository.GetAll();
        }

        public Produto? BuscarProdutoPorId(int id)
        {
            return _produtoRepository.GetById(id);
        }

        public Produto? AtualizarProduto(Produto produto, int id)
        {
            return _produtoRepository.Update(produto, id);
        }

        public Produto? DeletarProduto(int id)
        {
            return _produtoRepository.Delete(id);
        }
    }
}