using MediatR;
using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;

namespace SGAS.Domain.Command
{
    public class ClienteCommand : BaseCommand, IRequest<Cliente>, IBaseRequest
    {
        public int Id { get; set; }

        public List<AgendamentoCommand> Agendamentos { get; set; }

        public List<VendaCommand> Vendas { get; set; }

        public virtual PessoaCommand Pessoa { get; set; }

        public int IdPessoa { get; set; }

        public string CPF { get; set; }

        public string RG { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }
    }
}
