using Warehouse.Service.Orders.Models;

namespace Warehouse.Service.Orders.Repositories
{
    public interface IOrderRepository
    {
        Task<Order> GetOrderAsync(Guid id);
        Task<List<Order>> GetAllOrdersAsync(); // Méthode ajoutée

        Task<List<Order>> GetCustomerOrdersAsync(string customerId);
        Task<Order> CreateOrderAsync(Order order);
        Task UpdateOrderStatusAsync(Guid orderId, OrderStatus status);
        Task DeleteOrderAsync(Guid id);
    }
}
