using System.Threading.Tasks;

namespace SkeletonDotNetCore.WebAPI.Data.Seeds
{
    public interface ISeeder
    {
        Task DevelopmentSeed();
        Task ProductionSeed();
    }
}