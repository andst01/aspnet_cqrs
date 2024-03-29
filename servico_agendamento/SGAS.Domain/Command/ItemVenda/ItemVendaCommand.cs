using MediatR;
using SGAS.Domain.Entity;
using System;

namespace SGAS.Domain.Command
{
    public class ItemVendaCommand : BaseCommand, IRequest<ItemVenda>, IBaseRequest
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

        public virtual ProdutoCommand Produto { get; set; }

        public virtual VendaCommand Venda { get; set; }
    }
}
