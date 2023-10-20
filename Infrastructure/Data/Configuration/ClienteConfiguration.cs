using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.IdCliente).IsUnique();
            builder.Property(x => x.Nombre);
            builder.Property(x => x.FechaRegistro);

            builder.HasOne(C => C.Municipio)
                        .WithMany(M => M.Clientes)
                        .HasForeignKey(C => C.IdMunicipio);

            builder.HasOne(C => C.TipoPersona)
                        .WithMany(M => M.Clientes)
                        .HasForeignKey(C => C.IdTipoPersona);

        }
    }
}