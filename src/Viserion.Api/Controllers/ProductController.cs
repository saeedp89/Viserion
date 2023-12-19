using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Viserion.Application;

namespace Viserion.Api.Controllers;

[Route("/api/v1/products")]
public class ProductController : ControllerBase
{

    [HttpGet]
    public IActionResult Index()
    {
        return Ok(new{Data="products"});
    }

    [HttpPost]
    public IActionResult Create([FromBody]ProductDto dto)
    {
        return Ok();
    }
}
