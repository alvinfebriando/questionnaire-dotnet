namespace Questionnaire.Infrastructure.Authentication;

public class JwtSettings
{
    public const string SectionName = "JwtSettings";
    public string Key { get; init; } = null!;
    public int ExpiryMinutes { get; set; }
    public string Issuer { get; init; } = null!;
    public string Audience { get; init; } = null!;
}