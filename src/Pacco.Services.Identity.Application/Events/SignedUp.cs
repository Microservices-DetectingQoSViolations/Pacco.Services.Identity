using System;
using Convey.CQRS.Events;

namespace Pacco.Services.Identity.Application.Events
{
    public class SignedUp : IEvent
    {
        public Guid Id { get; }
        public string Role { get; }
        
        public SignedUp(Guid id, string role)
        {
            Id = id;
            Role = role;
        }
    }
}