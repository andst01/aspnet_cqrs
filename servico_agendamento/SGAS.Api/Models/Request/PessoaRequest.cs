using SGAS.Application.ViewModels;
using SGAS.Domain.Entity;
using System;
using System.Text.Json.Serialization;

namespace SGAS.Api.Models.Request
{
    public class PessoaRequest
    {
        public int Id { get; set; }
        public bool EhEstrangeiro { get; set; }

        public string Observacao { get; set; }

        public DateTime? DataCadastro { get; set; } = null;
        public DateTime? DataAlteracao { get; set; } = null;

        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public virtual EnderecoRequest Endereco { get; set; }

        public int IdUsuario { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public virtual Usuario Usuario { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public virtual FuncionarioRequest Funcionario { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public virtual ClienteRequest Cliente { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public virtual EmpresaRequest Empresa { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public virtual FornecedorRequest Fornecedor { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public virtual UnidadeVendaRequest UnidadeVenda { get; set; }

        //public PessoaRequest() { }
    }

    public class PessoaFuncionarioRequest
    {
        public int Id { get; set; }
        public bool EhEstrangeiro { get; set; }
        public string Observacao { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        // public virtual EnderecoRequest Endereco { get; set; }
        public int IdUsuario { get; set; }
       // public virtual Usuario Usuario { get; set; }

        #region Funcionario
        public int IdFuncionario { get; set; }
        public int IdPessoa { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        #endregion

        #region Endereco

        public int IdEndereco { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }

        public int IdCidade { get; set; }

        #endregion



    }



    public static class PessoaRequestToViewModel
    {
        public static PessoaViewModel ToResponse(this PessoaRequest request)
        {
            var viewModel = new PessoaViewModel();

            if (request != null)
            {
                viewModel.Id = request.Id;
                viewModel.DataCadastro = request.DataCadastro ?? DateTime.Now;
                viewModel.DataAlteracao = request.DataAlteracao ?? DateTime.Now;
                viewModel.Celular = request.Celular;
                viewModel.Observacao = request.Observacao;
                viewModel.EhEstrangeiro = request.EhEstrangeiro;
                viewModel.Email = request.Email;
                viewModel.Cliente = request.Cliente.ToResponse();
                viewModel.Empresa = request.Empresa.ToResponse();
                viewModel.Endereco = request.Endereco.ToResponse();
                viewModel.Funcionario = request.Funcionario.ToResponse();
            }


            return viewModel;
        }

        public static PessoaViewModel ToResponse(this PessoaFuncionarioRequest request)
        {
            var viewModel = new PessoaViewModel();

            if (request != null)
            {
                viewModel.Id = request.Id;
                viewModel.DataCadastro = request.DataCadastro ?? DateTime.Now;
                viewModel.DataAlteracao = request.DataAlteracao ?? DateTime.Now;
                viewModel.Celular = request.Celular;
                viewModel.Observacao = request.Observacao;
                viewModel.EhEstrangeiro = request.EhEstrangeiro;
                viewModel.Email = request.Email;
               // viewModel.Endereco = request.Endereco.ToResponse();
                viewModel.Funcionario = new FuncionarioViewModel()
                {
                    Id = request.IdFuncionario,
                    Nome = request.Nome,
                    CPF = request.CPF,
                    RG = request.RG,
                    DataNascimento = request.DataNascimento,
                    IdPessoa = request.IdPessoa
                };

                viewModel.Endereco = new EnderecoViewModel()
                {
                    Id = request.IdEndereco,
                    Complemento = request.Complemento,
                    Numero = request.Numero,
                    Bairro = request.Bairro,
                    Logradouro = request.Logradouro,

                };

                // return viewModel;
            }

            return viewModel;
        }

    }
}
