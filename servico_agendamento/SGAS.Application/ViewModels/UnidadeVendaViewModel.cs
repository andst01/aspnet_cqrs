using System.Collections.Generic;

namespace SGAS.Application.ViewModels
{
    public class UnidadeVendaViewModel
    {
        public int Id { get; set; }

        public List<AgendamentoViewModel> Agendamentos { get; set; }

        public List<AgendaViewModel> Agendas { get; set; }

        public List<VendaViewModel> Vendas { get; set; }

        public int IdEmpresa { get; set; }

        public virtual EmpresaViewModel Empresa { get; set; }

        public virtual PessoaViewModel Pessoa { get; set; }

        public int IdPessoa { get; set; }


        public string CNPJ { get; set; }

        public string NomeFantasia { get; set; }

        public string RazaoSocial { get; set; }
    }
}
