using System.ComponentModel.DataAnnotations;
using AutoMapper;
using Gym.Api.Models;

namespace Gym.Api.Dtos
{
    public class WallResponse
    {
        // Getting information from admin platform

        [Key]
        public int Id { get; set; }

    
        public string Difficulty { get; set; }

        public string Location { get; set; }
        
        public int Status { get; set; }

        public string Color { get; set; }

        public bool Available { get; set; }
    }

    public class GetResponseToWallProfile : Profile {

        public GetResponseToWallProfile() {
            CreateMap<Wall, WallResponse>();
        }
    }

}