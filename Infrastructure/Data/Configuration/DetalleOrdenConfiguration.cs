using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class DetalleOrdenConfiguration : IEntityTypeConfiguration<DetalleOrden>
    {
        public void Configure(EntityTypeBuilder<DetalleOrden> builder)
        {
            builder.ToTable("DetalleOrden");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CantidadProducir);
            builder.Property(x => x.CantidadProducida);

            builder.HasOne(D => D.Color)
            .WithMany(C => C.DetalleOrdenes)
            .HasForeignKey(D => D.IdColor);

            builder.HasOne(D => D.Prenda)
            .WithMany(C => C.DetalleOrdenes)
            .HasForeignKey(D => D.IdPrenda);

            builder.HasOne(D => D.Orden)
            .WithMany(C => C.DetalleOrdenes)
            .HasForeignKey(D => D.IdOrden);
        }
    }
}