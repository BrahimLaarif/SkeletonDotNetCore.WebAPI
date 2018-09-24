using System.Threading.Tasks;

namespace SkeletonDotNetCore.WebAPI.Core
{
    public interface ISeeder
    {
        void DevelopmentSeed();
        void ProductionSeed();
    }
}