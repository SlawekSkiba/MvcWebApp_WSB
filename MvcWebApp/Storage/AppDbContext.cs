using Microsoft.EntityFrameworkCore;
using MvcWebApp.Storage.Models;

namespace MvcWebApp.Storage;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }

}
