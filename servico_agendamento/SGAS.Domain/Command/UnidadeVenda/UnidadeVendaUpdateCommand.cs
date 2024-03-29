using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class UnidadeVendaUpdateCommand : UnidadeVendaCommand
    {
        //public UnidadeVendaUpdateCommand(int id, 
        //                                 int idEmpresa, 
        //                                 int idPessoa, 
        //                                 string cnpj, 
        //                                 string nomeFantasia, 
        //                                 string razaoSocial)
        //{
        //    Id = id;
        //    IdEmpresa = idEmpresa;
        //    IdPessoa = idPessoa;
        //    CNPJ = cnpj;
        //    NomeFantasia = nomeFantasia;
        //    RazaoSocial = razaoSocial;
        //}
        public override bool IsValid()
        {
            ValidationResult = new UnidadeVendaUpdateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
