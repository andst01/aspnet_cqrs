using GestaoAgendamento.Domain.Interfaces.Repository;
using GestaoAgendamento.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAgendamento.Domain.Services
{
    public class UnitOfWorkService : IUnitOfWorkService
    {
        private readonly IUnitOfWorkRepository _unitOfWork;
        public UnitOfWorkService(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        private IAgendamentoService agendamentoService;
        private IAgendaService agendaService;
        private IItemServicoService itemServicoService;
        private IMotivoService motivoService;
        private IServicoService servicoService;
       

        public IAgendamentoService AgendamentoService
        { 
            get { return agendamentoService ?? new AgendamentoService(_unitOfWork.AgendamentoRepository); }
        }


        public IAgendaService AgendaService
        {
            get { return agendaService ?? new AgendaService(_unitOfWork.AgendaRepository); }
        }


        public IItemServicoService ItemServicoService
        { 
            get { return itemServicoService ?? new ItemServicoService(_unitOfWork.ItemServicoRepository); }
        }


        public IMotivoService MotivoService
        {
            get { return motivoService ?? new MotivoService(_unitOfWork.MotivoRepository); }
        }

        public IServicoService ServicoService
        { 
            get { return servicoService ?? new ServicoService(_unitOfWork.ServicoRepository); }
        }


        public void Salvar()
        {
            _unitOfWork.Salvar();
        }

        public async Task SalvarAsync()
        {
           await  _unitOfWork.SalvarAsync();
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}
