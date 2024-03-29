using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Infra.Mappings
{
    public class ReservaMap : IEntityTypeConfiguration<Reserva>
    {
        public void Configure(EntityTypeBuilder<Reserva> builder)
        {
            builder.ToTable("RESERVA");

            builder.HasKey(x => x.Id).HasName("RESE_ID");

            builder.Property(x => x.IdCliente).HasColumnName("RESE_ID_CLIENTE");

            builder.Property(x => x.Status).HasColumnName("RESE_STATUS");

            builder.Property(x => x.DataCadastro).HasColumnName("RESE_DATA_ATUALIZACAO");

            builder.Property(x => x.DataAtualização).HasColumnName("RESE_DATA_ATUALIZACAO");

            builder.Property(x => x.IdFuncionario).HasColumnName("RESE_ID_FUNCIONARIO");

            builder.Property(x => x.IdUnidadeVenda).HasColumnName("RESE_ID_UNIDADE_VENDA");

            builder.HasOne(x => x.Cliente)
                   .WithMany(x => x.Reservas)
                   .HasForeignKey(x => x.IdCliente);

            builder.HasOne(x => x.Funcionario)
                   .WithMany(x => x.Reservas)
                   .HasForeignKey(x => x.IdFuncionario);

            builder.HasOne(x => x.UnidadeVenda)
                   .WithMany(x => x.Reservas)
                   .HasForeignKey(x => x.IdUnidadeVenda);
            // builder.Property(x => x.)
        }
        
    }
}
