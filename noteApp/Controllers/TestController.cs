using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using noteApp.Models;

namespace noteApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IConfiguration _config;
    private readonly DatabaseContext _context; 

    public TestController(DatabaseContext context, IMapper mapper, IConfiguration config)
    {
        _mapper = mapper;
        _config = config;  
        _context = context;
    }

    [HttpGet("test")]
    public IActionResult test()
    {
        return Ok(_context.Users.ToList());
        // return "App and working2" + _config.GetConnectionString("DefaultConnection");
    }
    
    [HttpGet("test2")]
    public string GetNotes()
    {    
        return "App and working2" + _config.GetConnectionString("DefaultConnection");
    }
}