using Gym.Api.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Gym.Api.Dtos;

namespace Gym.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{

    private IMapper _mapper;
    public EmployeeController(IMapper mapper) {
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult> GetOne() {

        var newObj = new Wall() {
            Difficulty = "easy",
            BoulderingGym = new BoulderingGym {
                Name = "Testing"
            }
        };

        return Ok(await Task.FromResult(_mapper.Map<WallResponse>(newObj)));
    }
}