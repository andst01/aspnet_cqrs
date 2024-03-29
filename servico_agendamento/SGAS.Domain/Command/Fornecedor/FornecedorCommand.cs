using MediatR;
using SGAS.Domain.Entity;

namespace SGAS.Domain.Command
{
    public  class FornecedorCommand : BaseCommand,
        IRequest<Fornecedor>, IBaseRequest
    {
        public int Id { get; set; }
        public int IdPessoa { get; set; }

        public string CNPJ { get; set; }

        public string NomeFantasia { get; set; }

        public string RazaoSocial { get; set; }

        public PessoaCommand Pessoa { get; set; }
    }
}
