using Jets.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using Jets.Infrastructure;
using System.Threading.Tasks;
using System.Linq;

namespace FunctionalTests
{
    public class LookUpSeedData
    {
        public List<LookUpDto> JetsLookUps { get; }

        public LookUpSeedData()
        {
            
        }

        internal static async Task SeedAsync(JetsTestContext jetsContext)
        {
            if (!jetsContext.JetsLookUps.Any())
            {
                jetsContext.AddRange(GetPreconfiguredJetsLookUps());
                await jetsContext.SaveChangesAsync();
            }
        }

        static IEnumerable<LookUpDto> GetPreconfiguredJetsLookUps()
        {
            return new List<LookUpDto>()
            {
                new LookUpDto()
                {
                    Id = 1,
                    LookUpValue = "Value 1"
                },
                new LookUpDto()
                {
                    Id = 2,
                    LookUpValue = "Value 2"
                },
                new LookUpDto()
                {
                    Id = 3,
                    LookUpValue = "Value 3"
                },
            };
        }
    }
}
