namespace LP10.Catalogo.Domain.Services
{
    public interface IEstoqueService
    {
        Task<bool> DebitarEstoque(Guid produtoId, int quantidade);
        Task<bool> ReporEstoque(Guid produtoId, int quantidade);
    }
}
