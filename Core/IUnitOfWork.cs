using System.Threading.Tasks;

namespace SkeletonDotNetCore.WebAPI.Core
{
    public interface IUnitOfWork
    {
        Task<int> CompleteAsync();
    }
}