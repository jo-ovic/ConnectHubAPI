using ConnectHubAPI.Data;
using ConnectHubAPI.DTO_s;
using ConnectHubAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace ConnectHubAPI.Repository
{
    public class MessageRepository : IMessageRepository
    {
        private readonly AppDbContext _context;




        public MessageRepository(AppDbContext context)
        {
            _context = context;
        }
        

        public IEnumerable<Message> GetAllMessagesEnviadas()
        {
            try
            {
                return _context.Messages.ToList().Where(c => c.Confirmacao == true);

            }
            catch (Exception ex)
            {
                // Log the exception (ex) here if needed
                throw new Exception("Ocorreu um erro ao acionar aos dados.", ex);
            }
           

        }

        public IEnumerable<MessageDTO> GetAllMessagesNaoEnviadas()
        {
            try
            {
                var messages = _context.Messages.ToList().Where(c=> c.Confirmacao == false);
                var messageDTO = new MessageDTO();
                var list = new List<MessageDTO>();
                foreach (var message in messages)
                {
                   
                    list.Add(new MessageDTO { MessageId = message.MessageId, Name = message.Name, whatsAppNumber = message.whatsAppNumber, 
                    message = message.message , DataEnvio = DateTime.Now, DataCriacao = Convert.ToDateTime(message.DataCriacao)

                    });
                }

                foreach (var message in messages)
                {
                    message.Confirmacao = true;
                    message.DataEnvio = DateTime.Now;
                    _context.Update(message);
                    _context.SaveChanges();
                }

                return list;

            }
            catch (Exception ex)
            {
                // Log the exception (ex) here if needed
                throw new Exception("Ocorreu um erro ao acionar aos dados.", ex);
            }

        }
    }
}
