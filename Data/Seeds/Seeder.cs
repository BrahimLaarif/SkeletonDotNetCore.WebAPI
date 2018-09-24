using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SkeletonDotNetCore.WebAPI.Data.Repositories;
using SkeletonDotNetCore.WebAPI.Models;

namespace SkeletonDotNetCore.WebAPI.Data.Seeds
{
    public class Seeder : ISeeder
    {
        private readonly IValueRepository _valueRepository;
        private readonly IUnitOfWork _unitOfWork;

        public Seeder(IValueRepository valueRepository, IUnitOfWork unitOfWork)
        {
            _valueRepository = valueRepository;
            _unitOfWork = unitOfWork;
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
            if (await _valueRepository.CountValues() == 0)
            {
                var valuesJsonData = System.IO.File.ReadAllText("Data/Seeds/MockData/ValueData.json");

                var values = JsonConvert.DeserializeObject<List<Value>>(valuesJsonData);

                _valueRepository.AddRange(values);
                await _unitOfWork.CompleteAsync();
            }
        }
    }
}