using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Warehouse.Service.Orders.Models;
using Warehouse.Service.Orders.Repositories;

namespace Warehouse.Service.Orders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderRepository _repository;

        public OrdersController(IOrderRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            return Ok(await _repository.GetAllOrdersAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(Guid id)
        {
            var order = await _repository.GetOrderAsync(id);
            if (order == null) return NotFound();
            return order;
        }

        [HttpGet("customer/{customerId}")]
        public async Task<ActionResult<List<Order>>> GetCustomerOrders(string customerId)
        {
            return await _repository.GetCustomerOrdersAsync(customerId);
        }

        [HttpPost]
        public async Task<ActionResult<Order>> CreateOrder(Order order)
        {
            var createdOrder = await _repository.CreateOrderAsync(order);
            return CreatedAtAction(nameof(GetOrder), new { id = createdOrder.Id }, createdOrder);
        }

        [HttpPut("{id}/status")]
        public async Task<IActionResult> UpdateOrderStatus(Guid id, [FromBody] OrderStatus status)
        {
            await _repository.UpdateOrderStatusAsync(id, status);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(Guid id)
        {
            await _repository.DeleteOrderAsync(id);
            return NoContent();
        }
    }
}
