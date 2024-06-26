using Microsoft.AspNetCore.Mvc;
using TodoApp.Dtos;
using TodoApp.Infrastructure;
using TodoApp.Models;
using TodoApp.Services;

namespace TodoApp.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ProductsController:ControllerBase
{
    private readonly ILogger<ProductsController> _logger;
    private readonly IProductService _productService;

    public ProductsController(ILogger<ProductsController> logger, IProductService productService)
    {
        _logger = logger;
        _productService = productService;
    }
    
    [HttpGet]
    public IActionResult GetAll()
    {
        
        var allProducts = _productService.GetProducts();
        return Ok(allProducts);
    }

    [HttpPost]
    public IActionResult CreateProduct(CreateProductDto dto)
    {
        if (dto == null)
        {
            return BadRequest("No product!");
        }

        _productService.Create(dto);
        
        return Ok();
    }

    [HttpPut]
    public IActionResult UpdateProduct(Product item)
    {
        if (item == null)
        {
            return BadRequest("No product to be updated!");
        }

        _productService.Update(item);
        return Ok(); 
    }

    [HttpDelete]
    public IActionResult DeleteProduct(long Id)
    {
        _productService.Delete(Id);
        return Ok();
    }
}