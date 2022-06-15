using System.ComponentModel.DataAnnotations;
using Gym.Api.Dtos;
using MediatR;

namespace Gym.Api.Commands
{
    public class CreateWallCommand: IRequest<WallResponse>
    {
    
        public string Difficulty { get; set; }

        public string Location { get; set; }
        
        public int Status { get; set; }

        public string Color { get; set; }

        public bool Available { get; set; }
    }
}