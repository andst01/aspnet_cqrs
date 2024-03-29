using FluentValidation;
using SGAS.Domain.Command;
using SGAS.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Domain.Validations
{
    public abstract class ProdutoValidation<T>
        : AbstractValidator<T> where T : ProdutoCommand
    {
        protected void ValidaId()
        {
            RuleFor(x => x.Id)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Produto.Id"));
        }

        protected void ValidaDescricao()
        {
            RuleFor(x => x.Descricao)
                  .Empty()
                  .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Pessoa.Descricao"));
        }

        protected void ValidaPreco()
        {
            RuleFor(x => x.Preco)
                  .Equal(0)
                  .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Pessoa.Preco"));
        }

        protected void ValidaIdCategoria()
        {
            RuleFor(x => x.IdCategoria)
                  .Equal(0)
                  .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("Pessoa.IdCategoria"));
        }
    }

    public class ProdutoCreateValidation : ProdutoValidation<ProdutoCommand>
    {
        public ProdutoCreateValidation()
        {
            ValidaDescricao();
            ValidaPreco();
            ValidaIdCategoria();
        }
    }

    public class ProdutoUpdateValidation : ProdutoValidation<ProdutoCommand>
    {
        public ProdutoUpdateValidation()
        {
            ValidaId();
            ValidaDescricao();
            ValidaPreco();
            ValidaIdCategoria();
        }
    }

    public class ProdutoDeleteValidation : ProdutoValidation<ProdutoCommand>
    {
        public ProdutoDeleteValidation()
        {
            ValidaId();
        }
    }
}
