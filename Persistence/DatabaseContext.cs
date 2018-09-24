using Microsoft.EntityFrameworkCore;
using SkeletonDotNetCore.WebAPI.Core.Models;

namespace SkeletonDotNetCore.WebAPI.Persistence
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Value> Values { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}