using Help.Core.Models.Messaging;

namespace Help.Core.Models.Events
{
    public interface IEventStore
    {
        void Save<T>(T theEvent) where T : Event;
    }
}
