using MediatR;
using SGAS.Domain.Entity;
using System.Collections.Generic;

namespace SGAS.Domain.Command
{
    public class UnidadeVendaCommand : BaseCommand,
                                                IRequest<UnidadeVenda>, IBaseRequest
    {
        public int Id { get; set; }

        public List<AgendamentoCommand> Agendamentos { get; set; }

        public List<AgendaCommand> Agendas { get; set; }

        public List<VendaCommand> Vendas { get; set; }

        public int IdEmpresa { get; set; }

        public virtual EmpresaCommand Empresa { get; set; }

        public virtual PessoaCommand Pessoa { get; set; }

        public int IdPessoa { get; set; }


        public string CNPJ { get; set; }

        public string NomeFantasia { get; set; }

        public string RazaoSocial { get; set; }
    }
}
