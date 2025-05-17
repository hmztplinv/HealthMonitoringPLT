using System;
using MediatR;

namespace SharedKernel.Events
{
    public interface IDomainEvent : INotification
    {
        Guid Id { get; }
        DateTime OccurredOn { get; }
    }
}
