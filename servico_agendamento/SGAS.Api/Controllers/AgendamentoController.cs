using SGAS.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SGAS.Api.Models.Request;
using Microsoft.AspNetCore.Http;
using SGAS.Application.ViewModels;

namespace SGAS.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgendamentoController : APIController
    {
        private readonly IAgendamentoApp _agendamentoApp;
        public AgendamentoController(IAgendamentoApp agendamentoApp)
        {
            _agendamentoApp = agendamentoApp;
        }


        [HttpGet]
        [Route("Obter/{id}")]
        [ProducesResponseType(typeof(AgendamentoViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Obter(int id)
        {
            return ProcessResponse(await _agendamentoApp.GetById(id));
        }


        [HttpGet]
        [Route("Listar")]
        [ProducesResponseType(typeof(AgendamentoViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Listar()
        {
            return ProcessResponse(await _agendamentoApp.GetAll());
        }

        [HttpPost]
        [Route("Adicionar")]
        [ProducesResponseType(typeof(AgendamentoViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Adcionar([FromBody] AgendamentoRequest request)
        {
            
            return !ModelState.IsValid 
                ? ProcessResponse(ModelState) 
                : ProcessResponse(await _agendamentoApp.Register(request.ToResponse()));
        }

        [HttpPut]
        [Route("Atualizar")]
        [ProducesResponseType(typeof(AgendamentoViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Atualizar([FromBody] AgendamentoRequest request)
        {
            

            return !ModelState.IsValid
                ? ProcessResponse(ModelState)
                : ProcessResponse(await _agendamentoApp.Update(request.ToResponse()));
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
                : ProcessResponse(await _agendamentoApp.Remove(id));
        }
    }
}
