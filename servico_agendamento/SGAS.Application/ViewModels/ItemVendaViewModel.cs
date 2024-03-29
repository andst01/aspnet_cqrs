using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGAS.Application.ViewModels
{
    public class ItemVendaViewModel
    {
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }

        public decimal Desconto { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public int IdVenda { get; set; }

        public virtual ProdutoViewModel Produto { get; set; }

        public virtual Venda Venda { get; set; }
    }
}
