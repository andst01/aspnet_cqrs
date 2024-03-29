using System.Collections.Generic;

namespace SGAS.Application.ViewModels
{
    public class VendaViewModel
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public decimal Desconto { get; set; }
        public int IdCliente { get; set; }
        public virtual ClienteViewModel Cliente { get; set; }
        public int? IdFuncionario { get; set; }
        public virtual FuncionarioViewModel Funcionario { get; set; }
        public int? IdUnidadeVenda { get; set; }
        public virtual UnidadeVendaViewModel UnidadeVenda { get; set; }
        public virtual ICollection<ItemVendaViewModel> ItemVenda { get; set; }
    }
}
