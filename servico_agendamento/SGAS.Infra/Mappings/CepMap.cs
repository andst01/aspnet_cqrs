using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Infra.Mappings
{
    public class CepMap : IEntityTypeConfiguration<Cep>
    {
        public void Configure(EntityTypeBuilder<Cep> builder)
        {
            builder.ToTable("CEP");

            builder.Property(x => x.Id).HasColumnName("CEP_ID");

            builder.HasKey(x => x.Id).HasName("PK_CEP");

            builder.Property(x => x.Ibge).HasColumnName("CEP_IBGE");

            builder.Property(x => x.Bairro).HasColumnName("CEP_BAIRRO");

            builder.Property(x => x.Complemento).HasColumnName("CEP_COMPLEMENTO");

            builder.Property(x => x.EhCadastroSistema).HasColumnName("CEP_POSSUI_CADASTRO");

            builder.Property(x => x.Localidade).HasColumnName("CEP_LOCALIDADE");

            builder.Property(x => x.Logradouro).HasColumnName("CEP_LOGRADOURO");

            builder.Property(x => x.NumeroCep).HasColumnName("CEP_NUMERO");

            builder.Property(x => x.Uf).HasColumnName("CEP_UF");

            builder.Property(x => x.IdCidade).HasColumnName("CEP_ID_CIDADE");

            //builder.HasOne(x => x.Cidade)
            //       .WithMany(x => x.Cep)
            //       .HasForeignKey(x => x.IdCidade);

            builder.Ignore(x => x.Cidade);
        }
    }
}
