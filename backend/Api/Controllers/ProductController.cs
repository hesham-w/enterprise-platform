using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route(Constants.DefaultRoute)]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            _logger.LogInformation("Received a ping request");

            return Ok(DateTime.Now);
        }

        [HttpGet]
        public IActionResult GetProduct(Guid id)
        {
            return NotFound();
        }
    }
}