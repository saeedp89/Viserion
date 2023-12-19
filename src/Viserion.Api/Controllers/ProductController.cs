using Microsoft.AspNetCore.Mvc;

namespace Viserion.Api.Controllers;

[Route("/api/v1/products")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok(new{Data="products"});
    }
}