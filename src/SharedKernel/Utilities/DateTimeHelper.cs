using System;

namespace SharedKernel.Utilities
{
    public static class DateTimeHelper
    {
        public static DateTime GetCurrentUtcDateTime()
        {
            return DateTime.UtcNow;
        }

        public static bool IsValidTimeRange(DateTime startTime, DateTime endTime)
        {
            return startTime < endTime;
        }

        public static string FormatDateTime(DateTime dateTime, string format = "yyyy-MM-dd HH:mm:ss")
        {
            return dateTime.ToString(format);
        }

        public static int CalculateAge(DateTime birthDate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthDate.Year;
            
            if (birthDate.Date > today.AddYears(-age))
            {
                age--;
            }
            
            return age;
        }
    }
}
