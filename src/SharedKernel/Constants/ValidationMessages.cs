namespace SharedKernel.Constants
{
    public static class ValidationMessages
    {
        // Common Validation Messages
        public const string RequiredField = "Bu alan zorunludur.";
        public const string InvalidFormat = "Geçersiz format.";
        public const string InvalidLength = "Geçersiz uzunluk.";
        public const string InvalidRange = "Geçersiz aralık.";
        
        // User/Identity Validation Messages
        public const string InvalidEmail = "Geçerli bir e-posta adresi giriniz.";
        public const string InvalidPassword = "Şifre en az 8 karakter olmalı ve en az bir büyük harf, bir küçük harf, bir sayı ve bir özel karakter içermelidir.";
        public const string PasswordMismatch = "Şifreler eşleşmiyor.";
        public const string InvalidUsername = "Kullanıcı adı en az 3 karakter olmalı ve sadece harf, sayı ve alt çizgi içermelidir.";
        
        // Patient Validation Messages
        public const string InvalidPatientId = "Geçersiz hasta kimliği.";
        public const string InvalidPatientName = "Hasta adı ve soyadı geçerli değil.";
        public const string InvalidDateOfBirth = "Geçersiz doğum tarihi.";
        public const string InvalidGender = "Geçersiz cinsiyet.";
        
        // Device Validation Messages
        public const string InvalidDeviceId = "Geçersiz cihaz kimliği.";
        public const string InvalidDeviceType = "Geçersiz cihaz tipi.";
        public const string InvalidSerialNumber = "Geçersiz seri numarası.";
        
        // Vital Data Validation Messages
        public const string InvalidVitalValue = "Geçersiz yaşamsal değer.";
        public const string InvalidVitalType = "Geçersiz yaşamsal veri tipi.";
        public const string InvalidMeasurementTime = "Geçersiz ölçüm zamanı.";
        
        // Organization Validation Messages
        public const string InvalidOrganizationName = "Geçersiz organizasyon adı.";
        public const string InvalidFacilityName = "Geçersiz tesis adı.";
        public const string InvalidDepartmentName = "Geçersiz departman adı.";
        
        // Notification Validation Messages
        public const string InvalidNotificationType = "Geçersiz bildirim tipi.";
        public const string InvalidNotificationPriority = "Geçersiz bildirim önceliği.";
        public const string InvalidRecipient = "Geçersiz alıcı.";
    }
}
