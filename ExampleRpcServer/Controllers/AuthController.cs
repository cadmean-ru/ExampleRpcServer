using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Cadmean.CoreKit.Authentication;
using Cadmean.RPC;
using Cadmean.RPC.ASP;

namespace ExampleRpcServer.Controllers
{
    [FunctionRoute("auth")]
    public class AuthController : FunctionController
    {
        
        public Task<JwtAuthorizationTicket> OnCall(string email, string password)
        {
            if (email != "email@example.com" || password != "password") 
                throw new FunctionException(101);
            
            var accessToken = new JwtToken(
                JwtAuthorizationOptions.Default, 
                new List<Claim> {new Claim("email", email)}, 
                "cadmean"
                );
            
            var refreshToken = new JwtToken(
                JwtAuthorizationOptions.Default, 
                new List<Claim> {new Claim("email", email)}, 
                "cadmean");
            
            return Task.FromResult(new JwtAuthorizationTicket(accessToken.ToString(), refreshToken.ToString()));
        }
    }
}