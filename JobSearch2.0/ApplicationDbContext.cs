using JobSearch2._0.Models;
using Microsoft.EntityFrameworkCore;

namespace JobSearch2._0
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Job> Jobs { get; set; }
    }
}