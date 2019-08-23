using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteWebMotors.Domain.Entities;

namespace TesteWebMotors.Api.Models.Map
{
    public class AdMap
    {
        public AdMap(EntityTypeBuilder<Ad> entityAd)
        {
            
            entityAd.HasKey(t => t.ID);
            entityAd.Property(t => t.Make).IsRequired();
            entityAd.Property(t => t.Model).IsRequired();
            entityAd.Property(t => t.Version).IsRequired();
            entityAd.Property(t => t.Year).IsRequired();
            entityAd.Property(t => t.Km).IsRequired();
            entityAd.Property(t => t.Obs).IsRequired();
        }
    }
}
