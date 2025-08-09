namespace Warehouse.Service.Inventory.Models
{
    public class InventoryItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string SKU { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }
        public int ReorderLevel { get; set; }
        public string Location { get; set; } = string.Empty;
        public DateTime LastUpdated { get; set; }
    }
}
