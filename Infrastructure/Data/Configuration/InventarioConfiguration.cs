using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
    {
        public void Configure(EntityTypeBuilder<Inventario> builder)
        {
            builder.ToTable("Inventario");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id");
            builder.HasIndex(x => x.CodInv).IsUnique();

            builder.Property(x => x.CodInv).IsRequired();
            builder.Property(x => x.IdPrenda).IsRequired();
            builder.Property(x => x.ValorVtaCop).IsRequired();
            builder.Property(x => x.ValorVtaUsd).IsRequired();

            builder.HasOne(I => I.Prenda)
            .WithMany(P => P.Inventarios)
            .HasForeignKey(I => I.IdPrenda);

        }
    }
}