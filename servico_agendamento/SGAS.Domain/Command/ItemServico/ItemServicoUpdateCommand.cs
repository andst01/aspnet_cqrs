using FluentValidation;
using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class ItemServicoUpdateCommand : ItemServicoCommand
    {

        public ItemServicoUpdateCommand(int id,
            int idProduto,
            string descricao,
            int quantidade,
            decimal precoUnitario,
            decimal valorItem,
            decimal valorDesconto,
            int idServico)
        {
            Id = id;
            IdProduto = idProduto;
            Descricao = descricao;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
            ValorItem = valorItem;
            ValorDesconto = valorDesconto;
            IdServico = idServico;
        }
        public override bool IsValid()
        {
            ValidationResult = new ItemServicoUpdateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
