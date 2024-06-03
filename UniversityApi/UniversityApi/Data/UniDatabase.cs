using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace UniversityApi.Data
{
    public class UniDatabase : DbContext
    {
        public UniDatabase(DbContextOptions<UniDatabase> options) : base(options)
        {

        }

        public DbSet<Group> Groups { get; set; }
    }
}
