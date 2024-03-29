using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGAS.Domain.Dto
{
    public class CommandReturnDto
    {
        public IList<string> ErrorMessages { get; set; }

        public void AddError(string message)
        {
            ErrorMessages ??= new List<string>();
            ErrorMessages.Add(message);
        }

        public bool IsValid() => !ErrorMessages?.Any() ?? true;
    }
}
