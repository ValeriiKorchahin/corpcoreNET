namespace Corpcore.Dtos.JWT
{
    public class JwtToken
    {
        public required string SecretKey { get; set; }
        public required string Issuer { get; set; }
        public required string Audience { get; set; }
        public required int ExpiresInDays { get; set; }
    }
}
