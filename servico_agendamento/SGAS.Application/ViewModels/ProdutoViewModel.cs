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
    public class ProdutoViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public decimal Preco { get; set; }
        public bool? Ativo { get; set; }
        public int IdCategoria { get; set; }

        public virtual CategoriaViewModel Categoria { get; set; }

        public virtual ICollection<ItemVendaViewModel> ItemVendas { get; set; }
    }
}
