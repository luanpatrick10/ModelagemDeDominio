using LP10.Core.Messages;
using MediatR;

namespace LP10.Core.Bus
{
    public class MediatrHandler : IMediatrHandler
    {
        private readonly IMediator _mediator;
        public MediatrHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task PublicarEvento<T>(T evento) where T : Event
        {
            await _mediator.Publish(evento);
        }
    }
}
