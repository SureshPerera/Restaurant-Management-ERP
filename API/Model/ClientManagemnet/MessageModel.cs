namespace API.Model.ClientManagemnet
{
    public class MessageModel
    {
        public Guid Id { get; set; }
        public string Type { get; set; } = "SMS";
        public string? Messages { get; set; }
        public string? ReceiverPhone { get; set; }
        public string? ReceiverEmail { get; set; }
    }
}
