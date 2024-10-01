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

        public void CriarProduto(Produto produto)
        {
            _produtoRepository.Add(produto);
        }

        public IEnumerable<Produto> ListarTodosProdutos()
        {
            return _produtoRepository.GetAll();
        }

        public Produto? BuscarProdutoPorId(int id)
        {
            return _produtoRepository.GetById(id);
        }

        public void AtualizarProduto(Produto produto, int id)
        {
            _produtoRepository.Update(produto, id);
        }

        public void DeletarProduto(int id)
        {
            _produtoRepository.Delete(id);
        }
    }
}