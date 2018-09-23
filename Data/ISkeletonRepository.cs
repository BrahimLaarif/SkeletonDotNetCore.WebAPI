using System.Collections.Generic;
using System.Threading.Tasks;
using SkeletonDotNetCore.WebAPI.Models;

namespace SkeletonDotNetCore.WebAPI.Data
{
    public interface ISkeletonRepository
    {
        void Add<T>(T entity) where T: class;
        void Update<T>(T entity) where T: class;
        void Remove<T>(T entity) where T: class;
        Task<bool> SaveAll();
        Task<List<Value>> GetValues();
        Task<Value> GetValue(int id);
    }
}