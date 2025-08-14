using Microsoft.AspNetCore.Mvc;
using ProvaTecnica.Data;
using ProvaTecnica.Models;
using Microsoft.EntityFrameworkCore;
using ProvaTecnica.DTOs;
using ProvaTecnica.Services;

namespace ProvaTecnica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoGetDTO>>> GetProdutos()
        {
            var produtos = await _produtoService.GetProdutosAsync();
            return Ok(produtos);
        }

        [HttpPost]
        public async Task<ActionResult<Produto>> PostProduto(ProdutoPostDTO produtoDto)
        {
            var produto = await _produtoService.PostProdutoAsync(produtoDto);
            return CreatedAtAction(nameof(GetProdutos), new { id = produto.Id }, produto);
        }   
    }
}