using MediatR;
using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Domain.Command
{
    public class ProdutoCommand : BaseCommand, 
                                           IRequest<Produto>, IBaseRequest
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public decimal Preco { get; set; }
        public bool? Ativo { get; set; }
        public int IdCategoria { get; set; }

        public virtual CategoriaCommand Categoria { get; set; }

        public virtual ICollection<ItemVendaCommand> ItemVendas { get; set; }
    }
}
