using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Infra.Mappings
{
    public class ItemVendaMap : IEntityTypeConfiguration<ItemVenda>
    {
        public void Configure(EntityTypeBuilder<ItemVenda> builder)
        {
            builder.ToTable("ITEM_VENDA");

            builder.Property(x => x.Id).HasColumnName("ITVD_ID");

            builder.HasKey(x => x.Id).HasName("PK_ITVD");

            builder.Property(x => x.IdVenda).HasColumnName("ITVD_ID_VENDA");

           

            builder.Property(x => x.Quantidade).HasColumnName("ITVD_QUANTIDADE");

            builder.Property(x => x.DataAtualizacao).HasColumnName("ITVD_DATA_ATUALIZACAO");

            builder.Property(x => x.DataCadastro).HasColumnName("ITVD_DATA_CADASTRO");

            builder.Property(x => x.Desconto).HasColumnName("ITVD_DESCONTO");

            builder.Property(x => x.IdProduto).HasColumnName("ITVD_ID_PRODUTO");

            builder.Property(x => x.ValorTotal).HasColumnName("ITVD_VALOR_TOTAL");

            builder.Property(x => x.ValorUnitario).HasColumnName("ITVD_VALOR_UNITARIO");

            builder.HasOne(x => x.Produto)
                .WithMany(x => x.ItemVendas)
                .HasForeignKey(f => f.IdProduto);

            builder.HasOne(x => x.Venda)
               .WithMany(v => v.ItemVenda)
               .HasForeignKey(f => f.IdVenda);


            builder.Ignore(x => x.Produto);
            builder.Ignore(x => x.Venda);

            
        }
    }
}
