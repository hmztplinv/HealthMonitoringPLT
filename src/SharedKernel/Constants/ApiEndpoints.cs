namespace SharedKernel.Constants
{
    public static class ApiEndpoints
    {
        // Identity Service Endpoints
        public const string IdentityServiceBase = "api/identity";
        public const string Login = IdentityServiceBase + "/login";
        public const string Register = IdentityServiceBase + "/register";
        public const string RefreshToken = IdentityServiceBase + "/refresh-token";
        public const string RevokeToken = IdentityServiceBase + "/revoke-token";
        
        // Organization Service Endpoints
        public const string OrganizationServiceBase = "api/organizations";
        public const string Facilities = OrganizationServiceBase + "/facilities";
        public const string Departments = OrganizationServiceBase + "/departments";
        public const string Personnel = OrganizationServiceBase + "/personnel";
        
        // Patient Service Endpoints
        public const string PatientServiceBase = "api/patients";
        public const string MedicalHistory = PatientServiceBase + "/medical-history";
        public const string Medications = PatientServiceBase + "/medications";
        public const string DeviceAssignment = PatientServiceBase + "/devices";
        
        // Device Service Endpoints
        public const string DeviceServiceBase = "api/devices";
        public const string DeviceRegistration = DeviceServiceBase + "/register";
        public const string DeviceConfig = DeviceServiceBase + "/configure";
        public const string DeviceStatus = DeviceServiceBase + "/status";
        
        // Vital Service Endpoints
        public const string VitalServiceBase = "api/vitals";
        public const string VitalData = VitalServiceBase + "/data";
        public const string VitalAnalytics = VitalServiceBase + "/analytics";
        public const string VitalAlerts = VitalServiceBase + "/alerts";
        
        // Notification Service Endpoints
        public const string NotificationServiceBase = "api/notifications";
        public const string NotificationPreferences = NotificationServiceBase + "/preferences";
        public const string NotificationHistory = NotificationServiceBase + "/history";
    }
}
