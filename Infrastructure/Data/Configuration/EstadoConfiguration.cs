using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class EstadoConfiguration : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.ToTable("Estado");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Descripcion);

            builder.HasOne(E => E.TipoEstado)
            .WithMany(P => P.Estados)
            .HasForeignKey(E => E.IdTipoEstado);
        }
    }
}