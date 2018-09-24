using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SkeletonDotNetCore.WebAPI.Models;

namespace SkeletonDotNetCore.WebAPI.Data
{
    public class ValueRepository : IValueRepository
    {
        private readonly DatabaseContext _context;

        public ValueRepository(DatabaseContext context)
        {
            _context = context;
        }

        public void Add(Value value)
        {
            _context.Values.Add(value);
        }

        public void AddRange(IEnumerable<Value> values)
        {
            _context.Values.AddRange(values);
        }

        public void Update(Value value)
        {
            _context.Values.Update(value);
        }

        public void Remove(Value value)
        {
            _context.Values.Remove(value);
        }

        public async Task<int> CountValues()
        {
            return await _context.Values.CountAsync();
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