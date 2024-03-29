using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class ItemServicoCreateCommand : ItemServicoCommand
    {
        public ItemServicoCreateCommand(int id, 
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
            ValidationResult = new ItemServicoCreateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
