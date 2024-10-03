using Microsoft.AspNetCore.Mvc;
using ProjetoProduto.Application.DTOs;
using ProjetoProduto.Application.Services;
using ProjetoProduto.Domain.Entities;

namespace ProjetoProduto.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly ProdutoServices _produtoService;
        public ProdutosController(ProdutoServices produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpPost]
        public IActionResult Criar(ProdutoDTO produtoDto)
        {
            var produtoToCreate = new Produto
            {
                Nome = produtoDto.Nome,
                Descricao = produtoDto.Descricao,
                Preco = produtoDto.Preco,
                DataCadastro = DateTime.Now
            };

            var produtoCriado = _produtoService.CriarProduto(produtoToCreate);

            if (produtoCriado != null)
            {
                return Created($"Produtos/{produtoCriado.Id}", produtoCriado);
            }

            return NotFound("Não foi possível criar o registro.");
        }

        [HttpGet]
        public IActionResult ListarTodos()
        {
            var produtos = _produtoService.ListarTodosProdutos();

            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public IActionResult ListarPorId(int id)
        {
            var produto = _produtoService.BuscarProdutoPorId(id);

            if (produto != null)
                return Ok(produto);

            return NotFound("Registo não encontrado.");
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] ProdutoDTO produtoDto)
        {
            var produtoToUpdate = new Produto
            {
                Nome = produtoDto.Nome,
                Descricao = produtoDto.Descricao,
                Preco = produtoDto.Preco,
            };

            var produtoUpdated = _produtoService.AtualizarProduto(produtoToUpdate, id);

            if (produtoUpdated != null)
                return Ok(produtoUpdated);

            return NotFound("Registo não encontrado.");
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var produtoDeleted = _produtoService.DeletarProduto(id);

            if (produtoDeleted != null)
                return Ok(produtoDeleted);

            return NotFound("Registo não encontrado.");
        }
    }
}