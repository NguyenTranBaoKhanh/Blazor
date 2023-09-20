using API.Entities;
using API.Interface;
using Microsoft.AspNetCore.Mvc;
using Share;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoryController : ControllerBase
{


    private readonly ILogger<WeatherForecastController> _logger;
    private readonly ICategory _category;

    public CategoryController(ILogger<WeatherForecastController> logger, ICategory category)
    {
        _logger = logger;
        _category = category;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery]CategorySearch query)
    {
        var category = await _category.GetAll(query);
        return Ok(category);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var category = await _category.GetById(id);
        return Ok(category);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody]CategoryCreate category)
    {
        var categoryNew = await _category.Create(category);
        return Ok(categoryNew);
    }

    
}
