using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Infra.Mappings
{
    public class RegiaoMap : IEntityTypeConfiguration<Regiao>
    {
        public void Configure(EntityTypeBuilder<Regiao> builder)
        {
            builder.ToTable("REGIAO");

            //builder.HasNoKey();

            builder.Property(x => x.Id).HasColumnName("REGI_ID");

           //  builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).HasColumnName("REGI_NOME");

            builder.Property(x => x.Sigla).HasColumnName("REGI_SIGLA");

            builder.Ignore(x => x.Estados);
           
        }
    }
}
