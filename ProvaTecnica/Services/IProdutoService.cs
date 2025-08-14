using ProvaTecnica.DTOs;
using ProvaTecnica.Models;

namespace ProvaTecnica.Services
{
    public interface IProdutoService
    {
        Task<IEnumerable<ProdutoGetDTO>> GetProdutosAsync();
        Task<Produto> PostProdutoAsync(ProdutoPostDTO produtoDto);
    }
}