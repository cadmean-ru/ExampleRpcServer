using Cadmean.RPC.ASP;

namespace ExampleRpcServer.Controllers
{
    [FunctionRoute("sum")]
    public class SumController : FunctionController
    {
        public int OnCall(int a, int b)
        {
            return a + b;
        }
    }
}