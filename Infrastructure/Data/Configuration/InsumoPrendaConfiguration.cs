using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InsumoPrendaConfiguration : IEntityTypeConfiguration<InsumoPrenda>
    {
        public void Configure(EntityTypeBuilder<InsumoPrenda> builder)
        {
            builder.ToTable("InsumoPrenda");
            //TODO: llave compuesta
            builder.HasKey(t => new { t.IdInsumo, t.IdPrenda });
            builder.HasKey(t => new { t.IdPrenda, t.IdInsumo });

            builder.HasOne(I => I.Insumo)
            .WithMany(P => P.InsumoPrendas)
            .HasForeignKey(I => I.IdInsumo);

            builder.HasOne(I => I.Prenda)
            .WithMany(P => P.InsumoPrendas)
            .HasForeignKey(I => I.IdPrenda);
        }
    }
}