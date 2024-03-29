using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Application.ViewModels
{
    public class EnderecoViewModel
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }

        public int IdCidade { get; set; }

        public virtual CidadeViewModel Cidade { get; set; }

        public virtual PessoaViewModel Pessoa { get; set; }

        public int IdPessoa { get; set; }

    }
}
