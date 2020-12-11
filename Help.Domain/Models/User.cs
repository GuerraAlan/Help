using System;
using Help.Domain.Models.Base;
using Help.Domain.Models.Interface;

namespace Help.Domain.Models
{
    public class User : Entity, IAggregateRoot
    {
        protected User() { }

        public User(Guid id, string name, string email, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public string Name { get; init; }

        public string Email { get; init; }

        public DateTime BirthDate { get; init; }
    }
}
