using Microsoft.EntityFrameworkCore;
using practice_prototype.Models;

namespace practice_prototype.Data;

public class DataContext : DbContext
{

    public DbSet<Movie> Movies { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Hall> Halls { get; set; }
    public DbSet<Screening> Screenings { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer();
    }
}
