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
    public class FuncionarioController : APIController
    {

        private readonly IFuncionarioApp _funcionarioApp;

        public FuncionarioController(IFuncionarioApp funcionarioApp)
        {
            _funcionarioApp = funcionarioApp;
        }


        [HttpGet]
        [Route("Obter/{id}")]
        [ProducesResponseType(typeof(FuncionarioViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Obter(int id)
        {
            return ProcessResponse(await _funcionarioApp.GetById(id));
        }


        [HttpGet]
        [Route("Listar")]
        [ProducesResponseType(typeof(FuncionarioViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Listar()
        {
            return ProcessResponse(await _funcionarioApp.GetAll());
        }

        [HttpPost]
        [Route("Adicionar")]
        [ProducesResponseType(typeof(FuncionarioViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Adcionar([FromBody] FuncionarioRequest request)
        {

            return !ModelState.IsValid
                ? ProcessResponse(ModelState)
                : ProcessResponse(await _funcionarioApp.Register(request.ToResponse()));
        }

        [HttpPost]
        [Route("AdicionarFuncionarioCargo")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(FuncionarioViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> AdicionarFuncionarioCargo([FromBody] FuncionarioRequest request)
        {

            return !ModelState.IsValid
                ? ProcessResponse(ModelState)
                : ProcessResponse(await _funcionarioApp.Register(request.ToResponse()));
        }

        [HttpPut]
        [Route("Atualizar")]
        [ProducesResponseType(typeof(FuncionarioViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Atualizar([FromBody] FuncionarioRequest request)
        {


            return !ModelState.IsValid
                ? ProcessResponse(ModelState)
                : ProcessResponse(await _funcionarioApp.Update(request.ToResponse()));
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
                : ProcessResponse(await _funcionarioApp.Remove(id));
        }
    }
}
