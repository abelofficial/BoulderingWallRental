

namespace Gym.Api.Models
{
    public class BoulderingGym
    {
        // Getting info from Admin platform
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual List<Wall> Walls { get; set; }
        public virtual List<Employee> Employees { get; set; }
   
    }
}