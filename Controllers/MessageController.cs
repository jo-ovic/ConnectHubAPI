using ConnectHubAPI.DTO_s;
using ConnectHubAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConnectHubAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly Repository.IMessageRepository _messageRepository;
        public MessageController(Repository.IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }


        [HttpGet("GetAllMessagesEnviadas")]
        public ActionResult<IEnumerable<Message>> GetTodosEnviados() 
        {

            try
            {
                var message =  _messageRepository.GetAllMessagesEnviadas();
                return Ok(message);
            }
            catch (Exception ex)
            {
                // Log the exception (ex) here if needed
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao acionar aos dados.");
            }


        }

        [HttpGet("GetAllMessagesNaoEnviadas")]
        public ActionResult<IEnumerable<MessageDTO>> GetTodosNaoEnviados()
        {

            try
            {
                var message = _messageRepository.GetAllMessagesNaoEnviadas();
                return Ok(message);
            }
            catch (Exception ex)
            {
                // Log the exception (ex) here if needed
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao acionar aos dados.");
            }


        }



    }
}
