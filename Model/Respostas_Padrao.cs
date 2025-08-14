using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConnectHubAPI.Model
{
    [Table("respostas_padroes")]
    public class Respostas_Padrao
    {
        [Key]
        public int  rep_resposta_padraoId { get; set; }
        public MenuGeral_Modulo MenuGeral_Modulo { get; set; }
        public int MenuGeral_ModuloId { get; set; }
        public string rep_pergunta { get; set; }
        public string rep_resposta { get; set; }
        public DateTime rep_data_alteracao { get; set; } 

      
      
    

    }
}
