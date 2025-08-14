using ConnectHubAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConnectHubAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Respostas_PadraoController : ControllerBase
    {
        private readonly IRespostasParaoRepository _respostasParaoRepository;


        public Respostas_PadraoController(IRespostasParaoRepository respostasParaoRepository)
        {
            _respostasParaoRepository = respostasParaoRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var respostas = await _respostasParaoRepository.GetAllAsync();
                return Ok(respostas);
            }
            catch (Exception ex)
            {
                // Log the exception (ex) here if needed
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao acionar aos dados.");
            }
        }
    }
}
