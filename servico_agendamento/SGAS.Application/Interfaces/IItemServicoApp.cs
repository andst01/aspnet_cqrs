using FluentValidation.Results;
using SGAS.Application.ViewModels;
using SGAS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SGAS.Application.Interfaces
{
    public interface IItemServicoApp : IDisposable
    {
        IEnumerable<ItemServicoViewModel> GetAll();
        Task<ItemServicoViewModel> GetById(int id);
        Task<ValidationResult> Register(ItemServicoViewModel itemServicoViewModel);
        Task<ValidationResult> Update(ItemServicoViewModel itemServicoViewModel);
        Task<ValidationResult> Remove(int id);
        Task<IList<HistoricoEventoViewModel>> GetAllHistory(int id);
    }
}
