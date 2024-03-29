using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Domain.Utils
{
    public static class StringExtensions
    {
        public static string ToFormat(this string mensagem, params object[] parametros)
        {
            return string.Format(mensagem, parametros);
        }
    }
}
