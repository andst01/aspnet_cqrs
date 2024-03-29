using SGAS.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Infra.Context
{
    public  class EventStoreSqlContext : DbContext
    {
        public EventStoreSqlContext(DbContextOptions<EventStoreSqlContext> options) : base(options) { }

        public DbSet<HistoricoEvento> HistoricoEventoAgendamento { get; set; }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<HistoricoEvento>(he =>
            {
                he.ToTable("HistoricoEvento");
                he.HasKey(c => c.Codigo);
                he.Property(c => c.DataEvento)
                .HasColumnName("CreationDate");

                he.Property(c => c.TipoMensagem)
                    .HasColumnName("Action")
                    .HasColumnType("varchar(100)");
            });
        }
    }
}
