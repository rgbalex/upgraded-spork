using Microsoft.AspNetCore.Mvc;

namespace upgraded_spork.Server.Controllers
{
    // Seems to just make things complicated.
    //[ApiController]
    [Route("[controller]")]
    public class SampleController : Controller
    {
        private readonly ILogger<SampleController> _logger;

        public SampleController(ILogger<SampleController> logger)
        {
            _logger = logger;
            _logger.LogInformation("Hello, World!");
        }

        [Route("zain")]
        public JsonResult Zain()
            => Json(new { Name = "Zain Ul Hassan", ID = 1 });

        [Route("alex")]
        public JsonResult Alex()
            => Json(new { Name = "Alex", ID = 2 });

    }
}
