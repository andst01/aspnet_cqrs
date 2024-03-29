﻿using SGAS.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Domain.Command
{
    public class CategoriaUpdateCommand : CategoriaCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new CategoriaUpdateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
