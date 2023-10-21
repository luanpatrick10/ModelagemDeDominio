using LP10.Core.Messages;

namespace LP10.Core.Bus
{
    public interface IMediatrHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
    }
}
