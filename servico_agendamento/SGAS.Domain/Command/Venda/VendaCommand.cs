using MediatR;
using SGAS.Domain.Entity;
using System.Collections.Generic;

namespace SGAS.Domain.Command
{
    public class VendaCommand : BaseCommand, IRequest<Venda>, IBaseRequest
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public decimal Desconto { get; set; }
        public int IdCliente { get; set; }
        public virtual ClienteCommand Cliente { get; set; }
        public int? IdFuncionario { get; set; }
        public virtual FuncionarioCommand Funcionario { get; set; }
        public int? IdUnidadeVenda { get; set; }
        public virtual UnidadeVendaCommand UnidadeVenda { get; set; }
        public virtual ICollection<ItemVendaCommand> ItemVenda { get; set; }
    }
}
