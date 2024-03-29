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
    public class PessoaController : APIController
    {

        private readonly IPessoaApp _pessoaApp;

        public PessoaController(IPessoaApp pessoaApp)
        {
            _pessoaApp = pessoaApp;
        }

        [HttpPost]
        [Route("AdicionarFuncionario")]
        [ProducesResponseType(typeof(FuncionarioViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ObjectResult), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Adcionar([FromBody] PessoaFuncionarioRequest request)
        {

            return !ModelState.IsValid
                ? ProcessResponse(ModelState)
                : ProcessResponse(await _pessoaApp.Register(request.ToResponse()));
        }
    }
}
