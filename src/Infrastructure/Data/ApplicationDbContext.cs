using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Test> Tests { get; set; }

    public DbSet<OpenQuestion> OpenQuestions { get; set; }

    public DbSet<TestCategory> TestCategories { get; set; }
}