using GestaoAgendamento.Domain.Entity;
using GestaoAgendamento.Domain.Interfaces.Repository;
using GestaoAgendamento.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoAgendamento.Domain.Services
{
    public class MotivoService : BaseService<Motivo>, IMotivoService
    {
        private readonly IBaseRepository<Motivo> _repository;

        public MotivoService(IBaseRepository<Motivo> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
