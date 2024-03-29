using SGAS.Domain.Entity;

namespace SGAS.Application.ViewModels
{
    public class FornecedorViewModel
    {
        public int Id { get; set; }
        public virtual PessoaViewModel Pessoa { get; set; }

        public int IdPessoa { get; set; }

        public string CNPJ { get; set; }

        public string NomeFantasia { get; set; }

        public string RazaoSocial { get; set; }
    }
}