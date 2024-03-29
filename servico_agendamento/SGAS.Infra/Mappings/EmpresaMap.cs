using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGAS.Domain.Entity;

namespace SGAS.Infra.Mappings
{
    public class EmpresaMap : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("EMPRESA");

            builder.Property(x => x.Id).HasColumnName("EMPR_ID");

            builder.HasKey(x => x.Id).HasName("PK_EMPR");

            builder.Property(x => x.CNPJ).HasColumnName("EMPR_CNPJ");

            builder.Property(x => x.NomeFantasia).HasColumnName("EMPR_NOME_FANTASIA");

            builder.Property(x => x.RazaoSocial).HasColumnName("EMPR_RAZAO_SOCIAL");

            builder.Property(x => x.IdPessoa).HasColumnName("EMPR_ID_PESSOA");

            builder.HasOne(x => x.Pessoa)
                    .WithOne(x => x.Empresa)
                    .HasForeignKey<Empresa>(x => x.IdPessoa);

            builder.HasMany(x => x.UnidadeVendas)
                .WithOne(x => x.Empresa)
                .HasForeignKey(f => f.IdEmpresa);

            builder.Ignore(x => x.Pessoa);
            builder.Ignore(x => x.UnidadeVendas);

        }
    }
}
