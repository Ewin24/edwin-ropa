using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class MunicipioConfiguration : IEntityTypeConfiguration<Municipio>
    {
        public void Configure(EntityTypeBuilder<Municipio> builder)
        {
            builder.ToTable("Municipio");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nombre);


            builder.HasOne(M => M.Departamento)
            .WithMany(D => D.Municipios)
            .HasForeignKey(M => M.IdDep);
        }
    }
}