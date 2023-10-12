using Microsoft.EntityFrameworkCore;

namespace Unit2Project.Models
{
    public class ComicContext: DbContext
    {
        public ComicContext(DbContextOptions<ComicContext> options)
        : base(options)
        { }

        public DbSet<Comic> Comics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comic>().HasData(
                new Comic
                {
                    Id = 1,
                    Name = "Absolute Carnage",
                    Company = "Marvel",
                    IssueNo = 1,
                },
                new Comic
                {
                    Id= 2,
                    Name = "Batman: Year One",
                    Company = "D.C.",
                    IssueNo = 1,
                    
                },
                new Comic
                {
                    Id = 3,
                    Name = "Invincible",
                    Company = "Image Comics",
                    IssueNo = 1,
                });
        }
    }
}
