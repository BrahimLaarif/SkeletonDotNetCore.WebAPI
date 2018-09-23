using Microsoft.EntityFrameworkCore;

namespace SkeletonDotNetCore.WebAPI.Data
{
    public class SkeletonDbContext : DbContext
    {
        public SkeletonDbContext(DbContextOptions<SkeletonDbContext> options)
            : base(options)
        {
        }
    }
}