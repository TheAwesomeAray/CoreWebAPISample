using Jets.Dto;
using System.Collections.Generic;

namespace Jets.Infrastructure
{
    public interface IJetsDataAccess
    {
        LookUpDto GetLookUp(int id);

        IEnumerable<LookUpDto> GetLookUps();
    }
}
