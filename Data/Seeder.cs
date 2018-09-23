using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SkeletonDotNetCore.WebAPI.Models;

namespace SkeletonDotNetCore.WebAPI.Data
{
    public class Seeder : ISeeder
    {
        private readonly ISkeletonRepository _repo;

        public Seeder(ISkeletonRepository repo)
        {
            _repo = repo;
        }

        public async Task DevelopmentSeed()
        {
            await AddMockValues();
        }

        public async Task ProductionSeed()
        {
            await Task.CompletedTask;
        }

        private async Task AddMockValues()
        {
            if (await _repo.CountValues() == 0)
            {
                var valuesJsonData = System.IO.File.ReadAllText("Data/MockData/ValueData.json");

                var values = JsonConvert.DeserializeObject<List<Value>>(valuesJsonData);

                _repo.AddRange(values);
                await _repo.SaveAll();
            }
        }
    }
}