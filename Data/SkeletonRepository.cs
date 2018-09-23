using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SkeletonDotNetCore.WebAPI.Models;

namespace SkeletonDotNetCore.WebAPI.Data
{
    public class SkeletonRepository : ISkeletonRepository
    {
        private readonly SkeletonDbContext _context;

        public SkeletonRepository(SkeletonDbContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Remove<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Value> GetValue(int id)
        {
            return await _context.Values.FindAsync(id);
        }

        public async Task<List<Value>> GetValues()
        {
            return await _context.Values.ToListAsync();
        }
    }
}