using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Infra.Identity
{
    public class DadosUsuario : IUser
    {
        private readonly IHttpContextAccessor _httpContext;
        public DadosUsuario(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }

        public string ObterUsuario()
        {
            return _httpContext.HttpContext.User.Identity.Name;
        }
    }
}
