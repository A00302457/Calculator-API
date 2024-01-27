using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class Calculator : Controller
    {
        public string TestMethod()
        {
            return "Tesing";
        }   

        public string Get()
        {
            return "Get Method";
        }

    }
}
