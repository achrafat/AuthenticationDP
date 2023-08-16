using AuthenticationRefactor;

namespace AuthentificationRefactor
{
    public interface ITokenValidator
    {
        string ValidateToken(string token, AuthenticationProtocolEnum protocolType, string urlapi="");
    }
}