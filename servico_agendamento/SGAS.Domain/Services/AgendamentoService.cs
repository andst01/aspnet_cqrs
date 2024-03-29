using GestaoAgendamento.Domain.Entity;
using GestaoAgendamento.Domain.Interfaces.Repository;
using GestaoAgendamento.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoAgendamento.Domain.Services
{
    public class AgendamentoService : BaseService<Agendamento>, IAgendamentoService
    {
        private readonly IBaseRepository<Agendamento> _repository;

        public AgendamentoService(IBaseRepository<Agendamento> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
