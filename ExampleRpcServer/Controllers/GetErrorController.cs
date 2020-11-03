using Cadmean.RPC;
using Cadmean.RPC.ASP;

namespace ExampleRpcServer.Controllers
{
    [FunctionRoute("error")]
    public class GetErrorController : FunctionController
    {
        public string OnCall(bool throwError)
        {
            if (throwError)
                throw new FunctionException(42);

            return "no error";
        }
    }
}