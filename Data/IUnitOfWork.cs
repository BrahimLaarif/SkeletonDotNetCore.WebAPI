using System.Threading.Tasks;

namespace SkeletonDotNetCore.WebAPI.Data
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}