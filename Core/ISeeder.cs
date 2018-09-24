using System.Threading.Tasks;

namespace SkeletonDotNetCore.WebAPI.Core
{
    public interface ISeeder
    {
        Task DevelopmentSeed();
        Task ProductionSeed();
    }
}