using MediatR;
using SGAS.Domain.Entity;

namespace SGAS.Domain.Command
{
    public  class CepCommand : BaseCommand, IRequest<Cep>, IBaseRequest
    {
        public int Id { get; set; }
        public string NumeroCep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public int IdCidade { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        public bool EhCadastroSistema { get; set; }
        public string Bairro { get; set; }
        public int? Ibge { get; set; }
        public virtual CidadeCommand Cidade { get; set; }
    }
}
