using SGAS.Domain.Validations;

namespace SGAS.Domain.Command
{
    public class EmpresaUpdateCommand : EmpresaCommand
    {
        //public EmpresaUpdateCommand(int id, int idPessoa, string cnpj, string nomeFantasia, string razaoSocial)
        //{
        //    Id = id;
        //    IdPessoa = idPessoa;
        //    CNPJ = cnpj;
        //    NomeFantasia = nomeFantasia;
        //    RazaoSocial = razaoSocial;
        //}

        public override bool IsValid()
        {
            ValidationResult = new EmpresaUpdateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
