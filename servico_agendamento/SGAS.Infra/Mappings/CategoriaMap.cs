using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Infra.Mappings
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("CATEGORIA");

            builder.Property(x => x.Id).HasColumnName("CATE_ID");

            builder.HasKey(x => x.Id).HasName("PK_CATE");

            builder.Property(x => x.Descricao).HasColumnName("CATE_DESCRICAO");

            builder.HasMany(x => x.Produto)
                .WithOne(x => x.Categoria)
                .HasForeignKey(x => x.IdCategoria);

            builder.Ignore(x => x.Produto);


        }
    }
}
