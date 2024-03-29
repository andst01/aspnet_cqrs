using SGAS.Domain.Entity;
using System;

namespace SGAS.Application.ViewModels
{
    public  class PessoaViewModel
    {
        public int Id { get; set; }
        public bool EhEstrangeiro { get; set; }

        public string Observacao { get; set; }

        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }

        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

        public virtual EnderecoViewModel Endereco { get; set; }

        public int IdUsuario { get; set; }

        public virtual UsuarioViewModel Usuario { get; set; }

        public virtual FuncionarioViewModel Funcionario { get; set; }

        public virtual ClienteViewModel Cliente { get; set; }

        public virtual EmpresaViewModel Empresa { get; set; }

        public virtual FornecedorViewModel Fornecedor { get; set; }

        public virtual UnidadeVendaViewModel UnidadeVenda { get; set; }

    }
}
