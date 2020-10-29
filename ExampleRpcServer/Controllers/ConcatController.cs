using Cadmean.RPC.ASP;

namespace ExampleRpcServer.Controllers
{
    [FunctionRoute("concat")]
    public class ConcatController : FunctionController
    {
        private string OnCall(string a, string b, string c)
        {
            return a + b + c;
        }
    }
}