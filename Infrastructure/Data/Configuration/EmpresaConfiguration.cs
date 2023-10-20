using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("Empresa");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.RazonSocial);
            builder.Property(x => x.RepresentanteLegal);
            builder.Property(x => x.FechaCreacion);

            builder.HasOne(E => E.Municipio)
            .WithMany(M => M.Empresas)
            .HasForeignKey(E => E.IdMun);
        }
    }
}