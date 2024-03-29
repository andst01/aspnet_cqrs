using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Infra.Mappings
{
    public class MicroRegiaoMap : IEntityTypeConfiguration<MicroRegiao>
    {
        public void Configure(EntityTypeBuilder<MicroRegiao> builder)
        {
            builder.ToTable("MICRO_REGIAO");

          //  builder.HasNoKey();

            builder.Property(x => x.Id).HasColumnName("MCRG_ID");

          //  builder.HasKey(x => x.Id);

            builder.Property(x => x.IdMesoRegiao).HasColumnName("MCRG_ID_MESO_REGIAO");

            builder.Property(x => x.Nome).HasColumnName("MCRG_NOME");

            builder.Ignore(x => x.MesorRegiao);
            builder.Ignore(x => x.Cidade);
        }
    }
}
