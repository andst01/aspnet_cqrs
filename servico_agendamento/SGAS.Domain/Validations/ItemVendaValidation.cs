using FluentValidation;
using SGAS.Domain.Command;
using SGAS.Domain.Utils;
using System;

namespace SGAS.Domain.Validations
{
    public abstract class ItemVendaValidation<T>
        : AbstractValidator<T> where T : ItemVendaCommand
    {
        protected void ValidaId()
        {
            RuleFor(x => x.Id)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("ItemVenda.Id"));
        }

        protected void ValidaIdProduto()
        {
            RuleFor(x => x.Id)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("ItemVenda.IdProduto"));
        }

        protected void ValidaIdVenda()
        {
            RuleFor(x => x.Id)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("ItemVenda.IdVenda"));
        }

        protected void ValidaQuantidade()
        {
            RuleFor(x => x.Id)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("ItemVenda.Quantidade"));
        }

        protected void ValidaValorUnitario()
        {
            RuleFor(x => x.Id)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("ItemVenda.ValorUnitario"));
        }

        protected void ValidaValorTotal()
        {
            RuleFor(x => x.Id)
                .Equal(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("ItemVenda.ValorTotal"));
        }

        protected void ValidaDataCadastro()
        {
            RuleFor(x => x.DataCadastro)
                .Must(date => date != default(DateTime))
                .WithMessage(Mensagens.ValidaData.ToFormat("ItemVenda.DataCadastro"));
        }

        protected void ValidaDataAtualizacao()
        {
            RuleFor(x => x.DataAtualizacao)
                .Must(date => date != default(DateTime))
                .WithMessage(Mensagens.ValidaData.ToFormat("ItemVenda.DataAtualizacao"));
        }


    }

    public class ItemVendaCreateValidation : ItemVendaValidation<ItemVendaCommand>
    {
        public ItemVendaCreateValidation()
        {
            ValidaIdVenda();
            ValidaIdProduto();
            ValidaQuantidade();
            ValidaValorTotal();
            ValidaValorUnitario();
            ValidaDataCadastro();
            ValidaDataAtualizacao();
        }
    }

    public class ItemVendaUpdateValidation : ItemVendaValidation<ItemVendaCommand>
    {
        public ItemVendaUpdateValidation()
        {
            ValidaId();
            ValidaIdVenda();
            ValidaIdProduto();
            ValidaQuantidade();
            ValidaValorTotal();
            ValidaValorUnitario();
            ValidaDataCadastro();
            ValidaDataAtualizacao();
        }
    }

    public class ItemVendaDeleteValidation : ItemVendaValidation<ItemVendaCommand>
    {
        public ItemVendaDeleteValidation()
        {
            ValidaId();
        }
    }

}
