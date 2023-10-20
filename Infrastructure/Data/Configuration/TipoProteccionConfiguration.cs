using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class TipoProteccionConfiguration : IEntityTypeConfiguration<TipoProduccion>
    {
        public void Configure(EntityTypeBuilder<TipoProduccion> builder)
        {
            builder.ToTable("TipoProteccion");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Descripcion);
        }
    }
}