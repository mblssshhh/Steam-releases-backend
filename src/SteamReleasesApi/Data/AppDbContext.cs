using Microsoft.EntityFrameworkCore;
using SteamReleasesApi.Models;

namespace SteamReleasesApi.Data;

public class AppDbContext : DbContext
{
    public DbSet<Game> Games { get; set; } = null!;

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Game>()
            .Property(g => g.Genres)
            .HasConversion(v => string.Join(',', v), v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList());

        modelBuilder.Entity<Game>()
            .Property(g => g.Platforms)
            .HasConversion(v => string.Join(',', v), v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList());
    }
}