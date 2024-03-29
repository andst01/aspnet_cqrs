using GestaoAgendamento.Domain.Entity;
using GestaoAgendamento.Domain.Interfaces.Repository;
using GestaoAgendamento.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoAgendamento.Domain.Services
{
    public class AgendaService : BaseService<Agenda>, IAgendaService
    {
        private readonly IBaseRepository<Agenda> _repository;

        public AgendaService(IBaseRepository<Agenda> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
