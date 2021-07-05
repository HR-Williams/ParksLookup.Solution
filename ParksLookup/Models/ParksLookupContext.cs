using Microsoft.EntityFrameworkCore;

namespace ParksLookup.Models
{
    public class ParksLookupContext : DbContext
    {
        public ParksLookupContext(DbContextOptions<ParksLookupContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Park>()
            .HasData(
                new Park { ParkId = 3, Name="Alfred A. Loeb", Type = "state", Location ="Near Brookings, Oregon, United States", IndigenousLand = "Chit-dee-ni (Chetco) and Tolowa Dee-ni’"},
                new Park { ParkId = 4, Name="Bates State Park", Type = "state", Location ="Near John Day, Oregon, United States", IndigenousLand = "Cayuse, Umatilla and Walla Walla, Confederated Tribes of Warm Springs"},
                new Park { ParkId = 5, Name="Acadia", Type = "national", Location ="Maine", IndigenousLand = "Abenaki / Abénaquis, Penobscot, and Wabanaki Confederacy"},
                new Park { ParkId = 6, Name="Arches", Type = "national", Location ="Utah", IndigenousLand = "Núu-agha-tʉvʉ-pʉ̱ (Ute)"},
                new Park { ParkId = 7, Name="Badlands", Type = "national", Location ="South Dakota", IndigenousLand = "Cheyenne, Mnicoujou, Očhéthi Šakówiŋ"}
            );
        }

        public DbSet<Park> Parks { get; set; }
    }
}