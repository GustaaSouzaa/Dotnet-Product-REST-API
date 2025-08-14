using Microsoft.EntityFrameworkCore;
using ProvaTecnica.Data;
using ProvaTecnica.DTOs;
using ProvaTecnica.Models;

namespace ProvaTecnica.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly AppDbContext _context;

        public ProdutoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProdutoGetDTO>> GetProdutosAsync()
        {
            var produtos = await _context.Produtos
                .Select(p => new ProdutoGetDTO
                {
                    Id = p.Id,
                    Nome = p.Nome,
                    Preco = p.Preco,
                    Categoria = p.Categoria
                }).ToListAsync();

            return produtos;
        }

        public async Task<Produto> PostProdutoAsync(ProdutoPostDTO produtoDto)
        {
            var produto = new Produto
            {
                Nome = produtoDto.Nome,
                Preco = produtoDto.Preco,
                Categoria = produtoDto.Categoria
            };

            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();

            return produto;
        }
    }
}