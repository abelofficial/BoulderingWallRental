using AutoMapper;
using Gym.Api.Commands;
using Gym.Api.Dtos;
using MediatR;

namespace Gym.Api.Commands;
public class CreateWallHandler : IRequestHandler<CreateWallCommand, WallResponse>
{


  

    public async Task<WallResponse> Handle(CreateWallCommand request, CancellationToken cancellationToken)
    {
        

        return await Task.FromResult(new WallResponse() {Id = 1010});
    }
}