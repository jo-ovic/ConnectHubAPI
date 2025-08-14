using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConnectHubAPI.Model
{
    [Table("MenuGeral_Modulo")]
    public class MenuGeral_Modulo
    {
        [Key]
        public int MenuGeral_ModuloId { get; set; }
        public string mgm_descricao { get; set; }
        IEnumerable<Respostas_Padrao> RespostasPadrao { get; set; }

    }
}
