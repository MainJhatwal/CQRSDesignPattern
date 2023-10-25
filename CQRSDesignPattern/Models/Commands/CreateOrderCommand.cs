namespace CQRSDesignPattern.Models.Commands
{
    public class CreateOrderCommand
    {
        public string OrderId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }
}
