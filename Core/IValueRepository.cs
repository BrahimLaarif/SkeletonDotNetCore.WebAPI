using System.Collections.Generic;
using System.Threading.Tasks;
using SkeletonDotNetCore.WebAPI.Core.Models;

namespace SkeletonDotNetCore.WebAPI.Core
{
    public interface IValueRepository
    {
        void Add(Value value);
        void Update(Value value);
        void Remove(Value value);

        Task<List<Value>> GetValues();
        Task<Value> GetValue(int id);
    }
}