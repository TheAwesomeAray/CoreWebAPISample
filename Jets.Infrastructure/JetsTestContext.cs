using Jets.Dto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("FunctionalTests")]
namespace Jets.Infrastructure
{
    public class JetsTestContext : DbContext, IJetsDataAccess
    {
        public JetsTestContext(DbContextOptions<JetsTestContext> options) : base(options)
        {
        }

        internal DbSet<LookUpDto> JetsLookUps { get; set; }

        public LookUpDto GetLookUp(int id)
        {
            return JetsLookUps.Single(x => x.Id == id);
        }

        public IEnumerable<LookUpDto> GetLookUps()
        {
            return JetsLookUps;
        }
    }
}
