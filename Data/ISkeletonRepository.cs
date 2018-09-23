using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SkeletonDotNetCore.WebAPI.Models;

namespace SkeletonDotNetCore.WebAPI.Data
{
    public interface ISkeletonRepository
    {
        void Add<T>(T entity) where T: class;
        void AddRange<T>(List<T> entities) where T: class;
        void Update<T>(T entity) where T: class;
        void Remove<T>(T entity) where T: class;
        Task<int> SaveAll();
        Task<int> CountValues();
        Task<List<Value>> GetValues();
        Task<Value> GetValue(int id);
    }
}