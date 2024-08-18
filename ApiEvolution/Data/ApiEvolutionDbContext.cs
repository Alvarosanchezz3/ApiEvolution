using Microsoft.EntityFrameworkCore;
using ApiEvolution.Models;

namespace ApiEvolution.Data
{
    public class ApiEvolutionDbContext : DbContext
    {
        public ApiEvolutionDbContext(DbContextOptions<ApiEvolutionDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}
