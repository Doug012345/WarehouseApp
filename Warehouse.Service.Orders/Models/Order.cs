namespace Warehouse.Service.Orders.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string CustomerId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        public decimal TotalAmount { get; set; }
        public string ShippingAddress { get; set; }
        public List<OrderItem> Items { get; set; } = new();
    }
}
