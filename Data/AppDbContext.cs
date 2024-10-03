using ManagerLabs.Models;
using Microsoft.EntityFrameworkCore;

namespace ManagerLabs.Data;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }


 
}
