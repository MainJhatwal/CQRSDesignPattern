using CQRSDesignPattern.Models.DTOs;
using CQRSDesignPattern.Models.Queries;

namespace CQRSDesignPattern.Queries
{
    public class GetOrderQueryHandler
    {
      public Order Handle (GetOrderQuery query)
        {
            return new Order { OrderId = query.OrderId, ProductName = "Sample Product", Quantity = 10 };
        }

        public Order Handle(GetFilterQuery query)
        {
            return new Order { OrderId = query.OrderId, ProductName = "Filtered Product", Quantity = 20 };
        }
    }
}
