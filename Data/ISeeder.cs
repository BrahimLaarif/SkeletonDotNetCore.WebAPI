using System.Threading.Tasks;

namespace SkeletonDotNetCore.WebAPI.Data
{
    public interface ISeeder
    {
        Task DevelopmentSeed();
        Task ProductionSeed();
    }
}