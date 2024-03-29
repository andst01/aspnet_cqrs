using SGAS.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGAS.Domain.Command
{
    public class VendaDeleteCommand : VendaCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new VendaDeleteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
