using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Infra.Mappings
{
    public class MotivoMap : IEntityTypeConfiguration<Motivo>
    {
        public void Configure(EntityTypeBuilder<Motivo> builder)
        {
            builder.ToTable("MOTIVO");

            builder.Property(x => x.Id).HasColumnName("MOTI_ID");

            builder.HasKey(x => x.Id).HasName("PK_MOTI");

            builder.Property(x => x.Descricao).HasColumnName("MOTI_DESCRICAO");

            builder.Ignore(x => x.Agenda);

        }
    }
}
