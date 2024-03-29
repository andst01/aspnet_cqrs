using DnsClient.Protocol;
using Newtonsoft.Json;
using SGAS.Application.Interfaces.Facade;
using SGAS.Domain.Entity;
using SGAS.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SGAS.Application.Facades
{
    public class DadosIbgeFacade : IDadosIbgeFacade
    {
        private readonly IRegiaoRepository _regiaoRepository;
        private readonly IEstadoRepository _estadoRepository;
        private readonly IMesoRegiaoRepository _mesoRegiaoRepository;
        private readonly IMicroRegiaoRepository _microRegiaoRepository;
        private readonly ICidadeRepository _cidadeRepository;

        public DadosIbgeFacade(IRegiaoRepository regiaoRepository,
                               IEstadoRepository estadoRepository,
                               IMesoRegiaoRepository mesoRegiaoRepository,
                               IMicroRegiaoRepository microRegiaoRepository,
                               ICidadeRepository cidadeRepository)
        {
            _regiaoRepository = regiaoRepository;
            _estadoRepository = estadoRepository;
            _mesoRegiaoRepository = mesoRegiaoRepository;
            _microRegiaoRepository = microRegiaoRepository;
            _cidadeRepository = cidadeRepository;
        }

        public async Task<bool> InserirCidades()
        {   
            var retorno =  await _cidadeRepository.TesteInsert();
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("Items : " + i);


            //    using (HttpClient cliente = new HttpClient())
            //    {
            //        var url = $"https://servicodados.ibge.gov.br/api/v1/localidades/regioes/{i}/municipios";
            //        string resultado = cliente.GetStringAsync(url).Result;

            //        List<Cidade> cidades = JsonConvert.DeserializeObject<List<Cidade>>(resultado);

            //        foreach (var cidade in cidades)
            //        {
            //            int idCidade = cidade.Id;
            //            int idMicroRegiao = cidade.MicrorRegiao.Id;
            //            int idMesoRegiao = cidade.MicrorRegiao.MesorRegiao.Id;
            //            int idEstado = cidade.MicrorRegiao.MesorRegiao.Uf.Id;
            //            int idRegiao = cidade.MicrorRegiao.MesorRegiao.Uf.Regiao.Id;

            //            var v_cidade = cidade;
            //            var v_microRegiao = cidade.MicrorRegiao;
            //            var v_mesoRegiao = cidade.MicrorRegiao.MesorRegiao;
            //            var v_estado = cidade.MicrorRegiao.MesorRegiao.Uf;
            //            var v_regiao = cidade.MicrorRegiao.MesorRegiao.Uf.Regiao;


            //            var regiao = _regiaoRepository.ObterPorId(idRegiao);
            //            if (regiao == null)
            //            {
            //                v_regiao.Estados = null;
            //                // _regiaoRepository.Adicionar(v_regiao);


            //            }

            //            var list_1 = _estadoRepository.ObterTodos().ToList();

            //            var estado = _estadoRepository.ObterPorId(idEstado);
            //            if (estado == null)
            //            {
            //                v_estado.IdRegiao = idRegiao;
            //                v_estado.Regiao = null;
            //                v_estado.Cidade = null;
            //                v_estado.MesoRegiao = null;
            //                // _estadoRepository.Adicionar(v_estado);


            //            }

            //            var list = _mesoRegiaoRepository.ObterTodos().ToList();

            //           //  aqui
            //           var mesorregiao = _mesoRegiaoRepository.ObterPorId(idMesoRegiao);

            //            if (mesorregiao == null)
            //            {
            //                v_mesoRegiao.IdEstado = idEstado;
            //                v_mesoRegiao.Uf = null;
            //                v_mesoRegiao.MicroRegiao = null;

            //                //_mesoRegiaoRepository.Adicionar(v_mesoRegiao);


            //            }


            //            var microrregiao = _microRegiaoRepository.ObterPorId(idMicroRegiao);
            //            if (microrregiao == null)
            //            {
            //                v_microRegiao.IdMesoRegiao = idMesoRegiao;
            //                v_microRegiao.MesorRegiao = null;
            //                v_microRegiao.Cidade = null;
            //                //_microRegiaoRepository.Adicionar(v_microRegiao);


            //            }


            //            v_cidade.IdEstado = v_estado.Id;
            //            v_cidade.IdMicroRegiao = v_microRegiao.Id;
            //            v_cidade.MicrorRegiao = null;

            //            // _cidadeRepository.Adicionar(v_cidade);

            //            //retorno = await _cidadeRepository.InserirCidadeDapper(v_cidade) > 0;

            //          //  retorno = await _cidadeRepository.Save();


            //        }

            //        //var retorno = dbContext.SaveChanges();
            //    }
            //}

            // retorno = await _cidadeRepository.Save();

            //;

            return retorno;
        }

       
    }
}
