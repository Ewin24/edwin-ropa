using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class OrdenConfiguration : IEntityTypeConfiguration<Orden>
    {
        public void Configure(EntityTypeBuilder<Orden> builder)
        {
            builder.ToTable("Orden");
            builder.HasKey(x => x.IdOrden);
            builder.Property(x => x.Fecha);

            builder.HasOne(D => D.Cliente)
            .WithMany(C => C.Ordenes)
            .HasForeignKey(D => D.IdCliente);

            builder.HasOne(D => D.Empleado)
            .WithMany(C => C.Ordenes)
            .HasForeignKey(D => D.IdEmpleado);

            builder.HasOne(D => D.Estado)
            .WithMany(C => C.Ordenes)
            .HasForeignKey(D => D.IdEstado);
        }
    }
}