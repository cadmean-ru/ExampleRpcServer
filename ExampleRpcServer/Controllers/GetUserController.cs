using System.Linq;
using System.Threading.Tasks;
using Cadmean.CoreKit.Authentication;
using Cadmean.RPC.ASP;

namespace ExampleRpcServer.Controllers
{
    [FunctionRoute("user.get")]
    public class GetUserController : FunctionController
    {
        public new class User
        {
            public string Email { get; set; }
            public string Name { get; set; }
        }

        [OnCall]
        [RpcAuthorize]
        public Task<User> GetUser()
        {
            var jwt = new JwtToken(Call.Authorization);
            
            var email = jwt.Claims.FirstOrDefault(c => c.Type == "email")?.Value ?? "";

            return Task.FromResult(new User
            {
                Email = email,
                Name = "George",
            });
        }
    }
}