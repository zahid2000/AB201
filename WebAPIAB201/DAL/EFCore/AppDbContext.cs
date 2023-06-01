using Microsoft.EntityFrameworkCore;
using WebAPIAB201.Entities;

namespace WebAPIAB201.DAL.EFCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
    public DbSet<Book> Books { get; set; }
}
