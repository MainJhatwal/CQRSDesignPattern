namespace CQRSDesignPattern.Models.DTOs
{
    public class Order
    {
        public string OrderId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }
}
