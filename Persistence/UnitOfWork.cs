using System.Threading.Tasks;
using SkeletonDotNetCore.WebAPI.Core;

namespace SkeletonDotNetCore.WebAPI.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}