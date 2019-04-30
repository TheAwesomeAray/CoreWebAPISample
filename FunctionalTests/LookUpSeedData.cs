using Jets.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalTests
{
    public class LookUpSeedData
    {
        public List<LookUpDto> JetsLookUps { get; }

        public LookUpSeedData()
        {
            JetsLookUps = new List<LookUpDto>()
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
