using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGAS.Domain.Entity;

namespace SGAS.Infra.Mappings
{
    public class CidadeMap : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.ToTable("CIDADE");

           // builder.HasNoKey();

            builder.Property(x => x.Id).HasColumnName("CIDA_ID");

            builder.Property(x => x.Nome).HasColumnName("CIDA_NOME");

            builder.Property(x => x.IdMicroRegiao).HasColumnName("CIDA_ID_MICROREGIAO");

            builder.Property(x => x.IdEstado).HasColumnName("CIDA_ID_ESTADO");


            //builder.Ignore(x => x.IdEstado);
            builder.Ignore(x => x.Cep);
            builder.Ignore(x => x.MicrorRegiao);
            builder.Ignore(x => x.Endereco);
        }
    }
}
