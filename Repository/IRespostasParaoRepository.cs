using ConnectHubAPI.Model;

namespace ConnectHubAPI.Repository
{
    public interface IRespostasParaoRepository
    {
        public Task<IEnumerable<Respostas_Padrao>> GetAllAsync();
    }
}
