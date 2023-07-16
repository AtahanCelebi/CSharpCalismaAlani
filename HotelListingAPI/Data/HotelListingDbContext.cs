using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HotelListingAPI.VSCode.Data
{
    public class HotelListingDbContext: DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id=1,
                    Name = "Jamaica",
                    ShortName = "JM"
                },
                new Country
                {
                    Id=2,
                    Name = "Bahamas",
                    ShortName = "BS"
                },new Country
                {
                    Id=3,
                    Name = "Turkey",
                    ShortName = "TR"
                }

            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id=1,
                    Name = "Sandals Resort and Spa",
                    Address = "Negril",
                    CountryId = 1,
                    Rating = 4.5
                },
                 new Hotel
                {
                    Id=2,
                    Name = "Comfort Suits",
                    Address = "George TOWN",
                    CountryId = 3,
                    Rating = 4.3
                },
                 new Hotel
                {
                    Id=3,
                    Name = "Ankara Otel",
                    Address = "Ankara",
                    CountryId = 2,
                    Rating = 4
                }
            );
        }

    }
    
}