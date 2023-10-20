using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InsumoProveedorConfiguration : IEntityTypeConfiguration<InsumoProveedor>
    {
        public void Configure(EntityTypeBuilder<InsumoProveedor> builder)
        {
            builder.ToTable("InsumoProveedor");
            builder.HasKey(t => new { t.Id, t.IdInsumo });
            builder.HasKey(t => new { t.Id, t.IdProveedor });

            builder.HasOne(I => I.Proveedor)
            .WithMany(P => P.InsumoProveedores)
            .HasForeignKey(I => I.IdProveedor);
        }
    }
}