using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace GymTracker.Backend.Data;

public class TrackerDbContext(DbContextOptions options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}