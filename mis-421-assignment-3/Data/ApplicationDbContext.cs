using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using mis_421_assignment_3.Models;

namespace mis_421_assignment_3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<mis_421_assignment_3.Models.Movie>? Movie { get; set; }
        public DbSet<mis_421_assignment_3.Models.Actor>? Actor { get; set; }
        public DbSet<mis_421_assignment_3.Models.ActorMovie>? ActorMovie { get; set; }
    }
}