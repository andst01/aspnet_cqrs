using AutoMapper;
using FluentValidation.Results;
using SGAS.Application.Interfaces;
using SGAS.Application.ViewModels;
using SGAS.Domain.Command;
using SGAS.Domain.Notifications;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Infra.EventSourcing;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGAS.Application
{
    public class ItemServicoApp : IItemServicoApp
    {

        private readonly IMapper _mapper;
        private readonly IItemServicoRepository _repository;
        //private readonly IEventStoreSqlRepository _eventStoreSql;
        private readonly IMediatorHandler _mediatorHandler;

        public ItemServicoApp(IMapper mapper, 
                              IItemServicoRepository repository, 
                              //IEventStoreSqlRepository eventStoreSql, 
                              IMediatorHandler mediatorHandler)
        {
            _mapper = mapper;
            _repository = repository;
            //_eventStoreSql = eventStoreSql;
            _mediatorHandler = mediatorHandler;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<ItemServicoViewModel> GetAll()
        {
            return _mapper.Map<List<ItemServicoViewModel>>(_repository.ObterTodos());
        }

        public async Task<IList<HistoricoEventoViewModel>> GetAllHistory(int id)
        {
            return new List<HistoricoEventoViewModel>();
            //return _mapper.Map<List<HistoricoEventoViewModel>>(await _eventStoreSql.All(id, "Agenda"));
        }

        public async Task<ItemServicoViewModel> GetById(int id)
        {
            return _mapper.Map<ItemServicoViewModel>(await _repository.ObterPorIdAsync(id));
        }

        public async Task<ValidationResult> Register(ItemServicoViewModel itemServicoViewModel)
        {
            var registerCommand = _mapper.Map<ItemServicoCreateCommand>(itemServicoViewModel);
            return await _mediatorHandler.SendCommand(registerCommand);
        }

        public async Task<ValidationResult> Remove(int id)
        {
            var registerCommand = _mapper.Map<ItemServicoDeleteCommand>(id);
            return await _mediatorHandler.SendCommand(registerCommand);
        }

        public async Task<ValidationResult> Update(ItemServicoViewModel itemServicoViewModel)
        {
            var registerCommand = _mapper.Map<ItemServicoUpdateCommand>(itemServicoViewModel);
            return await _mediatorHandler.SendCommand(registerCommand);
        }
    }
}
