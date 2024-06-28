using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        } 

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Turkey",
                    ShortName = "TR"
                },
                new Country
                {
                    Id = 2,
                    Name = "Germany",
                    ShortName = "DE"
                },
                new Country
                {
                    Id = 3,
                    Name = "Greece",
                    ShortName = "GR"
                }
                );

            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Pam Thermal Hotel",
                    Address = "Karahayıt, 120. Sağlık Sk No:5/1, 20190 Pamukkale/Denizli",
                    CountryId = 1,
                    Rating = 5

                },
                new Hotel
                {
                    Id = 2,
                    Name = "Leonardo Hotel Berlin KU´DAMM",
                    Address = "Kurfürstendamm 35, 10719 Berlin, Germany",
                    CountryId = 2,
                    Rating = 3.8,

                },
                new Hotel
                {
                    Id = 3,
                    Name = "Giustiniani Apartments",
                    Address = "Ermofantou, Chios 821 00, Greece",
                    CountryId = 3,
                    Rating = 4.9
                }
                );
        }


    }
}
