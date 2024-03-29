using SGAS.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGAS.Domain.Command
{
    public class ItemVendaUpdateCommand : ItemVendaCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new ItemVendaUpdateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
