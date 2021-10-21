namespace Payment_Api.Models
{
    public class ItemData
    {
        public int Id { get; set; }
        public string CardOwnerName { get; set; }
        public string CardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public string SecurityCode { get; set; }

    }
}