using Microsoft.AspNetCore.Mvc;

namespace ExampleRpcServer.Controllers
{
    [Route("/")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello, cadRPC";
        }
    }
}