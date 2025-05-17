using System;
using SharedKernel.Events;

namespace SharedKernel.Events.Organization
{
    public class PersonnelAssignedEvent : DomainEvent
    {
        public Guid PersonnelId { get; }
        public Guid OrganizationId { get; }
        public Guid FacilityId { get; }
        public Guid DepartmentId { get; }
        public string Role { get; }
        public DateTime AssignmentDate { get; }
        public string AssignedBy { get; }

        public PersonnelAssignedEvent(
            Guid personnelId,
            Guid organizationId,
            Guid facilityId,
            Guid departmentId,
            string role,
            DateTime assignmentDate,
            string assignedBy)
        {
            PersonnelId = personnelId;
            OrganizationId = organizationId;
            FacilityId = facilityId;
            DepartmentId = departmentId;
            Role = role;
            AssignmentDate = assignmentDate;
            AssignedBy = assignedBy;
        }
    }

    public class PersonnelReassignedEvent : DomainEvent
    {
        public Guid PersonnelId { get; }
        public Guid OrganizationId { get; }
        public Guid PreviousFacilityId { get; }
        public Guid PreviousDepartmentId { get; }
        public Guid NewFacilityId { get; }
        public Guid NewDepartmentId { get; }
        public string Role { get; }
        public DateTime ReassignmentDate { get; }
        public string ReassignedBy { get; }
        public string Reason { get; }

        public PersonnelReassignedEvent(
            Guid personnelId,
            Guid organizationId,
            Guid previousFacilityId,
            Guid previousDepartmentId,
            Guid newFacilityId,
            Guid newDepartmentId,
            string role,
            DateTime reassignmentDate,
            string reassignedBy,
            string reason)
        {
            PersonnelId = personnelId;
            OrganizationId = organizationId;
            PreviousFacilityId = previousFacilityId;
            PreviousDepartmentId = previousDepartmentId;
            NewFacilityId = newFacilityId;
            NewDepartmentId = newDepartmentId;
            Role = role;
            ReassignmentDate = reassignmentDate;
            ReassignedBy = reassignedBy;
            Reason = reason;
        }
    }

    public class PatientFacilityChangedEvent : DomainEvent
    {
        public Guid PatientId { get; }
        public Guid OrganizationId { get; }
        public Guid PreviousFacilityId { get; }
        public Guid NewFacilityId { get; }
        public DateTime ChangeDate { get; }
        public string ChangedBy { get; }
        public string Reason { get; }

        public PatientFacilityChangedEvent(
            Guid patientId,
            Guid organizationId,
            Guid previousFacilityId,
            Guid newFacilityId,
            DateTime changeDate,
            string changedBy,
            string reason)
        {
            PatientId = patientId;
            OrganizationId = organizationId;
            PreviousFacilityId = previousFacilityId;
            NewFacilityId = newFacilityId;
            ChangeDate = changeDate;
            ChangedBy = changedBy;
            Reason = reason;
        }
    }
}
