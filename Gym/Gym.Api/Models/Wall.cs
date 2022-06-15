using System.ComponentModel.DataAnnotations;

namespace Gym.Api.Models
{
    public class Wall
    {
        // Getting information from admin platform

        [Key]
        public int Id { get; set; }

        public virtual BoulderingGym BoulderingGym { get; set; }
    
        public string Difficulty { get; set; }

        public string Location { get; set; }
        
        public int Status { get; set; }

        public string Color { get; set; }

        public bool Available { get; set; }
    }
}