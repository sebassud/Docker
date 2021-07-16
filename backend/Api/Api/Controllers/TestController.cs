using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {

        private readonly AppOptions _options;

        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger, IOptions<AppOptions> options)
        {
            _logger = logger;
            _options = options.Value;
        }

        [HttpGet]
        [Route("Hello")]
        public string Hello()
        {
            _logger.LogInformation($"GET: Hello : {_options.Welcome}");
            return $"Powitanie z serwera: {_options.Welcome}";
        }
    }
}
