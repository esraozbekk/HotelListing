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
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
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
        }
    }
}
