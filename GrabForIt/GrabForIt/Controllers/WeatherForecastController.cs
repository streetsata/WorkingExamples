using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace GrabForIt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private ILoggerManager _logger;

        public WeatherForecastController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInfo("Here is info message ");
            _logger.LogDebug("Here is debug message");
            _logger.LogWarn("Here is warn message");
            _logger.LogError("Here is error message");

            return new string[] { "v1", "v2" };
        }
    }
}