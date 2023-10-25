namespace CQRSDesignPattern.Models.Queries
{
    public class GetFilterQuery
    {
        public string OrderId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }

    }
}
