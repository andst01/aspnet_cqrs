using Microsoft.EntityFrameworkCore;
using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using SGAS.Infra.Context;
using System.Collections.Generic;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Dapper;

namespace SGAS.Infra.Repository
{
    public class CidadeRepository : BaseRepository<Cidade>, ICidadeRepository
    {
        
        public CidadeRepository(SGASContext context) : base(context)
        {
        }


        public async Task<int> InserirCidadeDapper(Cidade cidade)
        {

            int result = 0;
            string sqlQuery = @"INSERT INTO CIDADE (CIDA_ID, CIDA_NOME, CIDA_ID_MICROREGIAO, CIDA_ID_ESTADO)
                               VALUES(@CIDA_ID, @CIDA_NOME, @CIDA_ID_MICROREGIAO, @CIDA_ID_ESTADO)";

            using (var connection = _db.OpenConnection())
            {
                connection.Open();
                result = await connection.ExecuteAsync(sqlQuery, new
                {
                    CIDA_ID = cidade.Id,
                    CIDA_NOME = cidade.Nome,
                    CIDA_ID_MICROREGIAO = cidade.IdMicroRegiao,
                    CIDA_ID_ESTADO = cidade.IdEstado
                });
                
            }

            return result;
        }


        public async Task<bool> TesteInsert()
        {
            var retorno = false;

            try
            {
                var cidade = new Cidade() { Id = 7777777, Nome = "Teste", IdEstado = 80, IdMicroRegiao = 90 };
                var ret = _db.Cidade.Add(cidade);
                retorno = await _db.SaveChangesAsync() > 0;

                return retorno;
            }
            catch (DbUpdateException exception)
            {
                var ex = exception;
                throw ex;
            }
            
           
        }


    }
}
