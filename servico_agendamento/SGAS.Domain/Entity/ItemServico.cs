using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Domain.Entity
{
    public class ItemServico : EntidadeBase
    {
        // public int Id { get; set; }

        public ItemServico() { }
        public ItemServico(int id, 
            int idProduto, 
            string descricao, 
            int quantidade, 
            decimal precoUnitario,
            decimal valorItem,
            decimal valorDesconto,
            int idServico)
        {
            Id = id;
            IdProduto = idProduto;
            Descricao = descricao;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
            ValorItem = valorItem;
            ValorDesconto = valorDesconto;
            IdServico = idServico;
        }
        public int IdProduto { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal ValorItem { get; set; }
        public decimal ValorDesconto { get; set; }
        public int IdServico { get; set; }
        public virtual Servico Servico { get; set; }
    }
}
