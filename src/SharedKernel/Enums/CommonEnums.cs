namespace SharedKernel.Enums
{
    public enum HealthStatus
    {
        Normal = 0,
        Warning = 1,
        Critical = 2,
        Unknown = 3
    }

    public enum DeviceType
    {
        SmartWatch = 0,
        SmartRing = 1,
        BloodPressureMonitor = 2,
        GlucoseMonitor = 3,
        Other = 4
    }

    public enum NotificationPriority
    {
        Low = 0,
        Medium = 1,
        High = 2,
        Critical = 3
    }
    
    public enum NotificationType
    {
        Email = 0,
        SMS = 1,
        Push = 2,
        InApp = 3
    }
}
