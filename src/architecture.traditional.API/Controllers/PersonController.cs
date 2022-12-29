using architecture.traditional.Domain.Models;
using architecture.traditional.Domain.Repository;
using Microsoft.AspNetCore.Mvc;

namespace architecture.traditional.API.Controllers;

[ApiController]
[Route("person")]
public class PersonController : ControllerBase
{
    private readonly ILogger<PersonController> _logger;
    public IPersonServices _personServices;

    public PersonController(ILogger<PersonController> logger, IPersonServices personServices)
    {
        _logger = logger;
        _personServices = personServices;
    }

    [HttpGet("{personId:guid}")]
    public async Task<IActionResult> Get(Guid personId)
    {
        PersonModel result = await _personServices.Get(personId);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Save(PersonModel model)
    {
        var exist = await _personServices.Get(model.Id);
        if (exist is not null && exist.Id != Guid.Empty)
            return StatusCode(StatusCodes.Status409Conflict);

        var result = _personServices.Save(model);
        if (result)
            return StatusCode(StatusCodes.Status201Created);
        else
            return StatusCode(StatusCodes.Status404NotFound);
    }
}
