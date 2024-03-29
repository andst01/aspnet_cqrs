using GestaoAgendamento.Domain.Interfaces.Repository;
using GestaoAgendamento.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAgendamento.Domain.Services
{
    public class BaseService<T> : IDisposable, IBaseService<T> where T : class
    {
        private readonly IBaseRepository<T> _repository;

        public BaseService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        public T Adicionar(T entity)
        {
            return _repository.Adicionar(entity);
        }

        public async Task<T> AdicionarAsync(T entity)
        {
            return await _repository.AdicionarAsync(entity);
        }

        public T Atualizar(T entity)
        {
            return _repository.Atualizar(entity);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public void Excluir(T entity)
        {
            _repository.Excluir(entity);
        }

        public T ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public async Task<T> ObterPorIdAsync(int id)
        {
            return await _repository.ObterPorIdAsync(id);
        }

        public IQueryable<T> ObterTodos()
        {
            return _repository.ObterTodos();
        }
    }
}
