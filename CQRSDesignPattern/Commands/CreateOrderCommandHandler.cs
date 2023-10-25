using CQRSDesignPattern.Models.Commands;

namespace CQRSDesignPattern.Commands
{
    public class CreateOrderCommandHandler
    {
       public void Handle(CreateOrderCommand command)
        {
            Console.WriteLine($"Created order: {command.OrderId}, Product: {command.ProductName}, Quantity: {command.Quantity}");
        }
        public void Delete(CreateOrderCommand command)
        {
            Console.WriteLine($"Delete order: {command.OrderId}, Product: {command.ProductName}, Quantity: {command.Quantity}");
        }
    }
}
