using dgtestback.Models;
using Microsoft.EntityFrameworkCore;

namespace dgtestback.Data
{
    public class DGDBContext: DbContext
    {
        public DGDBContext (DbContextOptions<DGDBContext> options)
            : base(options)
            { }
        public DbSet<ClientProject> ClientProjects { get; set; }
        public DbSet<ProjectStatus> ProjectStatuses { get; set; }
    }
}
