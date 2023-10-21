using LP10.Catalogo.Domain.Repository;
using MediatR;

namespace LP10.Catalogo.Domain.Events
{
    public class ProdutoEventHandler : INotificationHandler<ProdutoAbaixoEstoqueEvent>
    {
        private IProdutoRepository _produtoRepository;
        public ProdutoEventHandler(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task Handle(ProdutoAbaixoEstoqueEvent mensagem, CancellationToken cancellationToken)
        {
            var produtor = await _produtoRepository.ObterPorId(mensagem.AggregateId);
            // Enviar e-mail para aquisição de mais produtos por exemplo
        }
    }
}
