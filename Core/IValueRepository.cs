using System.Collections.Generic;
using System.Threading.Tasks;
using SkeletonDotNetCore.WebAPI.Core.Models;

namespace SkeletonDotNetCore.WebAPI.Core
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