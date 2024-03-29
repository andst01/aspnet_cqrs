using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Infra.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("PRODUTO");

            builder.Property(x => x.Id).HasColumnName("PROD_ID");

            builder.HasKey(x => x.Id).HasName("PK_PROD");

            builder.Property(x => x.Preco).HasColumnName("PROD_PRECO");

            builder.Property(x => x.Ativo).HasColumnName("PROD_ATIVO");

            builder.Property(x => x.Descricao).HasColumnName("PROD_DESCRICAO");

            builder.Property(x => x.IdCategoria).HasColumnName("PROD_ID_CATEGORIA");

            builder.Property(x => x.DataCadastro).HasColumnName("PROD_DATA_CADASTRO");

            builder.Property(x => x.DataAtualizacao).HasColumnName("PROD_DATA_ATUALIZACAO");

            

            builder.Ignore(x => x.ItemVendas);
            builder.Ignore(x => x.Categoria);
        }
    }
}
