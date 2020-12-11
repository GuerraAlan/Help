using System;
using Help.Core.Models.Messaging;

namespace Help.Core.Models.Events
{
    public class StoredEvent : Event
    {
        public StoredEvent(Event theEvent, string data, string user)
        {
            Id = Guid.NewGuid();
            AggregateId = theEvent.AggregateId;
            MessageType = theEvent.MessageType;
            Data = data;
            User = user;
        }

        // EF Constructor
        protected StoredEvent() { }

        public Guid Id { get; init; }

        public string Data { get; init; }

        public string User { get; init; }
    }
}
