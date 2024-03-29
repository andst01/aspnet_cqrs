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
    public class ProdutoController : APIController
    {
        private readonly IProdutoApp _produtoApp;

        public ProdutoController(IProdutoApp produtoApp)
        {
            _produtoApp = produtoApp;
        }

        [HttpGet]
        [Route("Obter/{id}")]
        [ProducesResponseType(typeof(AgendamentoViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Obter(int id)
        {
            return ProcessResponse(await _produtoApp.GetById(id));
        }


        [HttpGet]
        [Route("Listar")]
        [ProducesResponseType(typeof(AgendamentoViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Listar()
        {
            return ProcessResponse(await _produtoApp.GetAll());
        }

        [HttpPost]
        [Route("Adicionar")]
        [ProducesResponseType(typeof(AgendamentoViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Adcionar([FromBody] ProdutoRequest request)
        {

            return !ModelState.IsValid
                ? ProcessResponse(ModelState)
                : ProcessResponse(await _produtoApp.Register(request.ToResponse()));
        }

        [HttpPut]
        [Route("Atualizar")]
        [ProducesResponseType(typeof(AgendamentoViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Atualizar([FromBody] ProdutoRequest request)
        {


            return !ModelState.IsValid
                ? ProcessResponse(ModelState)
                : ProcessResponse(await _produtoApp.Update(request.ToResponse()));
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
                : ProcessResponse(await _produtoApp.Remove(id));
        }
    }
}
