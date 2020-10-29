using System;
using Cadmean.RPC.ASP;

namespace ExampleRpcServer.Controllers
{
    [FunctionRoute("getDate")]
    public class GetDateController : FunctionController
    {
        public DateTime OnCall()
        {
            return DateTime.Now;
        }
    }
}