using Gym.Api.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Gym.Api.Dtos;
using Gym.Api.Commands;
using MediatR;

namespace Gym.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{

    private readonly IMapper _mapper;
    private readonly IMediator _mediator;
    public EmployeeController(IMapper mapper, IMediator mediator ) {
        _mapper = mapper;
        _mediator = mediator;
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


    [HttpPost]
    public async Task<ActionResult> CreateOne(CreateWallCommand request) {

        var reponse = await _mediator.Send(request);

        return CreatedAtAction(nameof(GetOne), new {id = reponse.Id}, reponse);
    }
}