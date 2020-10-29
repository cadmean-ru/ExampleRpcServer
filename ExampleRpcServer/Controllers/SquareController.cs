using Cadmean.RPC.ASP;

namespace ExampleRpcServer.Controllers
{
    [FunctionRoute("square")]
    public class SquareController : FunctionController
    {
        [OnCall]
        public double Square(double d)
        {
            return d * d;
        }
    }
}