using LP10.Catalogo.Application.DTOS;

namespace LP10.Catalogo.Application.Services
{
    public interface IProdutoAppService : IDisposable
    {
        Task<IEnumerable<ProdutoDTO>> ObterPorCategoria(int codigo);
        Task<ProdutoDTO> ObterPorId(Guid id);
        Task<IEnumerable<ProdutoDTO>> ObterTodos();
        Task<IEnumerable<CategoriaDTO>> ObterCategorias();

        Task AdicionarProduto(ProdutoDTO produtoViewModel);
        Task AtualizarProduto(ProdutoDTO produtoViewModel);

        Task<ProdutoDTO> DebitarEstoque(Guid id, int quantidade);
        Task<ProdutoDTO> ReporEstoque(Guid id, int quantidade);
    }
}
