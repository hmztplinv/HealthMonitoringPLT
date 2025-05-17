namespace SharedKernel.Constants
{
    public static class EventNames
    {
        // User Events
        public const string UserCreated = "user.created";
        public const string UserUpdated = "user.updated";
        public const string UserRoleChanged = "user.role.changed";
        public const string UserPasswordChanged = "user.password.changed";
        
        // Organization Events
        public const string OrganizationCreated = "organization.created";
        public const string OrganizationUpdated = "organization.updated";
        public const string FacilityAdded = "facility.added";
        public const string FacilityUpdated = "facility.updated";
        public const string DepartmentAdded = "department.added";
        public const string DepartmentUpdated = "department.updated";
        public const string PersonnelAssigned = "personnel.assigned";
        public const string PersonnelReassigned = "personnel.reassigned";
        
        // Patient Events
        public const string PatientRegistered = "patient.registered";
        public const string PatientUpdated = "patient.updated";
        public const string PatientFacilityChanged = "patient.facility.changed";
        public const string MedicalHistoryUpdated = "medical.history.updated";
        public const string MedicationAdded = "medication.added";
        public const string MedicationRemoved = "medication.removed";
        
        // Device Events
        public const string DeviceRegistered = "device.registered";
        public const string DeviceAssigned = "device.assigned";
        public const string DeviceUnassigned = "device.unassigned";
        public const string DeviceConfigured = "device.configured";
        public const string DeviceStatusChanged = "device.status.changed";
        public const string DeviceDataReceived = "device.data.received";
        
        // Vital Events
        public const string VitalDataReceived = "vital.data.received";
        public const string VitalAlertTriggered = "vital.alert.triggered";
        public const string VitalAnalyticsUpdated = "vital.analytics.updated";
        
        // Notification Events
        public const string NotificationCreated = "notification.created";
        public const string NotificationSent = "notification.sent";
        public const string NotificationRead = "notification.read";
    }
}
