using ConnectHubAPI.DTO_s;
using ConnectHubAPI.Model;

namespace ConnectHubAPI.Repository
{
    public interface IMessageRepository
    {
        public IEnumerable<Message> GetAllMessagesEnviadas();
      public  IEnumerable<MessageDTO> GetAllMessagesNaoEnviadas();

    }
}
