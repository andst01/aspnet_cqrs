using MediatR;
using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;

namespace SGAS.Domain.Command
{
    public class UsuarioCommand : BaseCommand, IRequest<Usuario>, IBaseRequest
    {

        public virtual DateTimeOffset? LockoutEnd { get; set; }

        public virtual bool TwoFactorEnabled { get; set; }

        public virtual bool PhoneNumberConfirmed { get; set; }

        public virtual string PhoneNumber { get; set; }

        public virtual string ConcurrencyStamp { get; set; }

        public virtual string SecurityStamp { get; set; }

        public virtual string PasswordHash { get; set; }

        public virtual bool EmailConfirmed { get; set; }

        public virtual string NormalizedEmail { get; set; }

        public virtual string Email { get; set; }

        public virtual string NormalizedUserName { get; set; }

        public virtual string UserName { get; set; }

        public virtual int Id { get; set; }

        public virtual bool LockoutEnabled { get; set; }

        public virtual int AccessFailedCount { get; set; }
        public string Password { get; set; }
        public string Genero { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Nome { get; set; }
        public DateTime DataAlteracao { get; set; }

        public ICollection<FuncaoUsuarioCommand> FuncoesUsuarios { get; set; }
        public DateTime DataCriacao { get; set; }

        public virtual PessoaCommand Pessoa { get; set; }

        public List<ServicoCommand> ServicoCriacao { get; set; }

        public List<ServicoCommand> ServicoResponsavel { get; set; }

    }

    public static class UsuarioCommandToAction
    {
        public static UsuarioCreateCommand ToCreate(this UsuarioCommand command)
        {
            var action = new UsuarioCreateCommand();

            if(command == null) return null;

            action.Id = command.Id;
            action.Password = command.Password;
            action.Nome = command.Nome;
            action.DataNascimento = command.DataNascimento;
            action.DataAlteracao = command.DataAlteracao;
            action.DataCriacao = command.DataCriacao;
            action.EmailConfirmed = command.EmailConfirmed;
            action.PhoneNumberConfirmed = command.PhoneNumberConfirmed;
            action.PhoneNumber = command.PhoneNumber;
            action.Email = command.Email;
            action.Descricao = command.Descricao;
            action.Genero = command.Genero;
            action.AccessFailedCount = command.AccessFailedCount;
            action.LockoutEnabled = command.LockoutEnabled;
            action.LockoutEnd = command.LockoutEnd;
            action.NormalizedEmail = command.NormalizedEmail;
            action.NormalizedUserName = command.NormalizedUserName;
            action.Password = command.Password;
            action.PasswordHash = command.PasswordHash;
            action.ConcurrencyStamp = command.ConcurrencyStamp;
            action.PhoneNumber = command.PhoneNumber;
            action.SecurityStamp = command.SecurityStamp;
            action.UserName = command.UserName;
            action.Pessoa = command.Pessoa.ToCreate();
            action.ServicoCriacao = command.ServicoCriacao;
            action.ServicoResponsavel = command.ServicoResponsavel;
            action.FuncoesUsuarios = command.FuncoesUsuarios;

            return action;
        }

        public static UsuarioUpdateCommand ToUpdate(this UsuarioCommand command)
        {
            var action = new UsuarioUpdateCommand();

            if (command == null) return null;

            action.Id = command.Id;
            action.Password = command.Password;
            action.Nome = command.Nome;
            action.DataNascimento = command.DataNascimento;
            action.DataAlteracao = command.DataAlteracao;
            action.DataCriacao = command.DataCriacao;
            action.EmailConfirmed = command.EmailConfirmed;
            action.PhoneNumberConfirmed = command.PhoneNumberConfirmed;
            action.PhoneNumber = command.PhoneNumber;
            action.Email = command.Email;
            action.Descricao = command.Descricao;
            action.Genero = command.Genero;
            action.AccessFailedCount = command.AccessFailedCount;
            action.LockoutEnabled = command.LockoutEnabled;
            action.LockoutEnd = command.LockoutEnd;
            action.NormalizedEmail = command.NormalizedEmail;
            action.NormalizedUserName = command.NormalizedUserName;
            action.Password = command.Password;
            action.PasswordHash = command.PasswordHash;
            action.ConcurrencyStamp = command.ConcurrencyStamp;
            action.PhoneNumber = command.PhoneNumber;
            action.SecurityStamp = command.SecurityStamp;
            action.UserName = command.UserName;
            action.Pessoa = command.Pessoa.ToUpdate();
            action.ServicoCriacao = command.ServicoCriacao;
            action.ServicoResponsavel = command.ServicoResponsavel;
            action.FuncoesUsuarios = command.FuncoesUsuarios;

            return action;
        }
    }
}
