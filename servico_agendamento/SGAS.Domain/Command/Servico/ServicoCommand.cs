using MediatR;
using SGAS.Domain.Entity;
using System;

namespace SGAS.Domain.Command
{
    public  class ServicoCommand : BaseCommand,
            IRequest<Servico>, IBaseRequest
    {
        public int Id { get; set; }
        public int IdAgendamento { get; set; }
        public virtual AgendamentoCommand Agendamento { get; set; }
        public int IdUsuarioResponsavel { get; set; }
        public int CodigoServico { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdUsuarioCriacao { get; set; }
        public int QuantidadeParcelas { get; set; }
        public decimal ValorTotal { get; set; }

        public UsuarioCommand UsuarioCriacao { get; set; }

        public UsuarioCommand UsuarioResponsavel { get; set; }
    }

    public static class ServicoCommandToAction
    {
        public static ServicoCreateCommand ToCreate(this ServicoCommand command)
        {
            var action = new ServicoCreateCommand();

            if (command == null) return null;

            action.Id = command.Id;
            action.IdAgendamento = command.IdAgendamento;
            action.IdUsuarioResponsavel = command.IdUsuarioResponsavel;
            action.QuantidadeParcelas = command.QuantidadeParcelas; 
            action.IdUsuarioResponsavel = command.IdUsuarioResponsavel;
            action.CodigoServico = command.CodigoServico;
            action.IdUsuarioCriacao = command.IdUsuarioCriacao;
            action.ValorTotal = command.ValorTotal;
            action.DataCadastro = command.DataCadastro;
            action.UsuarioCriacao = command.UsuarioCriacao;
            action.UsuarioResponsavel = command.UsuarioResponsavel;
            action.Agendamento = command.Agendamento;
            
            return action;
        }

        public static ServicoUpdateCommand ToUpdate(this ServicoCommand command)
        {
            var action = new ServicoUpdateCommand();

            if (command == null) return null;

            action.Id = command.Id;
            action.IdAgendamento = command.IdAgendamento;
            action.IdUsuarioResponsavel = command.IdUsuarioResponsavel;
            action.QuantidadeParcelas = command.QuantidadeParcelas;
            action.IdUsuarioResponsavel = command.IdUsuarioResponsavel;
            action.CodigoServico = command.CodigoServico;
            action.IdUsuarioCriacao = command.IdUsuarioCriacao;
            action.ValorTotal = command.ValorTotal;
            action.DataCadastro = command.DataCadastro;
            action.UsuarioCriacao = command.UsuarioCriacao;
            action.UsuarioResponsavel = command.UsuarioResponsavel;
            action.Agendamento = command.Agendamento;

            return action;
        }
    }
}
