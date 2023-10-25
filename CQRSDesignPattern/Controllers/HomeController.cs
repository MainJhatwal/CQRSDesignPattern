using System.Net.WebSockets;
using CQRSDesignPattern.Commands;
using CQRSDesignPattern.Models.Commands;
using CQRSDesignPattern.Models.Queries;
using CQRSDesignPattern.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace CQRSDesignPattern.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class HomeController : Controller
    {
        [HttpGet (Name ="Index")] 
        public IActionResult Index()
        {
       
            {
                var command = new CreateOrderCommand { OrderId = "12345", ProductName = "Sample Product", Quantity = 5 };
                var commandHandler = new CreateOrderCommandHandler();
                commandHandler.Handle(command);

                var query = new GetOrderQuery { OrderId = "12345" };
                var queryHandler = new GetOrderQueryHandler();
                var order = queryHandler.Handle(query);
                var msg=($"Retrieved order: {order.OrderId}, Product: {order.ProductName}, Quantity: {order.Quantity}");

                var Filterquery = new GetFilterQuery { OrderId = "12345",ProductName="Test Prodyuct"};
                var filterOrder = queryHandler.Handle(Filterquery);              
               var filterMsg = ($"Retrieved order: {filterOrder.OrderId}, Product: {filterOrder.ProductName}, Quantity: {filterOrder.Quantity}");
                return Ok(msg+"\n"+filterMsg);
            }
          
        }

    }
}

