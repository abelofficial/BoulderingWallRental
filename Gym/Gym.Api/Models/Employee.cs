

namespace Gym.Api.Models
{
    public class Employee
    {
        // Getting info from Admin platform
        public int Id { get; set; }

        public virtual BoulderingGym BoulderingGym { get; set; }

        public string Role { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        
    }
}