using MediatR;

namespace LP10.Core.Messages
{
    public abstract class Event : Message, INotification
    {
        public DateTime Timestamp { get; set; }
        protected Event()
        {
            Timestamp = DateTime.Now;
        }
    }
}
