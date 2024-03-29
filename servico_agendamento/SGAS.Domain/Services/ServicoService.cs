using GestaoAgendamento.Domain.Entity;
using GestaoAgendamento.Domain.Interfaces.Repository;
using GestaoAgendamento.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoAgendamento.Domain.Services
{
    public class ServicoService : BaseService<Servico>, IServicoService
    {
        private readonly IBaseRepository<Servico> _repository;

        public ServicoService(IBaseRepository<Servico> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
