using HotelListing.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace HotelListing.Configurations.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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
