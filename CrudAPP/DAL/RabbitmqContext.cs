using CrudAPP.BO;
using Microsoft.EntityFrameworkCore;

namespace CrudAPP.DAL
{
    public class RabbitmqContext : DbContext
    {
        public RabbitmqContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Cameroun",
                    ShortName = "CM"

                },
                new Country
                {
                     Id = 2,
                     Name = "France",
                     ShortName = "FR"

                },
                new Country
                {
                     Id = 3,
                     Name = "Belgique",
                     ShortName = "BL"

                }
          );
            builder.Entity<Hotel>().HasData(
               new Hotel
               {
                   Id = 1,
                   Name = "Black & White",
                   Adress = "Bastos Yaounde",
                   Rating = 3,
                   CountryId = 1

               },
               new Hotel
               {
                   Id = 2,
                   Name = "Continental hotel",
                   Adress = "Rue Jean France",
                   Rating = 4,
                   CountryId = 3

               },
               new Hotel
               {
                   Id = 3,
                   Name = "Blender Palace",
                   Adress = "405 Boulevar de la paix",
                   Rating = 4.5,
                   CountryId = 2

               }
         );
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

    }
}
