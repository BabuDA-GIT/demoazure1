using demoazure1.Models;
using Microsoft.EntityFrameworkCore;

namespace demoazure1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<LeadEntity> Leads { get; set; }

    }
}
