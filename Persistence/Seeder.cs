using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SkeletonDotNetCore.WebAPI.Core;
using SkeletonDotNetCore.WebAPI.Core.Models;

namespace SkeletonDotNetCore.WebAPI.Persistence
{
    public class Seeder : ISeeder
    {
        private readonly DatabaseContext _context;

        public Seeder(DatabaseContext context)
        {
            _context = context;
        }

        public void DevelopmentSeed()
        {
            AddMockValues();
        }

        public void ProductionSeed()
        {
        }

        private void AddMockValues()
        {
            if (!_context.Values.Any())
            {
                var valuesJsonData = System.IO.File.ReadAllText("Persistence/MockData/ValueData.json");

                var values = JsonConvert.DeserializeObject<List<Value>>(valuesJsonData);

                _context.Values.AddRange(values);
                _context.SaveChanges();
            }
        }
    }
}