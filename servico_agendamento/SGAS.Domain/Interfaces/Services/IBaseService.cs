using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAgendamento.Domain.Interfaces.Services
{
    public interface IBaseService<T> where T : class
    {
        IQueryable<T> ObterTodos();
        T ObterPorId(int id);
        Task<T> ObterPorIdAsync(int id);
        T Adicionar(T entity);
        T Atualizar(T entity);
        void Excluir(T entity);
        Task<T> AdicionarAsync(T entity);
        void Dispose();
    }
}
