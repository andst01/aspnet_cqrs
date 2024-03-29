using FluentValidation.Results;
using Microsoft.AspNetCore.Identity;
using SGAS.Domain.Notifications;
using System.Collections.Generic;

namespace SGAS.Domain.Entity
{
    public abstract class EntidadeBase 
    {
        
       // public int Id { get; set; }

        private List<EventBase> _domainEvents;
        public IReadOnlyCollection<EventBase> DomainEvents => _domainEvents?.AsReadOnly();

        public void AddDomainEvent(EventBase domainEvent)
        {
            
            _domainEvents = _domainEvents ?? new List<EventBase>();
            _domainEvents.Add(domainEvent);
        }

        public void RemoveDomainEvent(EventBase domainEvent)
        {
            _domainEvents?.Remove(domainEvent);
        }

        public void ClearDomainEvents()
        {
            _domainEvents?.Clear();
        }

        public ValidationResult ValidationResult { get; set; }

      
    }

    public abstract class EntidadeBaseRole : IdentityRole<int>
    {


        private List<EventBase> _domainEvents;
        public IReadOnlyCollection<EventBase> DomainEvents => _domainEvents?.AsReadOnly();

        public void AddDomainEvent(EventBase domainEvent)
        {
            _domainEvents = _domainEvents ?? new List<EventBase>();
            _domainEvents.Add(domainEvent);
        }

        public void RemoveDomainEvent(EventBase domainEvent)
        {
            _domainEvents?.Remove(domainEvent);
        }

        public void ClearDomainEvents()
        {
            _domainEvents?.Clear();
        }

        public ValidationResult ValidationResult { get; set; }
    }

    public abstract class EntidadeBaseUser : IdentityUser<int>
    {


        private List<EventBase> _domainEvents;
        public IReadOnlyCollection<EventBase> DomainEvents => _domainEvents?.AsReadOnly();

        public void AddDomainEvent(EventBase domainEvent)
        {
            _domainEvents = _domainEvents ?? new List<EventBase>();
            _domainEvents.Add(domainEvent);
        }

        public void RemoveDomainEvent(EventBase domainEvent)
        {
            _domainEvents?.Remove(domainEvent);
        }

        public void ClearDomainEvents()
        {
            _domainEvents?.Clear();
        }

        public ValidationResult ValidationResult { get; set; }
    }

    public abstract class EntidadeBaseUserRole //: IdentityUserRole<int>
    {
        //public int Id { get; set; }

        private List<EventBase> _domainEvents;
        public IReadOnlyCollection<EventBase> DomainEvents => _domainEvents?.AsReadOnly();

        public void AddDomainEvent(EventBase domainEvent)
        {
            _domainEvents = _domainEvents ?? new List<EventBase>();
            _domainEvents.Add(domainEvent);
        }

        public void RemoveDomainEvent(EventBase domainEvent)
        {
            _domainEvents?.Remove(domainEvent);
        }

        public void ClearDomainEvents()
        {
            _domainEvents?.Clear();
        }

        public ValidationResult ValidationResult { get; set; }
    }

}
