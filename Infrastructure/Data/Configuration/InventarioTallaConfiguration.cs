using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InventarioTallaConfiguration : IEntityTypeConfiguration<InventarioTalla>
    {
        public void Configure(EntityTypeBuilder<InventarioTalla> builder)
        {
            builder.ToTable("InventarioTalla");

            builder.HasKey(x => new { x.Id, x.IdInv });
            builder.Property(x => x.cantidad);

            builder.HasOne(IT => IT.Inventario)
            .WithMany(I => I.InventarioTallas)
            .HasForeignKey(IT => IT.IdInv);

            builder.HasOne(IT => IT.Talla)
            .WithMany(I => I.InventarioTallas)
            .HasForeignKey(IT => IT.IdTalla);
        }
    }
}