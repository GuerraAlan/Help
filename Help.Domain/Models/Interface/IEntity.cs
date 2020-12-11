using System;
using System.Collections.Generic;
using Help.Core.Models.Messaging;

namespace Help.Domain.Models.Interface
{
    public interface IEntity
    {
        Guid Id { get; set; }
        IReadOnlyCollection<Event> DomainEvents { get; }
        void AddDomainEvent(Event domainEvent);
        void RemoveDomainEvent(Event domainEvent);
        void ClearDomainEvents();
        bool Equals(object obj);
        int GetHashCode();
        string ToString();
    }
}
