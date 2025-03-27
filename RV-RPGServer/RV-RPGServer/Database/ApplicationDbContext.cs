using Microsoft.EntityFrameworkCore;
using RV_RPGServer.Entities;

namespace RV_RPGServer.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
                
        }
        
        public DbSet<Character> Characters { get; set; }
    }
}