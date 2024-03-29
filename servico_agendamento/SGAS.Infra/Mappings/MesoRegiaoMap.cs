using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Infra.Mappings
{
    public class MesoRegiaoMap : IEntityTypeConfiguration<MesoRegiao>
    {
        public void Configure(EntityTypeBuilder<MesoRegiao> builder)
        {
            builder.ToTable("MESO_REGIAO");

            //builder.HasNoKey();

            builder.Property(x => x.Id).HasColumnName("MSRG_ID");

            //builder.HasKey(t => t.Id);

            builder.Property(x => x.IdEstado).HasColumnName("MSRG_ID_ESTADO");

            //builder.HasOne(x => x.Uf)
            //       .WithMany(x => x.MesoRegiao)
            //       .HasForeignKey(x => x.IdEstado);

            builder.Property(x => x.Nome).HasColumnName("MSRG_NOME");

            builder.Ignore(x => x.Uf);
            builder.Ignore(x => x.MicroRegiao);

        }
    }
}
