using System;
using SharedKernel.Events;

namespace SharedKernel.Events.Identity
{
    public class UserCreatedEvent : DomainEvent
    {
        public Guid UserId { get; }
        public string Username { get; }
        public string Email { get; }
        public string[] Roles { get; }
        public Guid? OrganizationId { get; }

        public UserCreatedEvent(
            Guid userId,
            string username,
            string email,
            string[] roles,
            Guid? organizationId = null)
        {
            UserId = userId;
            Username = username;
            Email = email;
            Roles = roles;
            OrganizationId = organizationId;
        }
    }

    public class UserRoleChangedEvent : DomainEvent
    {
        public Guid UserId { get; }
        public string[] PreviousRoles { get; }
        public string[] NewRoles { get; }
        public string ChangedBy { get; }
        public string Reason { get; }

        public UserRoleChangedEvent(
            Guid userId,
            string[] previousRoles,
            string[] newRoles,
            string changedBy,
            string reason)
        {
            UserId = userId;
            PreviousRoles = previousRoles;
            NewRoles = newRoles;
            ChangedBy = changedBy;
            Reason = reason;
        }
    }
}
