using Microsoft.EntityFrameworkCore;

namespace EntertainmentAgencyolsenj8.Models
{
    public class AgencyDbContext : DbContext
    {
        public AgencyDbContext(DbContextOptions<AgencyDbContext> options) : base(options)
        {

        }

        public DbSet<Entertainer> Entertainers { get; set; }
    }
}
