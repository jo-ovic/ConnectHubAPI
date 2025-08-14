using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace ConnectHubAPI.Data
{
    public class AppDbContext : DbContext   {
        public AppDbContext(DbContextOptions<AppDbContext> options)
       : base(options)
        {
             
        }

        public DbSet<Model.Respostas_Padrao> Respostas_Padroes { get; set; }
        public DbSet<Model.MenuGeral_Modulo> MenuGeral_Modulos { get; set; }
        public DbSet<Model.Usuario> Usuarios { get; set; }
        public DbSet<Model.Message> Messages { get; set; }



        
    }
}
