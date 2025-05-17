using System;

namespace SharedKernel.Security
{
    public class AuthToken
    {
        public string AccessToken { get; private set; }
        public string RefreshToken { get; private set; }
        public DateTime ExpiresAt { get; private set; }

        public AuthToken(string accessToken, string refreshToken, DateTime expiresAt)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
            ExpiresAt = expiresAt;
        }

        public bool IsExpired()
        {
            return DateTime.UtcNow >= ExpiresAt;
        }
    }
}
