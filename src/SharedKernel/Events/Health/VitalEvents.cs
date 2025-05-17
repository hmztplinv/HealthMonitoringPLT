using System;
using SharedKernel.Constants;
using SharedKernel.Events;

namespace SharedKernel.Events.Health
{
    public class VitalDataReceivedEvent : DomainEvent
    {
        public Guid PatientId { get; }
        public Guid DeviceId { get; }
        public string VitalType { get; }
        public double Value { get; }
        public string Unit { get; }
        public DateTime MeasurementTime { get; }

        public VitalDataReceivedEvent(
            Guid patientId,
            Guid deviceId,
            string vitalType,
            double value,
            string unit,
            DateTime measurementTime)
        {
            PatientId = patientId;
            DeviceId = deviceId;
            VitalType = vitalType;
            Value = value;
            Unit = unit;
            MeasurementTime = measurementTime;
        }
    }

    public class VitalAlertTriggeredEvent : DomainEvent
    {
        public Guid PatientId { get; }
        public Guid DeviceId { get; }
        public string VitalType { get; }
        public double Value { get; }
        public string Unit { get; }
        public string AlertMessage { get; }
        public Enums.HealthStatus Severity { get; }
        public DateTime MeasurementTime { get; }

        public VitalAlertTriggeredEvent(
            Guid patientId,
            Guid deviceId,
            string vitalType,
            double value,
            string unit,
            string alertMessage,
            Enums.HealthStatus severity,
            DateTime measurementTime)
        {
            PatientId = patientId;
            DeviceId = deviceId;
            VitalType = vitalType;
            Value = value;
            Unit = unit;
            AlertMessage = alertMessage;
            Severity = severity;
            MeasurementTime = measurementTime;
        }
    }
}
