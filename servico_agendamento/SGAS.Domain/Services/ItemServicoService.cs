using GestaoAgendamento.Domain.Entity;
using GestaoAgendamento.Domain.Interfaces.Repository;
using GestaoAgendamento.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoAgendamento.Domain.Services
{
    public class ItemServicoService : BaseService<ItemServico>, IItemServicoService
    {
        private readonly IBaseRepository<ItemServico> _repository;

        public ItemServicoService(IBaseRepository<ItemServico> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
