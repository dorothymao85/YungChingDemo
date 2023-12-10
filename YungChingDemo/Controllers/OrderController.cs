using Microsoft.AspNetCore.Mvc;
using YungChingDemo.Models;
using YungChingDemo.Service;

namespace YungChingDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class OrderController : ControllerBase
    {
        private IOrderService _orderService { get; set; }

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        [Route("get-all")]
        public IActionResult GetAllOrders()
        {
            var orders = _orderService.GetAllOrder();
            return new OkObjectResult(orders);
        }

        [HttpPost]
        [Route("get")]
        public IActionResult GetOrderById(int id)
        {
            var order = _orderService.GetOrderById(id);
            if (order == null)
            {
                return BadRequest();
            }

            return new OkObjectResult(order);
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddOrder([FromBody] Orders order)
        {
            _orderService.AddOrder(order);
            return new OkResult();
        }

        [HttpPost]
        [Route("update")]
        public IActionResult UpdateOrder(int id, [FromBody] Orders order)
        {
            if (id != order.OrderID)
            {
                return BadRequest();
            }

            _orderService.UpdateOrder(order);
            return new OkResult();
        }

        [HttpPost]
        [Route("delete")]
        public IActionResult DeleteOrder(int id)
        {
            _orderService.DeleteOrder(id);
            return new OkResult();
        }
    }
}
