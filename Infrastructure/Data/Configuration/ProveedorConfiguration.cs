using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.NitProveedor).IsUnique();
            builder.Property(x => x.Nombre).IsRequired();


            builder.HasOne(P => P.TipoPersona)
            .WithMany(T => T.Proveedores)
            .HasForeignKey(P => P.IdTipoPersona);
        }
    }
}