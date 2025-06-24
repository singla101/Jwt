namespace JwtAuthDotNet9_New.Models
{
    public class TokenresponseDto
    {
        public required string AccessToken { get; set; }
        public required string RefreshToken { get; set; }
    }
}
