using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.ToTable("Empleado");

            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.IdEmp).IsUnique();

            builder.HasOne(E => E.Cargo)
            .WithMany(C => C.Empleados)
            .HasForeignKey(E => E.IdCargo);

            builder.HasOne(E => E.Municipio)
            .WithMany(C => C.Empleados)
            .HasForeignKey(E => E.IdMunicipio);
        }
    }
}