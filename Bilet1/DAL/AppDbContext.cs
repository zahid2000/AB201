using Bilet1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bilet1.DAL;

public class AppDbContext:IdentityDbContext<IdentityUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> opt):base(opt){}
    public DbSet<Post> Posts{ get; set; }
}
