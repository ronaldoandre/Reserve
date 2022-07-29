using Microsoft.AspNetCore.Mvc;
using Reserve.Domain.Interfaces;
using Reserve.Domain.Models;

namespace Reserve.Api.Controller;

[Route("api/[controller]")]
[ApiController]
public class CovidController : ControllerBase
{
    private readonly IService _service;
    public CovidController(IService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<Consulta>> Get()
    {
        return  await _service.Get();

    }

    
}