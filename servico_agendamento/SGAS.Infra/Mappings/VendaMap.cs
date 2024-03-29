using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGAS.Domain.Entity;

namespace SGAS.Infra.Mappings
{
    public class VendaMap : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder.ToTable("VENDA");

            builder.Property(x => x.Id).HasColumnName("VEND_ID");

            builder.HasKey(x => x.Id).HasName("PK_VEND");

            builder.Property(x => x.IdCliente).HasColumnName("VEND_ID_CLIENTE");

            builder.Property(x => x.Desconto).HasColumnName("VEND_DESCONTO");

            builder.Property(x => x.IdUnidadeVenda).HasColumnName("VEND_ID_UNIDADE_VENDA");

            builder.Property(x => x.IdFuncionario).HasColumnName("VEND_ID_FUNCIONARIO");

            builder.Property(x => x.Valor).HasColumnName("VEND_VALOR");

           

            builder.Ignore(x => x.UnidadeVenda);
            builder.Ignore(x => x.Cliente);
            builder.Ignore(x => x.Funcionario);
            builder.Ignore(x => x.ItemVenda);
        }
    }
}
