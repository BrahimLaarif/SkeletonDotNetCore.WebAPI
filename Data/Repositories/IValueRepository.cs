using System.Collections.Generic;
using System.Threading.Tasks;
using SkeletonDotNetCore.WebAPI.Models;

namespace SkeletonDotNetCore.WebAPI.Data.Repositories
{
    public interface IValueRepository
    {
        void Add(Value value);
        void AddRange(IEnumerable<Value> values);
        void Update(Value value);
        void Remove(Value value);

        Task<int> CountValues();
        Task<List<Value>> GetValues();
        Task<Value> GetValue(int id);
    }
}