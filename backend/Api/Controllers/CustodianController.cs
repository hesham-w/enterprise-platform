using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{

    [ApiController]
    [Route(Constants.DefaultRoute)]
    public class CustodianController : ControllerBase
    {
        private readonly ILogger<CustodianController> _logger;

        public CustodianController(ILogger<CustodianController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllCustodians()
        {
            _logger.LogInformation("Received a ping request");

            return Ok(DateTime.Now);
        }
    }
}