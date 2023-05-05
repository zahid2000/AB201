using AdoNet_EfCore.Constants;
using AdoNet_EfCore.Models;
using Microsoft.EntityFrameworkCore;

namespace AdoNet_EfCore.DAL;

public class AppDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(Urls.connectionStringCodeFirst);
        base.OnConfiguring(optionsBuilder);
    }

 
}
