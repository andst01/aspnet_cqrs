using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGAS.Api.Models.Request;
using SGAS.Application.Interfaces;
using SGAS.Application.ViewModels;
using System.Threading.Tasks;

namespace SGAS.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    
    public class UnidadeVendaController : APIController
    {
        private readonly IUnidadeVendaApp _unidadeVendaApp;

        public UnidadeVendaController(IUnidadeVendaApp unidadeVendaApp)
        {
            _unidadeVendaApp = unidadeVendaApp;
        }

        [HttpGet]
        [Route("Obter/{id}")]
        [ProducesResponseType(typeof(FuncionarioViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Obter(int id)
        {
            return ProcessResponse(await _unidadeVendaApp.GetById(id));
        }


        [HttpGet]
        [Route("Listar")]
        [ProducesResponseType(typeof(FuncionarioViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Listar()
        {
            return ProcessResponse(await _unidadeVendaApp.GetAll());
        }

        [HttpPost]
        [Route("Adicionar")]
        [ProducesResponseType(typeof(FuncionarioViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Adcionar([FromBody] UnidadeVendaRequest request)
        {
            return !ModelState.IsValid
                ? ProcessResponse(ModelState)
                : ProcessResponse(await _unidadeVendaApp.Register(request.ToResponse()));
        }

        [HttpPut]
        [Route("Atualizar")]
        [ProducesResponseType(typeof(FuncionarioViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Atualizar([FromBody] UnidadeVendaRequest request)
        {
            return !ModelState.IsValid
                ? ProcessResponse(ModelState)
                : ProcessResponse(await _unidadeVendaApp.Update(request.ToResponse()));
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
                : ProcessResponse(await _unidadeVendaApp.Remove(id));
        }
    }
}
