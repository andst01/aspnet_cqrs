using MediatR;
using SGAS.Domain.Entity;
using System.Collections.Generic;

namespace SGAS.Domain.Command
{
    public class EmpresaCommand : BaseCommand, IRequest<Empresa>, IBaseRequest
    {
        public int Id { get; set; }
        public int IdPessoa { get; set; }

        public string CNPJ { get; set; }

        public string NomeFantasia { get; set; }

        public string RazaoSocial { get; set; }

        public List<UnidadeVendaCommand> UnidadeVendas { get; set; }

        public PessoaCommand Pessoa { get; set; }
    }
}
