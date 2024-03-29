using SGAS.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SGAS.Infra.Mappings
{
    public class HistoricoEventoMap : IEntityTypeConfiguration<HistoricoEvento>
    {
        public void Configure(EntityTypeBuilder<HistoricoEvento> builder)
        {
            builder.ToTable("HISTORICO_EVENTO");

            builder.Property(x => x.Id).HasColumnName("HSTE_ID");

            builder.HasKey(x => x.Id).HasName("PK_HSTE");

            builder.Property(c => c.Codigo).HasColumnName("HSTE_CODIGO");

            builder.Property(x => x.NomeTabela).HasColumnName("HSTE_NOMETABELA");

            builder.Property(c => c.DataCadastro).HasColumnName("HSTE_DT_DATA_CADASTRO");
           
           // builder.Property(c => c.TipoMensagem).HasColumnName("HSTE_STR_TIPO_MENSAGEM");

            builder.Property(c => c.ValoresNovos).HasColumnName("HSTE_DADOS_NOVOS");

            builder.Property(c => c.ValoresAntigos).HasColumnName("HSTE_DADOS_ANTIGOS");

          //  builder.Property(c => c.CodigoMensagem).HasColumnName("HSTE_COD_MENSAGEM");

           // builder.Property(c => c.TipoMensagem).HasColumnName("HSTE_TP_MENSAGEM");

            builder.Property(x => x.CodigoUsuario).HasColumnName("HSTE_COD_USUARIO");

            builder.Property(x => x.ValoresChaves).HasColumnName("HSTE_PK");

            builder.Property(x => x.TipoOperacao).HasColumnName("HSTE_TP_OPERACAO");

            builder.Ignore(x => x._Id);

        }
    }
}
