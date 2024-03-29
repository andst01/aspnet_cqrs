namespace SGAS.Domain.Command
{
    public abstract class ItemServicoCommand : BaseCommand
    {
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal ValorItem { get; set; }
        public decimal ValorDesconto { get; set; }
        public int IdServico { get; set; }
    }
}
