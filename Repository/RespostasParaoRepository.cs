using ConnectHubAPI.Data;
using ConnectHubAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace ConnectHubAPI.Repository
{
    public class RespostasParaoRepository : IRespostasParaoRepository
    {
        private readonly AppDbContext _context;

        public RespostasParaoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Respostas_Padrao>> GetAllAsync()
        {
            try { 
                return await _context.Respostas_Padroes.AsNoTracking().ToListAsync();
                 
            }
            catch (Exception ex)
            {
                // Log the exception (ex) here if needed
                throw new Exception("Ocorreu um erro ao acionar aos dados.", ex);
            }

           
        }
    }
}
