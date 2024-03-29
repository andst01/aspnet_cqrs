using FluentValidation;
using SGAS.Domain.Command;
using SGAS.Domain.Utils;

namespace SGAS.Domain.Validations
{
    public class ItemServicoValidation<T> : AbstractValidator<T> where T : ItemServicoCommand
    {
        protected void ValidaId()
        {
            RuleFor(x => x.Id)
                .NotEqual(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("ItemServico.Id"));


        }

        protected void ValidaIdProduto()
        {
            RuleFor(x => x.IdProduto)
                .NotEqual(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("ItemServico.IdProduto"));


        }

        protected void ValidaQuantidade()
        {
            RuleFor(x => x.Quantidade)
                .NotEqual(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("ItemServico.Quantidade"));


        }

        protected void ValidaPrecoUnitario()
        {
            RuleFor(x => x.PrecoUnitario)
                .NotEqual(0)
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("ItemServico.PrecoUnitario"));


        }

        protected void ValidaDescricao()
        {
            RuleFor(x => x.Descricao)
                .NotEmpty()
                .NotNull()
                .WithMessage(Mensagens.ValidaObrigatorio.ToFormat("ItemServico.Descricao"));


        }
    }

    public class ItemServicoCreateValidation : ItemServicoValidation<ItemServicoCommand>
    {
        public ItemServicoCreateValidation()
        {
            ValidaDescricao();
            ValidaIdProduto();
            ValidaPrecoUnitario();
            ValidaQuantidade();
        }
    }

    public class ItemServicoUpdateValidation : ItemServicoValidation<ItemServicoCommand>
    {
        public ItemServicoUpdateValidation()
        {
            ValidaId();
            ValidaDescricao();
            ValidaIdProduto();
            ValidaPrecoUnitario();
            ValidaQuantidade();
        }
    }

    public class ItemServicoDeleteValidation : ItemServicoValidation<ItemServicoCommand>
    {
        public ItemServicoDeleteValidation()
        {
            ValidaId();
        }
    }
}
