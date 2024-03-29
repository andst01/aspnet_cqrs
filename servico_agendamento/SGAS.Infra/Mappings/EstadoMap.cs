using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGAS.Domain.Entity;

namespace SGAS.Infra.Mappings
{
    public class EstadoMap : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.ToTable("ESTADO");

            //builder.HasNoKey();

            builder.Property(x => x.Id).HasColumnName("EST_ID");

           // builder.HasKey(x => x.Id);

            builder.Property(x => x.IdRegiao).HasColumnName("EST_ID_REGIAO");

            builder.Property(x => x.Nome).HasColumnName("EST_NOME");

            builder.Property(x => x.Sigla).HasColumnName("EST_SIGLA");

            //builder.HasOne(x => x.Regiao)
            //       .WithMany(x => x.Estados)
            //       .HasForeignKey(f => f.IdRegiao);

            builder.Ignore(x => x.Cidade);
            builder.Ignore(x => x.MesoRegiao);
            builder.Ignore(x => x.Regiao);
        }
    }
}
