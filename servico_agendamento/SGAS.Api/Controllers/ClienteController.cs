using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGAS.Api.Models.Request;
using SGAS.Application.Interfaces;
using SGAS.Application.Interfaces.Facade;
using SGAS.Application.ViewModels;
using System.Threading.Tasks;

namespace SGAS.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : APIController
    {

        private readonly IClienteApp _clienteApp;
        private readonly IDadosIbgeFacade _dadosIbgeFacade;

        public ClienteController(IClienteApp clienteApp, 
                                IDadosIbgeFacade dadosIbgeFacade)
        {
            _clienteApp = clienteApp;
            _dadosIbgeFacade = dadosIbgeFacade;
        }

        [HttpGet]
        [Route("Obter/{id}")]
        [ProducesResponseType(typeof(ClienteViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Obter(int id)
        {
            return ProcessResponse(await _clienteApp.GetById(id));
        }


        [HttpGet]
        [Route("Listar")]
        [ProducesResponseType(typeof(ClienteViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Listar()
        {
            return ProcessResponse(await _clienteApp.GetAll());
        }

        [HttpPost]
        [Route("Adicionar")]
        [ProducesResponseType(typeof(ClienteViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Adcionar([FromBody] ClienteRequest request)
        {

            return !ModelState.IsValid
                ? ProcessResponse(ModelState)
                : ProcessResponse(await _clienteApp.Register(request.ToResponse()));
        }

        [HttpPost]
        [Route("AdicionarCidades")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> AdicionarCidades()
        {
            return ProcessResponse(await _dadosIbgeFacade.InserirCidades());
        }

        [HttpPut]
        [Route("Atualizar")]
        [ProducesResponseType(typeof(ClienteViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Atualizar([FromBody] ClienteRequest request)
        {


            return !ModelState.IsValid
                ? ProcessResponse(ModelState)
                : ProcessResponse(await _clienteApp.Update(request.ToResponse()));
        }

        [HttpDelete]
        [Route("Excluir/{id}")]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Excluir(int id)
        {
            return !ModelState.IsValid
                ? ProcessResponse(ModelState)
                : ProcessResponse(await _clienteApp.Remove(id));
        }
    }
}
