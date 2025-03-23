using ColorPalette.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ColorPalette.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    //DbSet
    public DbSet<Palette> Palettes { get; set; }
    public DbSet<Color> Colors { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Palette>()
            .HasKey(p => p.Id);
        
        modelBuilder.Entity<Color>()
            .HasKey(c => c.Id);

        modelBuilder.Entity<Color>()
            .HasOne(c => c.Palettes)
            .WithMany(p => p.Colors)
            .HasForeignKey(c => c.PaletteId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}