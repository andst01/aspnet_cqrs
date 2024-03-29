using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;

namespace SGAS.Application.ViewModels
{
    public class UsuarioViewModel
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

        public ICollection<FuncaoUsuarioViewModel> FuncoesUsuarios { get; set; }
        public DateTime DataCriacao { get; set; }
       
        public virtual PessoaViewModel Pessoa { get; set; }

        public List<ServicoViewModel> ServicoCriacao { get; set; }

        public List<ServicoViewModel> ServicoResponsavel { get; set; }

    }
}
