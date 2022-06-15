using Gym.Api.Models;
using Microsoft.EntityFrameworkCore;

public class GymAppDbContext : DbContext
{
    public GymAppDbContext(DbContextOptions<GymAppDbContext> opt) : base(opt)
    {

    }

    public DbSet<Wall> Walls  { get; set; }
    public DbSet<Employee> Employees { get; set; }

    public DbSet<BoulderingGym> BoulderingGyms { get; set; }
}