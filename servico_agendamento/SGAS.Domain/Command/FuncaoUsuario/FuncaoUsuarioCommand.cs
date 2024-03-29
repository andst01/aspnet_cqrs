using MediatR;
using SGAS.Domain.Entity;
using System;

namespace SGAS.Domain.Command
{
    public  class FuncaoUsuarioCommand : BaseCommand, 
                                                  IRequest<FuncaoUsuario>, IBaseRequest
    {
        public int UserId { get; set; }

        public int RoleId { get; set; }

        public FuncaoCommand Role { get; set; }

        public UsuarioCommand User { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime? DataFim { get; set; }
    }
}
