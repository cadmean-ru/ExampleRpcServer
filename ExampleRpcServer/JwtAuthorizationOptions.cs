using Cadmean.CoreKit.Authentication;

namespace ExampleRpcServer
{
    public static class JwtAuthorizationOptions
    {
        public static AuthOptions Default = new AuthOptions
        (
            "localhost:5000", 
            "localhost:5000", 
            "bruebukljhuih91283u", 
            60
        );

        public static bool Validator(string token)
        {
            return !string.IsNullOrWhiteSpace(token) && new JwtToken(token).Validate(JwtAuthorizationOptions.Default);
        }
    }
}