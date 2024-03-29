using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class CepCreateCommand : CepCommand
    {
        //public CepCreateCommand(int id, 
        //                        string numeroCep, 
        //                        string logradouro,
        //                        string complemento,
        //                        int idCidade,
        //                        string localidade,
        //                        string uf,
        //                        bool ehCadastroSistema,
        //                        string bairro,
        //                        int? ibge,
        //                        CidadeCommand cidade)
        //{
        //    Id = id;
        //    NumeroCep = numeroCep;
        //    Logradouro = logradouro;
        //    Localidade = localidade;
        //    Complemento = complemento;
        //    IdCidade = idCidade;
        //    Uf = uf;
        //    EhCadastroSistema = ehCadastroSistema;
        //    Bairro = bairro;
        //    Ibge = ibge;
        //    Cidade = cidade;
        //}
        public override bool IsValid()
        {
            ValidationResult = new CepCreateValidation().Validate(this);
            return ValidationResult.IsValid;
            
        }
    }
}
