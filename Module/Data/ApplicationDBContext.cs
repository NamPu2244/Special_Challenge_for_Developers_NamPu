//using Esprima;
using Microsoft.EntityFrameworkCore;
using Module.Models;
//using OrchardCore.Workflows.Activities;

namespace Module.Data
{
    public class ApplicationDBContext : DbContext
    {
        public  ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<LocationRest> LocationRests { get; set; }
        public DbSet<LocationTravel> LocationTravels { get; set; }
        public DbSet<ActivityChaeson> ActivityChaesons { get; set; }

    }
}
