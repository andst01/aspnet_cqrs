﻿using AutoMapper;
using FluentValidation.Results;
using SGAS.Application.Interfaces;
using SGAS.Application.ViewModels;
using SGAS.Domain.Command;
using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Mediator;
using SGAS.Domain.Interfaces.RepositoryQuery;
using SGAS.Domain.Notifications;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGAS.Application
{
    public class MicroRegiaoApp :  IMicroRegiaoApp
    {
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediatorHandler;
        private readonly IMicroRegiaoQueryRepository _query;

        public MicroRegiaoApp(IMapper mapper, 
                             IMediatorHandler mediatorHandler, 
                             IMicroRegiaoQueryRepository query)
        {
            _mapper = mapper;
            _mediatorHandler = mediatorHandler;
            _query = query;
        }

        public async Task<IEnumerable<MicroRegiaoNotification>> GetAll()
        {
            return await _query.GetAll();
        }

        public async Task<MicroRegiaoNotification> GetById(int id)
        {
           return await _query.GetById(id);
        }

        public async Task<MicroRegiao> Register(MicroRegiaoViewModel request)
        {
            var command = _mapper.Map<MicroRegiaoCreateCommand>(request);
            var response = await _mediatorHandler.SendCommand<MicroRegiao>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<ValidationResult> Remove(int id)
        {
            var response = await _mediatorHandler.SendCommand(new MicroRegiaoDeleteCommand() { Id = id});
            if (response.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }

        public async Task<MicroRegiao> Update(MicroRegiaoViewModel request)
        {
            var command = _mapper.Map<MicroRegiaoUpdateCommand>(request);
            var response = await _mediatorHandler.SendCommand<MicroRegiao>(command);
            if (response.ValidationResult.IsValid)
                await _mediatorHandler.PublishEvent();
            return response;
        }
    }
}
