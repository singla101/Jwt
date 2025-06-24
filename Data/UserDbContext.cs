using JwtAuthDotNet9_New.Entities;
using Microsoft.EntityFrameworkCore;    
namespace JwtAuthDotNet9_New.Data
{
    public class UserDbContext(DbContextOptions<UserDbContext> options) : DbContext(options)
    {
        public DbSet<User> users { get; set; }
    }
}
