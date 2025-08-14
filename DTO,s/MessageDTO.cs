namespace ConnectHubAPI.DTO_s
{
    public class MessageDTO
    {
        public int MessageId { get; set; }
        public string Name { get; set; }
        public string whatsAppNumber { get; set; }
        public string message { get; set; }
        public DateTime DataEnvio { get; set; }
        public DateTime DataCriacao { get; set; }

        public bool Confirmacao { get; set; }
    }
}
